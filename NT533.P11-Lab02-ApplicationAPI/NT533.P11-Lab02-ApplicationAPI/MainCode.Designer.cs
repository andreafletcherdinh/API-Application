namespace NT533.P11_Lab02_ApplicationAPI
{
    partial class APP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            createNetworkButton = new Button();
            staticNetworkAddressTextBox = new TextBox();
            networkAddressTextBox = new TextBox();
            subnetNameTextBox = new TextBox();
            networkNameTextBox = new TextBox();
            staticAddressLabel = new Label();
            networkAddressLabel = new Label();
            subnetNameLabel = new Label();
            networkNameLabel = new Label();
            groupBox2 = new GroupBox();
            flavorComboBox = new ComboBox();
            imageComboBox = new ComboBox();
            createIntanceButton = new Button();
            portLabel = new Label();
            nameLabel = new Label();
            flavorLabel = new Label();
            imageLabel = new Label();
            groupBox3 = new GroupBox();
            contentRichTextBox = new RichTextBox();
            listImageButton = new Button();
            listFlavorsButton = new Button();
            listKeypairButton = new Button();
            nameInstanceTextBox = new TextBox();
            portInstanceTextBox = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(createNetworkButton);
            groupBox1.Controls.Add(staticNetworkAddressTextBox);
            groupBox1.Controls.Add(networkAddressTextBox);
            groupBox1.Controls.Add(subnetNameTextBox);
            groupBox1.Controls.Add(networkNameTextBox);
            groupBox1.Controls.Add(staticAddressLabel);
            groupBox1.Controls.Add(networkAddressLabel);
            groupBox1.Controls.Add(subnetNameLabel);
            groupBox1.Controls.Add(networkNameLabel);
            groupBox1.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(21, 78, 91);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(411, 267);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Network";
            // 
            // createNetworkButton
            // 
            createNetworkButton.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createNetworkButton.ForeColor = Color.Black;
            createNetworkButton.Location = new Point(12, 203);
            createNetworkButton.Name = "createNetworkButton";
            createNetworkButton.Size = new Size(393, 45);
            createNetworkButton.TabIndex = 17;
            createNetworkButton.Text = "Create";
            createNetworkButton.UseVisualStyleBackColor = true;
            createNetworkButton.Click += createNetworkButton_Click;
            createNetworkButton.MouseLeave += createNetworkButton_MouseLeave;
            createNetworkButton.MouseHover += createNetworkButton_MouseHover;
            // 
            // staticNetworkAddressTextBox
            // 
            staticNetworkAddressTextBox.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            staticNetworkAddressTextBox.Location = new Point(170, 157);
            staticNetworkAddressTextBox.Name = "staticNetworkAddressTextBox";
            staticNetworkAddressTextBox.Size = new Size(235, 29);
            staticNetworkAddressTextBox.TabIndex = 7;
            // 
            // networkAddressTextBox
            // 
            networkAddressTextBox.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            networkAddressTextBox.Location = new Point(170, 117);
            networkAddressTextBox.Name = "networkAddressTextBox";
            networkAddressTextBox.Size = new Size(235, 29);
            networkAddressTextBox.TabIndex = 6;
            // 
            // subnetNameTextBox
            // 
            subnetNameTextBox.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subnetNameTextBox.Location = new Point(170, 80);
            subnetNameTextBox.Name = "subnetNameTextBox";
            subnetNameTextBox.Size = new Size(235, 29);
            subnetNameTextBox.TabIndex = 5;
            // 
            // networkNameTextBox
            // 
            networkNameTextBox.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            networkNameTextBox.Location = new Point(170, 44);
            networkNameTextBox.Name = "networkNameTextBox";
            networkNameTextBox.Size = new Size(235, 29);
            networkNameTextBox.TabIndex = 4;
            // 
            // staticAddressLabel
            // 
            staticAddressLabel.AutoSize = true;
            staticAddressLabel.Font = new Font("Cambria", 10.8F);
            staticAddressLabel.ForeColor = Color.Black;
            staticAddressLabel.Location = new Point(12, 160);
            staticAddressLabel.Name = "staticAddressLabel";
            staticAddressLabel.Size = new Size(118, 21);
            staticAddressLabel.TabIndex = 3;
            staticAddressLabel.Text = "Static address";
            // 
            // networkAddressLabel
            // 
            networkAddressLabel.AutoSize = true;
            networkAddressLabel.Font = new Font("Cambria", 10.8F);
            networkAddressLabel.ForeColor = Color.Black;
            networkAddressLabel.Location = new Point(12, 120);
            networkAddressLabel.Name = "networkAddressLabel";
            networkAddressLabel.Size = new Size(142, 21);
            networkAddressLabel.TabIndex = 2;
            networkAddressLabel.Text = "Network address";
            // 
            // subnetNameLabel
            // 
            subnetNameLabel.AutoSize = true;
            subnetNameLabel.Font = new Font("Cambria", 10.8F);
            subnetNameLabel.ForeColor = Color.Black;
            subnetNameLabel.Location = new Point(12, 83);
            subnetNameLabel.Name = "subnetNameLabel";
            subnetNameLabel.Size = new Size(111, 21);
            subnetNameLabel.TabIndex = 1;
            subnetNameLabel.Text = "Subnet name";
            // 
            // networkNameLabel
            // 
            networkNameLabel.AutoSize = true;
            networkNameLabel.Font = new Font("Cambria", 10.8F);
            networkNameLabel.ForeColor = Color.Black;
            networkNameLabel.Location = new Point(12, 47);
            networkNameLabel.Name = "networkNameLabel";
            networkNameLabel.Size = new Size(124, 21);
            networkNameLabel.TabIndex = 0;
            networkNameLabel.Text = "Network name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(portInstanceTextBox);
            groupBox2.Controls.Add(nameInstanceTextBox);
            groupBox2.Controls.Add(flavorComboBox);
            groupBox2.Controls.Add(imageComboBox);
            groupBox2.Controls.Add(createIntanceButton);
            groupBox2.Controls.Add(portLabel);
            groupBox2.Controls.Add(nameLabel);
            groupBox2.Controls.Add(flavorLabel);
            groupBox2.Controls.Add(imageLabel);
            groupBox2.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(21, 78, 91);
            groupBox2.Location = new Point(12, 294);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(411, 302);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Instance";
            // 
            // flavorComboBox
            // 
            flavorComboBox.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flavorComboBox.FormattingEnabled = true;
            flavorComboBox.Location = new Point(170, 96);
            flavorComboBox.Name = "flavorComboBox";
            flavorComboBox.Size = new Size(235, 29);
            flavorComboBox.TabIndex = 14;
            // 
            // imageComboBox
            // 
            imageComboBox.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            imageComboBox.FormattingEnabled = true;
            imageComboBox.Location = new Point(170, 54);
            imageComboBox.Name = "imageComboBox";
            imageComboBox.Size = new Size(235, 29);
            imageComboBox.TabIndex = 13;
            // 
            // createIntanceButton
            // 
            createIntanceButton.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createIntanceButton.ForeColor = Color.Black;
            createIntanceButton.Location = new Point(12, 227);
            createIntanceButton.Name = "createIntanceButton";
            createIntanceButton.Size = new Size(393, 54);
            createIntanceButton.TabIndex = 12;
            createIntanceButton.Text = "Create";
            createIntanceButton.UseVisualStyleBackColor = true;
            createIntanceButton.MouseLeave += createButton_MouseLeave;
            createIntanceButton.MouseHover += createButton_MouseHover;
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Font = new Font("Cambria", 10.8F);
            portLabel.ForeColor = Color.Black;
            portLabel.Location = new Point(12, 184);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(65, 21);
            portLabel.TabIndex = 11;
            portLabel.Text = "Port ID";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Cambria", 10.8F);
            nameLabel.ForeColor = Color.Black;
            nameLabel.Location = new Point(12, 144);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(55, 21);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "Name";
            // 
            // flavorLabel
            // 
            flavorLabel.AutoSize = true;
            flavorLabel.Font = new Font("Cambria", 10.8F);
            flavorLabel.ForeColor = Color.Black;
            flavorLabel.Location = new Point(12, 104);
            flavorLabel.Name = "flavorLabel";
            flavorLabel.Size = new Size(68, 21);
            flavorLabel.TabIndex = 9;
            flavorLabel.Text = "Flavors";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Font = new Font("Cambria", 10.8F);
            imageLabel.ForeColor = Color.Black;
            imageLabel.Location = new Point(12, 62);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new Size(58, 21);
            imageLabel.TabIndex = 8;
            imageLabel.Text = "Image";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(contentRichTextBox);
            groupBox3.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.FromArgb(21, 78, 91);
            groupBox3.Location = new Point(429, 21);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(811, 696);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Log";
            // 
            // contentRichTextBox
            // 
            contentRichTextBox.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contentRichTextBox.Location = new Point(6, 38);
            contentRichTextBox.Name = "contentRichTextBox";
            contentRichTextBox.Size = new Size(799, 652);
            contentRichTextBox.TabIndex = 0;
            contentRichTextBox.Text = "";
            // 
            // listImageButton
            // 
            listImageButton.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listImageButton.Location = new Point(12, 622);
            listImageButton.Name = "listImageButton";
            listImageButton.Size = new Size(123, 53);
            listImageButton.TabIndex = 4;
            listImageButton.Text = "List images";
            listImageButton.UseVisualStyleBackColor = true;
            listImageButton.Click += listImageButton_Click_1;
            listImageButton.MouseLeave += listImageButton_MouseLeave;
            listImageButton.MouseHover += listImageButton_MouseHover;
            // 
            // listFlavorsButton
            // 
            listFlavorsButton.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listFlavorsButton.Location = new Point(141, 622);
            listFlavorsButton.Name = "listFlavorsButton";
            listFlavorsButton.Size = new Size(140, 53);
            listFlavorsButton.TabIndex = 5;
            listFlavorsButton.Text = "List flavors";
            listFlavorsButton.UseVisualStyleBackColor = true;
            listFlavorsButton.Click += listFlavorsButton_Click;
            listFlavorsButton.MouseLeave += listFlavorsButton_MouseLeave;
            listFlavorsButton.MouseHover += listFlavorsButton_MouseHover;
            // 
            // listKeypairButton
            // 
            listKeypairButton.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listKeypairButton.Location = new Point(287, 622);
            listKeypairButton.Name = "listKeypairButton";
            listKeypairButton.Size = new Size(130, 53);
            listKeypairButton.TabIndex = 6;
            listKeypairButton.Text = "List keypairs";
            listKeypairButton.UseVisualStyleBackColor = true;
            listKeypairButton.Click += listKeypairButton_Click;
            listKeypairButton.MouseLeave += listKeypairButton_MouseLeave;
            listKeypairButton.MouseHover += listKeypairButton_MouseHover;
            // 
            // nameInstanceTextBox
            // 
            nameInstanceTextBox.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameInstanceTextBox.Location = new Point(170, 144);
            nameInstanceTextBox.Name = "nameInstanceTextBox";
            nameInstanceTextBox.Size = new Size(235, 29);
            nameInstanceTextBox.TabIndex = 18;
            // 
            // portInstanceTextBox
            // 
            portInstanceTextBox.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            portInstanceTextBox.Location = new Point(170, 184);
            portInstanceTextBox.Name = "portInstanceTextBox";
            portInstanceTextBox.Size = new Size(235, 29);
            portInstanceTextBox.TabIndex = 19;
            // 
            // APP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 729);
            Controls.Add(listKeypairButton);
            Controls.Add(listFlavorsButton);
            Controls.Add(listImageButton);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "APP";
            Text = "Main Application";
            Load += APP_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RichTextBox contentRichTextBox;
        private Label staticAddressLabel;
        private Label networkAddressLabel;
        private Label subnetNameLabel;
        private Label networkNameLabel;
        private TextBox networkNameTextBox;
        private TextBox staticNetworkAddressTextBox;
        private TextBox networkAddressTextBox;
        private TextBox subnetNameTextBox;
        private Button listImageButton;
        private Button listFlavorsButton;
        private Button listKeypairButton;
        private Label portLabel;
        private Label nameLabel;
        private Label flavorLabel;
        private Label imageLabel;
        private ComboBox imageComboBox;
        private Button createIntanceButton;
        private ComboBox flavorComboBox;
        private Button createNetworkButton;
        private TextBox portInstanceTextBox;
        private TextBox nameInstanceTextBox;
    }
}