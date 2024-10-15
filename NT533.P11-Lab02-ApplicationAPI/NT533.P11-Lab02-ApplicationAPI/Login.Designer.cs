namespace NT533.P11_Lab02_ApplicationAPI
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            picturePanel = new Panel();
            tittleLabel = new Label();
            welcomeLabel = new Label();
            userTextBox = new TextBox();
            passTextBox = new TextBox();
            domainTextBox = new TextBox();
            loginButton = new Button();
            projectNameTextBox = new TextBox();
            SuspendLayout();
            // 
            // picturePanel
            // 
            picturePanel.BackColor = Color.White;
            picturePanel.BackgroundImage = (Image)resources.GetObject("picturePanel.BackgroundImage");
            picturePanel.BackgroundImageLayout = ImageLayout.Stretch;
            picturePanel.Location = new Point(517, 0);
            picturePanel.Margin = new Padding(3, 4, 3, 4);
            picturePanel.Name = "picturePanel";
            picturePanel.Size = new Size(534, 845);
            picturePanel.TabIndex = 0;
            // 
            // tittleLabel
            // 
            tittleLabel.AutoSize = true;
            tittleLabel.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tittleLabel.ForeColor = Color.FromArgb(4, 120, 198);
            tittleLabel.Location = new Point(40, 125);
            tittleLabel.Name = "tittleLabel";
            tittleLabel.Size = new Size(426, 47);
            tittleLabel.TabIndex = 1;
            tittleLabel.Text = "Log in to your account";
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Cambria", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomeLabel.ForeColor = Color.FromArgb(124, 169, 201);
            welcomeLabel.Location = new Point(56, 188);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(387, 22);
            welcomeLabel.TabIndex = 2;
            welcomeLabel.Text = "Welcome back! Type your information to log in";
            // 
            // userTextBox
            // 
            userTextBox.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userTextBox.Location = new Point(40, 266);
            userTextBox.Margin = new Padding(3, 4, 3, 4);
            userTextBox.Name = "userTextBox";
            userTextBox.PlaceholderText = "Username";
            userTextBox.Size = new Size(411, 38);
            userTextBox.TabIndex = 4;
            // 
            // passTextBox
            // 
            passTextBox.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passTextBox.Location = new Point(40, 357);
            passTextBox.Margin = new Padding(3, 4, 3, 4);
            passTextBox.Name = "passTextBox";
            passTextBox.PasswordChar = '*';
            passTextBox.PlaceholderText = "Password";
            passTextBox.Size = new Size(411, 38);
            passTextBox.TabIndex = 6;
            // 
            // domainTextBox
            // 
            domainTextBox.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            domainTextBox.Location = new Point(40, 445);
            domainTextBox.Margin = new Padding(3, 4, 3, 4);
            domainTextBox.Name = "domainTextBox";
            domainTextBox.PlaceholderText = "Domain";
            domainTextBox.Size = new Size(411, 38);
            domainTextBox.TabIndex = 8;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginButton.Location = new Point(46, 617);
            loginButton.Margin = new Padding(3, 4, 3, 4);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(411, 60);
            loginButton.TabIndex = 9;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            loginButton.MouseLeave += loginButton_MouseLeave;
            loginButton.MouseHover += loginButton_MouseHover;
            // 
            // projectNameTextBox
            // 
            projectNameTextBox.Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectNameTextBox.Location = new Point(40, 524);
            projectNameTextBox.Name = "projectNameTextBox";
            projectNameTextBox.PlaceholderText = "Project name";
            projectNameTextBox.Size = new Size(411, 39);
            projectNameTextBox.TabIndex = 10;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 843);
            Controls.Add(projectNameTextBox);
            Controls.Add(loginButton);
            Controls.Add(domainTextBox);
            Controls.Add(passTextBox);
            Controls.Add(userTextBox);
            Controls.Add(welcomeLabel);
            Controls.Add(tittleLabel);
            Controls.Add(picturePanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel picturePanel;
        private Label tittleLabel;
        private Label welcomeLabel;
        private TextBox userTextBox;
        private TextBox passTextBox;
        private TextBox domainTextBox;
        private Button loginButton;
        private TextBox projectNameTextBox;
    }
}
