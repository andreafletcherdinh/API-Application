using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace NT533.P11_Lab02_ApplicationAPI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userTextBox.Text) ||
        string.IsNullOrEmpty(passTextBox.Text) ||
        string.IsNullOrEmpty(domainTextBox.Text) ||
        string.IsNullOrEmpty(projectNameTextBox.Text))
            {
                MessageBox.Show("You need to enter all information!");
                return;
            }

            // Prepare login data
            var loginData = new
            {
                auth = new
                {
                    identity = new
                    {
                        methods = new[] { "password" },
                        password = new
                        {
                            user = new
                            {
                                name = userTextBox.Text.Trim(),
                                domain = new { name = domainTextBox.Text.Trim() },
                                password = passTextBox.Text.Trim()
                            }
                        }
                    },
                    scope = new
                    {
                        project = new
                        {
                            name = projectNameTextBox.Text.Trim(),
                            domain = new { name = domainTextBox.Text.Trim() }
                        }
                    }
                }
            };

            // Gửi 1 yêu cầu của phương thức POST đến API của OpenStack
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var jsonContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(loginData), Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync("https://cloud-identity.uitiot.vn/v3/auth/tokens", jsonContent);

                    // Đọc nội dung trả về
                    var content = await response.Content.ReadAsStringAsync();

                    
                    Debug.WriteLine($"Full API Response: {content}");

                    if (response.IsSuccessStatusCode)
                    {
                        string token = response.Headers.GetValues("X-Subject-Token").FirstOrDefault();

                       
                        JObject jsonResponse = JObject.Parse(content);

                        // Lấy id của project (tenant ID)
                        string projectId = jsonResponse["token"]?["project"]?["id"]?.ToString();

                        if (string.IsNullOrEmpty(projectId))
                        {
                            var debugInfo = new System.Text.StringBuilder();
                            debugInfo.AppendLine("Failed to retrieve project ID from the response. Debug information:");
                            debugInfo.AppendLine($"Token: {(string.IsNullOrEmpty(token) ? "Not found" : "Found")}");
                            debugInfo.AppendLine($"Response status: {response.StatusCode}");
                            debugInfo.AppendLine("JSON structure:");
                            debugInfo.AppendLine(jsonResponse.ToString());

                            MessageBox.Show(debugInfo.ToString(), "Debug Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        MessageBox.Show($"Login successful! Project ID: {projectId}");

                        var appForm = new APP();
                        appForm.SetToken(token, projectId);
                        appForm.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show($"Login failed. Status code: {response.StatusCode}. Response content: {content}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}\n\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void loginButton_MouseHover(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.FromArgb(130, 202, 233);
            loginButton.Font = new Font(loginButton.Font, FontStyle.Bold);
            loginButton.Refresh();
        }

        private void loginButton_MouseLeave(object sender, EventArgs e)
        {
            loginButton.BackColor = SystemColors.Control;
            loginButton.Font = new Font(loginButton.Font, FontStyle.Regular);
        }
    }
}
