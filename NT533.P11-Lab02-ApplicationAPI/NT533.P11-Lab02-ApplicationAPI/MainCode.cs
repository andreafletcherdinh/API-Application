using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

namespace NT533.P11_Lab02_ApplicationAPI
{
    public partial class APP : Form
    {
        private HttpClient httpClient;
        private string token;  // Biến để lưu token
        private string tenantId;

        public APP()
        {
            InitializeComponent();
            httpClient = new HttpClient();
        }

        // Phương thức này sẽ nhận token từ form Login
        public void SetToken(string receivedToken, string tenantId)
        {
            token = receivedToken;  // Lưu token vào biến
            this.tenantId = tenantId;  // Lưu tenant_id vào biến
        }

        private void HandleTokenExpired()
        {
            // Đóng form APP hiện tại
            this.Close();

            // Hiển thị lại form Login để người dùng đăng nhập lại
            Login loginForm = new Login();
            loginForm.Show();
        }



        private void listImageButton_MouseHover(object sender, EventArgs e)
        {
            listImageButton.BackColor = Color.FromArgb(246, 239, 189);
            listImageButton.Font = new Font(listImageButton.Font, FontStyle.Bold);
            listImageButton.Refresh();
        }

        private void listImageButton_MouseLeave(object sender, EventArgs e)
        {
            listImageButton.BackColor = SystemColors.Control;
            listImageButton.Font = new Font(listImageButton.Font, FontStyle.Regular);
        }

        private void listFlavorsButton_MouseHover(object sender, EventArgs e)
        {
            listFlavorsButton.BackColor = Color.FromArgb(228, 192, 135);
            listFlavorsButton.Font = new Font(listFlavorsButton.Font, FontStyle.Bold);
            listFlavorsButton.Refresh();
        }

        private void listFlavorsButton_MouseLeave(object sender, EventArgs e)
        {
            listFlavorsButton.BackColor = SystemColors.Control;
            listFlavorsButton.Font = new Font(listFlavorsButton.Font, FontStyle.Regular);
        }

        private void listKeypairButton_MouseHover(object sender, EventArgs e)
        {
            listKeypairButton.BackColor = Color.FromArgb(188, 124, 124);
            listKeypairButton.Font = new Font(listKeypairButton.Font, FontStyle.Bold);
            listKeypairButton.Refresh();
        }

        private void listKeypairButton_MouseLeave(object sender, EventArgs e)
        {
            listKeypairButton.BackColor = SystemColors.Control;
            listKeypairButton.Font = new Font(listKeypairButton.Font, FontStyle.Regular);
        }


        // Hàm để lấy thông tin Image từ OpenStack API
        private async Task<List<Image>> GetImageInfoFromOpenStack()
        {
            try
            {
                string url = "https://cloud-image.uitiot.vn/v2/images";
                httpClient.DefaultRequestHeaders.Clear();
                httpClient.DefaultRequestHeaders.Add("X-Auth-Token", token);

                HttpResponseMessage response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return ParseImageInfo(jsonResponse);
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    HandleTokenExpired();
                    return null;
                }
                else
                {
                    MessageBox.Show($"Lỗi: {response.StatusCode}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private List<Image> ParseImageInfo(string jsonResponse)
        {
            List<Image> images = new List<Image>();
            JObject jsonObject = JObject.Parse(jsonResponse);
            JArray imagesArray = (JArray)jsonObject["images"];

            foreach (var image in imagesArray)
            {
                images.Add(new Image
                {
                    Id = (string)image["id"],
                    Name = (string)image["name"]
                });
            }

            return images;
        }

        public class Image
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }

        private async Task PopulateImageComboBox()
        {
            List<Image> images = await GetImageInfoFromOpenStack();
            if (images != null)
            {
                imageComboBox.DataSource = images;
                imageComboBox.DisplayMember = "Name";
                imageComboBox.ValueMember = "Id";
            }
        }


        // Hàm này được gọi khi người dùng nhấn vào nút lấy danh sách image
        private async void listImageButton_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(token))
            {
                await PopulateImageComboBox();
                List<Image> images = (List<Image>)imageComboBox.DataSource;
                if (images != null)
                {
                    string imageInfo = string.Join("\n", images.Select(img => $"ID: {img.Id}, Tên: {img.Name}"));
                    contentRichTextBox.Text = imageInfo;
                }
            }
            else
            {
                MessageBox.Show("Token chưa được thiết lập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class Flavor
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }



        // Hàm để lấy thông tin từ OpenStack API (Flavors)
        private async Task<List<Flavor>> GetFlavorInfoFromOpenStack()
        {
            try
            {
                string url = "https://cloud-compute.uitiot.vn/v2.1/flavors";
                httpClient.DefaultRequestHeaders.Clear();
                httpClient.DefaultRequestHeaders.Add("X-Auth-Token", token);

                HttpResponseMessage response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return ParseFlavorInfo(jsonResponse);
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    HandleTokenExpired();
                    return null;
                }
                else
                {
                    MessageBox.Show($"Lỗi: {response.StatusCode}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private List<Flavor> ParseFlavorInfo(string jsonResponse)
        {
            List<Flavor> flavors = new List<Flavor>();
            JObject jsonObject = JObject.Parse(jsonResponse);
            JArray flavorsArray = (JArray)jsonObject["flavors"];

            foreach (var flavor in flavorsArray)
            {
                flavors.Add(new Flavor
                {
                    Id = (string)flavor["id"],
                    Name = (string)flavor["name"]
                });
            }

            return flavors;
        }

        private async Task PopulateFlavorComboBox()
        {
            List<Flavor> flavors = await GetFlavorInfoFromOpenStack();
            if (flavors != null)
            {
                flavorComboBox.DataSource = flavors;
                flavorComboBox.DisplayMember = "Name";
                flavorComboBox.ValueMember = "Id";
            }
        }

        // Hàm này được gọi khi người dùng nhấn vào nút lấy danh sách flavors
        private async void listFlavorsButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(token))
            {
                await PopulateFlavorComboBox();
                List<Flavor> flavors = (List<Flavor>)flavorComboBox.DataSource;
                if (flavors != null)
                {
                    string flavorInfo = string.Join("\n", flavors.Select(f => $"ID: {f.Id}, Tên: {f.Name}"));
                    contentRichTextBox.Text = flavorInfo;
                }
            }
            else
            {
                MessageBox.Show("Token chưa được thiết lập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void APP_Load(object sender, EventArgs e)
        {
            await PopulateImageComboBox();
            await PopulateFlavorComboBox();
        }

        // Hàm để lấy thông tin từ OpenStack API (Keypairs)
        private async Task<string> GetKeypairInfoFromOpenStack()
        {
            try
            {
                string url = "https://cloud-compute.uitiot.vn/v2.1/os-keypairs";  // URL cho keypairs

                // Clear và thêm lại token vào header
                httpClient.DefaultRequestHeaders.Clear();
                httpClient.DefaultRequestHeaders.Add("X-Auth-Token", token);

                // Gửi request để lấy thông tin các keypairs
                HttpResponseMessage response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return jsonResponse;
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    // Nếu nhận được lỗi 401 (Unauthorized), xử lý hết hạn token
                    HandleTokenExpired();
                    return null;
                }
                else
                {
                    return $"Error: {response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        // Sự kiện khi bấm vào nút listKeypairButton
        private async void listKeypairButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(token))
            {
                string keypairInfo = await GetKeypairInfoFromOpenStack();
                if (keypairInfo != null)
                {
                    contentRichTextBox.Text = keypairInfo;
                }
            }
            else
            {
                MessageBox.Show("Token chưa được thiết lập!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void createButton_MouseHover(object sender, EventArgs e) 
        {
            createIntanceButton.BackColor = Color.FromArgb(162, 210, 223);
            createIntanceButton.Font = new Font(createIntanceButton.Font, FontStyle.Bold);
            createIntanceButton.Refresh();
        }

        private void createButton_MouseLeave(object sender, EventArgs e)
        {
            createIntanceButton.BackColor = SystemColors.Control;
            createIntanceButton.Font = new Font(createIntanceButton.Font, FontStyle.Regular);
        }

        private void createNetworkButton_MouseHover (object sender, EventArgs e)
        {
            createNetworkButton.BackColor = Color.FromArgb(255, 227, 227);
            createNetworkButton.Font = new Font(createNetworkButton.Font, FontStyle.Bold);
            createNetworkButton.Refresh();
        }

        private void createNetworkButton_MouseLeave(Object sender, EventArgs e)
        {
            createNetworkButton.BackColor = SystemColors.Control;
            createNetworkButton.Font = new Font(createNetworkButton.Font, FontStyle.Regular);
        }
        private bool IsValidCIDR(string cidr)
        {
            // Kiểm tra định dạng CIDR bằng regex
            string pattern = @"^(\d{1,3}\.){3}\d{1,3}\/([0-2]?[0-9]|3[0-2])$";
            return Regex.IsMatch(cidr, pattern);
        }

        private async void createNetworkButton_Click(object sender, EventArgs e)
        {
            string networkName = networkNameTextBox.Text.Trim();
            string subnetName = subnetNameTextBox.Text.Trim();
            string networkAddress = networkAddressTextBox.Text.Trim();
            string staticNetworkAddress = staticNetworkAddressTextBox.Text.Trim();

            // Kiểm tra các trường nhập liệu
            if (string.IsNullOrEmpty(networkName) || string.IsNullOrEmpty(subnetName) || string.IsNullOrEmpty(networkAddress) || string.IsNullOrEmpty(staticNetworkAddress))
            {
                MessageBox.Show("Please fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra định dạng CIDR
            if (!IsValidCIDR(networkAddress))
            {
                MessageBox.Show("Invalid network address format! Please use CIDR format (e.g., 192.168.1.0/24).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gọi hàm tạo mạng với tenantId
            string result = await CreateNetworkAsync(networkName, subnetName, networkAddress, staticNetworkAddress, tenantId);
            if (result != null)
            {
                contentRichTextBox.Text = result;
            }
            else
            {
                MessageBox.Show("Failed to create network!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<string> CreateNetworkAsync(string networkName, string subnetName, string networkAddress, string staticNetworkAddress, string tenantId)
        {
            try
            {
                if (string.IsNullOrEmpty(tenantId))
                {
                    throw new ArgumentNullException(nameof(tenantId), "Tenant ID cannot be null.");
                }

                string url = "https://cloud-network.uitiot.vn/v2.0/networks";

                // Tạo đối tượng để gửi yêu cầu
                var networkData = new
                {
                    network = new
                    {
                        name = networkName,
                        admin_state_up = true,
                        tenant_id = tenantId  // Thêm tenant_id vào dữ liệu
                    }
                };

                // Gửi yêu cầu tạo mạng
                var jsonContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(networkData), Encoding.UTF8, "application/json");

                // Đặt header cho yêu cầu
                httpClient.DefaultRequestHeaders.Clear();
                httpClient.DefaultRequestHeaders.Add("X-Auth-Token", token);

                // Gửi yêu cầu POST để tạo mạng
                HttpResponseMessage response = await httpClient.PostAsync(url, jsonContent);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    // Nếu tạo mạng thành công, tiếp tục tạo subnet
                    var networkResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<NetworkResponse>(jsonResponse);
                    var networkId = networkResponse.network.id;  // Lấy ID của mạng đã tạo

                    // Tạo subnet
                    return await CreateSubnetAsync(subnetName, networkAddress, networkId, staticNetworkAddress, tenantId);
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    HandleTokenExpired();  // Xử lý nếu token hết hạn
                    return null;
                }
                else
                {
                    return $"Error: {response.StatusCode} - {await response.Content.ReadAsStringAsync()}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while creating network: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }



        private async Task<string> CreateSubnetAsync(string subnetName, string networkAddress, string networkId, string staticNetworkAddress, string tenantId)
        {
            try
            {
                if (string.IsNullOrEmpty(tenantId))
                {
                    throw new ArgumentNullException(nameof(tenantId), "Tenant ID cannot be null.");
                }

                string url = "https://cloud-network.uitiot.vn/v2.0/subnets";

                var subnetData = new
                {
                    subnet = new
                    {
                        name = subnetName,
                        ip_version = 4,
                        cidr = networkAddress,
                        network_id = networkId,
                        tenant_id = tenantId,  // Thêm tenant_id vào dữ liệu
                        allocation_pools = new[]
                        {
                    new { start = staticNetworkAddress, end = staticNetworkAddress }
                }
                    }
                };

                var jsonContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(subnetData), Encoding.UTF8, "application/json");

                // Đặt header cho yêu cầu
                httpClient.DefaultRequestHeaders.Clear();
                httpClient.DefaultRequestHeaders.Add("X-Auth-Token", token);

                // Gửi yêu cầu POST để tạo subnet
                HttpResponseMessage response = await httpClient.PostAsync(url, jsonContent);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync(); // Trả về thông tin về subnet đã tạo
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    HandleTokenExpired();  // Xử lý nếu token hết hạn
                    return null;
                }
                else
                {
                    return $"Error: {response.StatusCode} - {await response.Content.ReadAsStringAsync()}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while creating subnet: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        // Phân loại response
        public class NetworkResponse
        {
            public Network network { get; set; }
        }

        public class Network
        {
            public string id { get; set; }
            public string tenant_id { get; set; }
        }
    }
}
