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
            networkIdTextBox = new TextBox();
            networkIdLabel = new Label();
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
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(210, 224, 251);
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
            groupBox1.Location = new Point(11, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(411, 287);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Network";
            // 
            // portAddressTextBox
            // 
            portAddressTextBox.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            portAddressTextBox.Location = new Point(169, 167);
            portAddressTextBox.Name = "portAddressTextBox";
            portAddressTextBox.Size = new Size(235, 29);
            portAddressTextBox.TabIndex = 18;
            // 
            // createNetworkButton
            // 
            createNetworkButton.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createNetworkButton.ForeColor = Color.Black;
            createNetworkButton.Location = new Point(11, 221);
            createNetworkButton.Name = "createNetworkButton";
            createNetworkButton.Size = new Size(393, 45);
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
            portLabel.Location = new Point(13, 167);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(113, 21);
            portLabel.TabIndex = 18;
            portLabel.Text = "Port address:";
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
            // networkAddressLabel
            // 
            networkAddressLabel.AutoSize = true;
            networkAddressLabel.Font = new Font("Cambria", 10.8F);
            networkAddressLabel.ForeColor = Color.Black;
            networkAddressLabel.Location = new Point(11, 120);
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
            subnetNameLabel.Location = new Point(11, 83);
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
            networkNameLabel.Location = new Point(11, 47);
            networkNameLabel.Name = "networkNameLabel";
            networkNameLabel.Size = new Size(124, 21);
            networkNameLabel.TabIndex = 0;
            networkNameLabel.Text = "Network name";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(254, 249, 217);
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
            groupBox2.Location = new Point(11, 313);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(411, 294);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Instance";
            // 
            // networkIdTextBox
            // 
            networkIdTextBox.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            networkIdTextBox.Location = new Point(169, 186);
            networkIdTextBox.Name = "networkIdTextBox";
            networkIdTextBox.Size = new Size(235, 29);
            networkIdTextBox.TabIndex = 21;
            // 
            // networkIdLabel
            // 
            networkIdLabel.AutoSize = true;
            networkIdLabel.Font = new Font("Cambria", 10.8F);
            networkIdLabel.ForeColor = Color.Black;
            networkIdLabel.Location = new Point(13, 186);
            networkIdLabel.Name = "networkIdLabel";
            networkIdLabel.Size = new Size(99, 21);
            networkIdLabel.TabIndex = 20;
            networkIdLabel.Text = "Network ID";
            // 
            // nameInstanceTextBox
            // 
            nameInstanceTextBox.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameInstanceTextBox.Location = new Point(169, 140);
            nameInstanceTextBox.Name = "nameInstanceTextBox";
            nameInstanceTextBox.Size = new Size(235, 29);
            nameInstanceTextBox.TabIndex = 18;
            // 
            // flavorComboBox
            // 
            flavorComboBox.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            flavorComboBox.FormattingEnabled = true;
            flavorComboBox.Location = new Point(170, 96);
            flavorComboBox.Name = "flavorComboBox";
            flavorComboBox.Size = new Size(235, 30);
            flavorComboBox.TabIndex = 14;
            // 
            // imageComboBox
            // 
            imageComboBox.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            imageComboBox.FormattingEnabled = true;
            imageComboBox.Location = new Point(170, 53);
            imageComboBox.Name = "imageComboBox";
            imageComboBox.Size = new Size(235, 30);
            imageComboBox.TabIndex = 13;
            // 
            // createIntanceButton
            // 
            createIntanceButton.Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createIntanceButton.ForeColor = Color.Black;
            createIntanceButton.Location = new Point(14, 235);
            createIntanceButton.Name = "createIntanceButton";
            createIntanceButton.Size = new Size(391, 42);
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
            nameLabel.Location = new Point(11, 144);
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
            flavorLabel.Location = new Point(11, 104);
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
            imageLabel.Location = new Point(11, 61);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new Size(58, 21);
            imageLabel.TabIndex = 8;
            imageLabel.Text = "Image";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(222, 229, 212);
            groupBox3.Controls.Add(contentRichTextBox);
            groupBox3.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.FromArgb(21, 78, 91);
            groupBox3.Location = new Point(429, 21);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(811, 741);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Log";
            // 
            // contentRichTextBox
            // 
            contentRichTextBox.BackColor = Color.FromArgb(142, 172, 205);
            contentRichTextBox.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contentRichTextBox.Location = new Point(6, 37);
            contentRichTextBox.Name = "contentRichTextBox";
            contentRichTextBox.Size = new Size(798, 735);
            contentRichTextBox.TabIndex = 0;
            contentRichTextBox.Text = "";
            // 
            // listImageButton
            // 
            listImageButton.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listImageButton.ForeColor = Color.Black;
            listImageButton.Location = new Point(13, 49);
            listImageButton.Name = "listImageButton";
            listImageButton.Size = new Size(123, 53);
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
            listKeypairButton.Location = new Point(142, 49);
            listKeypairButton.Name = "listKeypairButton";
            listKeypairButton.Size = new Size(263, 53);
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
            listFlavorsButton.Location = new Point(14, 121);
            listFlavorsButton.Name = "listFlavorsButton";
            listFlavorsButton.Size = new Size(390, 53);
            listFlavorsButton.TabIndex = 5;
            listFlavorsButton.Text = "List flavors";
            listFlavorsButton.UseVisualStyleBackColor = true;
            listFlavorsButton.Click += listFlavorsButton_Click;
            listFlavorsButton.MouseLeave += listFlavorsButton_MouseLeave;
            listFlavorsButton.MouseHover += listFlavorsButton_MouseHover;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(228, 192, 135);
            groupBox4.Controls.Add(listFlavorsButton);
            groupBox4.Controls.Add(listImageButton);
            groupBox4.Controls.Add(listKeypairButton);
            groupBox4.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(11, 613);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(411, 180);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "List";
            // 
            // APP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1253, 805);
            Controls.Add(groupBox4);
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
            groupBox4.ResumeLayout(false);
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
        private GroupBox groupBox4;
    }
}