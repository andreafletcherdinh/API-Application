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
            portAddressTextBox = new TextBox();
            createNetworkButton = new Button();
            portLabel = new Label();
            networkAddressTextBox = new TextBox();
            subnetNameTextBox = new TextBox();
            networkNameTextBox = new TextBox();
            networkAddressLabel = new Label();
            subnetNameLabel = new Label();
            networkNameLabel = new Label();
            groupBox2 = new GroupBox();
            nameInstanceTextBox = new TextBox();
            flavorComboBox = new ComboBox();
            imageComboBox = new ComboBox();
            createIntanceButton = new Button();
            nameLabel = new Label();
            flavorLabel = new Label();
            imageLabel = new Label();
            groupBox3 = new GroupBox();
            contentRichTextBox = new RichTextBox();
            listImageButton = new Button();
            listKeypairButton = new Button();
            listFlavorsButton = new Button();
            networkIdTextBox = new TextBox();
            networkIdLabel = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(portAddressTextBox);
            groupBox1.Controls.Add(createNetworkButton);
            groupBox1.Controls.Add(portLabel);
            groupBox1.Controls.Add(networkAddressTextBox);
            groupBox1.Controls.Add(subnetNameTextBox);
            groupBox1.Controls.Add(networkNameTextBox);
            groupBox1.Controls.Add(networkAddressLabel);
            groupBox1.Controls.Add(subnetNameLabel);
            groupBox1.Controls.Add(networkNameLabel);
            groupBox1.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(21, 78, 91);
            groupBox1.Location = new Point(10, 16);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(360, 215);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Network";
            // 
            // portAddressTextBox
            // 
            portAddressTextBox.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            portAddressTextBox.Location = new Point(148, 125);
            portAddressTextBox.Margin = new Padding(3, 2, 3, 2);
            portAddressTextBox.Name = "portAddressTextBox";
            portAddressTextBox.Size = new Size(206, 24);
            portAddressTextBox.TabIndex = 18;
            // 
            // createNetworkButton
            // 
            createNetworkButton.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createNetworkButton.ForeColor = Color.Black;
            createNetworkButton.Location = new Point(10, 166);
            createNetworkButton.Margin = new Padding(3, 2, 3, 2);
            createNetworkButton.Name = "createNetworkButton";
            createNetworkButton.Size = new Size(344, 34);
            createNetworkButton.TabIndex = 17;
            createNetworkButton.Text = "Create";
            createNetworkButton.UseVisualStyleBackColor = true;
            createNetworkButton.Click += createNetworkButton_Click;
            createNetworkButton.MouseLeave += createNetworkButton_MouseLeave;
            createNetworkButton.MouseHover += createNetworkButton_MouseHover;
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Font = new Font("Cambria", 10.8F);
            portLabel.ForeColor = Color.Black;
            portLabel.Location = new Point(11, 125);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(91, 17);
            portLabel.TabIndex = 18;
            portLabel.Text = "Port address:";
            // 
            // networkAddressTextBox
            // 
            networkAddressTextBox.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            networkAddressTextBox.Location = new Point(149, 88);
            networkAddressTextBox.Margin = new Padding(3, 2, 3, 2);
            networkAddressTextBox.Name = "networkAddressTextBox";
            networkAddressTextBox.Size = new Size(206, 24);
            networkAddressTextBox.TabIndex = 6;
            // 
            // subnetNameTextBox
            // 
            subnetNameTextBox.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subnetNameTextBox.Location = new Point(149, 60);
            subnetNameTextBox.Margin = new Padding(3, 2, 3, 2);
            subnetNameTextBox.Name = "subnetNameTextBox";
            subnetNameTextBox.Size = new Size(206, 24);
            subnetNameTextBox.TabIndex = 5;
            // 
            // networkNameTextBox
            // 
            networkNameTextBox.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            networkNameTextBox.Location = new Point(149, 33);
            networkNameTextBox.Margin = new Padding(3, 2, 3, 2);
            networkNameTextBox.Name = "networkNameTextBox";
            networkNameTextBox.Size = new Size(206, 24);
            networkNameTextBox.TabIndex = 4;
            // 
            // networkAddressLabel
            // 
            networkAddressLabel.AutoSize = true;
            networkAddressLabel.Font = new Font("Cambria", 10.8F);
            networkAddressLabel.ForeColor = Color.Black;
            networkAddressLabel.Location = new Point(10, 90);
            networkAddressLabel.Name = "networkAddressLabel";
            networkAddressLabel.Size = new Size(115, 17);
            networkAddressLabel.TabIndex = 2;
            networkAddressLabel.Text = "Network address";
            // 
            // subnetNameLabel
            // 
            subnetNameLabel.AutoSize = true;
            subnetNameLabel.Font = new Font("Cambria", 10.8F);
            subnetNameLabel.ForeColor = Color.Black;
            subnetNameLabel.Location = new Point(10, 62);
            subnetNameLabel.Name = "subnetNameLabel";
            subnetNameLabel.Size = new Size(88, 17);
            subnetNameLabel.TabIndex = 1;
            subnetNameLabel.Text = "Subnet name";
            // 
            // networkNameLabel
            // 
            networkNameLabel.AutoSize = true;
            networkNameLabel.Font = new Font("Cambria", 10.8F);
            networkNameLabel.ForeColor = Color.Black;
            networkNameLabel.Location = new Point(10, 35);
            networkNameLabel.Name = "networkNameLabel";
            networkNameLabel.Size = new Size(101, 17);
            networkNameLabel.TabIndex = 0;
            networkNameLabel.Text = "Network name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(networkIdTextBox);
            groupBox2.Controls.Add(networkIdLabel);
            groupBox2.Controls.Add(nameInstanceTextBox);
            groupBox2.Controls.Add(flavorComboBox);
            groupBox2.Controls.Add(imageComboBox);
            groupBox2.Controls.Add(createIntanceButton);
            groupBox2.Controls.Add(nameLabel);
            groupBox2.Controls.Add(flavorLabel);
            groupBox2.Controls.Add(imageLabel);
            groupBox2.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(21, 78, 91);
            groupBox2.Location = new Point(10, 235);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(360, 274);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Instance";
            // 
            // nameInstanceTextBox
            // 
            nameInstanceTextBox.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameInstanceTextBox.Location = new Point(148, 105);
            nameInstanceTextBox.Margin = new Padding(3, 2, 3, 2);
            nameInstanceTextBox.Name = "nameInstanceTextBox";
            nameInstanceTextBox.Size = new Size(206, 24);
            nameInstanceTextBox.TabIndex = 18;
            // 
            // flavorComboBox
            // 
            flavorComboBox.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            flavorComboBox.FormattingEnabled = true;
            flavorComboBox.Location = new Point(149, 72);
            flavorComboBox.Margin = new Padding(3, 2, 3, 2);
            flavorComboBox.Name = "flavorComboBox";
            flavorComboBox.Size = new Size(206, 25);
            flavorComboBox.TabIndex = 14;
            // 
            // imageComboBox
            // 
            imageComboBox.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            imageComboBox.FormattingEnabled = true;
            imageComboBox.Location = new Point(149, 40);
            imageComboBox.Margin = new Padding(3, 2, 3, 2);
            imageComboBox.Name = "imageComboBox";
            imageComboBox.Size = new Size(206, 25);
            imageComboBox.TabIndex = 13;
            // 
            // createIntanceButton
            // 
            createIntanceButton.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createIntanceButton.ForeColor = Color.Black;
            createIntanceButton.Location = new Point(10, 218);
            createIntanceButton.Margin = new Padding(3, 2, 3, 2);
            createIntanceButton.Name = "createIntanceButton";
            createIntanceButton.Size = new Size(344, 40);
            createIntanceButton.TabIndex = 12;
            createIntanceButton.Text = "Create";
            createIntanceButton.UseVisualStyleBackColor = true;
            createIntanceButton.Click += createIntanceButton_Click;
            createIntanceButton.MouseLeave += createButton_MouseLeave;
            createIntanceButton.MouseHover += createButton_MouseHover;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Cambria", 10.8F);
            nameLabel.ForeColor = Color.Black;
            nameLabel.Location = new Point(10, 108);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(44, 17);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "Name";
            // 
            // flavorLabel
            // 
            flavorLabel.AutoSize = true;
            flavorLabel.Font = new Font("Cambria", 10.8F);
            flavorLabel.ForeColor = Color.Black;
            flavorLabel.Location = new Point(10, 78);
            flavorLabel.Name = "flavorLabel";
            flavorLabel.Size = new Size(55, 17);
            flavorLabel.TabIndex = 9;
            flavorLabel.Text = "Flavors";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Font = new Font("Cambria", 10.8F);
            imageLabel.ForeColor = Color.Black;
            imageLabel.Location = new Point(10, 46);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new Size(46, 17);
            imageLabel.TabIndex = 8;
            imageLabel.Text = "Image";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(contentRichTextBox);
            groupBox3.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.FromArgb(21, 78, 91);
            groupBox3.Location = new Point(375, 16);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(710, 556);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Log";
            // 
            // contentRichTextBox
            // 
            contentRichTextBox.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contentRichTextBox.Location = new Point(5, 28);
            contentRichTextBox.Margin = new Padding(3, 2, 3, 2);
            contentRichTextBox.Name = "contentRichTextBox";
            contentRichTextBox.Size = new Size(699, 528);
            contentRichTextBox.TabIndex = 0;
            contentRichTextBox.Text = "";
            // 
            // listImageButton
            // 
            listImageButton.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listImageButton.ForeColor = Color.Black;
            listImageButton.Location = new Point(13, 513);
            listImageButton.Margin = new Padding(3, 2, 3, 2);
            listImageButton.Name = "listImageButton";
            listImageButton.Size = new Size(108, 40);
            listImageButton.TabIndex = 4;
            listImageButton.Text = "List images";
            listImageButton.UseVisualStyleBackColor = true;
            listImageButton.Click += listImageButton_Click_1;
            listImageButton.MouseLeave += listImageButton_MouseLeave;
            listImageButton.MouseHover += listImageButton_MouseHover;
            // 
            // listKeypairButton
            // 
            listKeypairButton.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listKeypairButton.ForeColor = Color.Black;
            listKeypairButton.Location = new Point(127, 513);
            listKeypairButton.Margin = new Padding(3, 2, 3, 2);
            listKeypairButton.Name = "listKeypairButton";
            listKeypairButton.Size = new Size(114, 40);
            listKeypairButton.TabIndex = 6;
            listKeypairButton.Text = "List keypairs";
            listKeypairButton.UseVisualStyleBackColor = true;
            listKeypairButton.Click += listKeypairButton_Click;
            listKeypairButton.MouseLeave += listKeypairButton_MouseLeave;
            listKeypairButton.MouseHover += listKeypairButton_MouseHover;
            // 
            // listFlavorsButton
            // 
            listFlavorsButton.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listFlavorsButton.ForeColor = Color.Black;
            listFlavorsButton.Location = new Point(247, 513);
            listFlavorsButton.Margin = new Padding(3, 2, 3, 2);
            listFlavorsButton.Name = "listFlavorsButton";
            listFlavorsButton.Size = new Size(122, 40);
            listFlavorsButton.TabIndex = 5;
            listFlavorsButton.Text = "List flavors";
            listFlavorsButton.UseVisualStyleBackColor = true;
            listFlavorsButton.Click += listFlavorsButton_Click;
            listFlavorsButton.MouseLeave += listFlavorsButton_MouseLeave;
            listFlavorsButton.MouseHover += listFlavorsButton_MouseHover;
            // 
            // networkIdTextBox
            // 
            networkIdTextBox.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            networkIdTextBox.Location = new Point(148, 171);
            networkIdTextBox.Margin = new Padding(3, 2, 3, 2);
            networkIdTextBox.Name = "networkIdTextBox";
            networkIdTextBox.Size = new Size(206, 24);
            networkIdTextBox.TabIndex = 21;
            // 
            // networkIdLabel
            // 
            networkIdLabel.AutoSize = true;
            networkIdLabel.Font = new Font("Cambria", 10.8F);
            networkIdLabel.ForeColor = Color.Black;
            networkIdLabel.Location = new Point(11, 171);
            networkIdLabel.Name = "networkIdLabel";
            networkIdLabel.Size = new Size(82, 17);
            networkIdLabel.TabIndex = 20;
            networkIdLabel.Text = "Network ID";
            // 
            // APP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 604);
            Controls.Add(groupBox3);
            Controls.Add(listFlavorsButton);
            Controls.Add(listKeypairButton);
            Controls.Add(listImageButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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
        private Label nameLabel;
        private Label flavorLabel;
        private Label imageLabel;
        private ComboBox imageComboBox;
        private Button createIntanceButton;
        private ComboBox flavorComboBox;
        private Button createNetworkButton;
        private TextBox nameInstanceTextBox;
        private Label portLabel;
        private TextBox portAddressTextBox;
        private TextBox networkIdTextBox;
        private Label networkIdLabel;
    }
}