namespace FirstTrypos
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            timer2 = new System.Windows.Forms.Timer(components);
            mainframe = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dropdown = new FlowLayoutPanel();
            panel1 = new Panel();
            dropdownButton = new Button();
            posButton = new Button();
            inventoryButton = new Button();
            settingsButton = new Button();
            header = new Panel();
            homepagetag = new Label();
            profilepicture = new PictureBox();
            profilename = new Label();
            mainframe.SuspendLayout();
            dropdown.SuspendLayout();
            panel1.SuspendLayout();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilepicture).BeginInit();
            SuspendLayout();
            // 
            // timer2
            // 
            timer2.Interval = 1;
            timer2.Tick += timer2_Tick;
            // 
            // mainframe
            // 
            mainframe.BackColor = Color.White;
            mainframe.Controls.Add(flowLayoutPanel1);
            mainframe.Location = new Point(0, 26);
            mainframe.Name = "mainframe";
            mainframe.Size = new Size(1922, 968);
            mainframe.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(406, 216);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(8, 8);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // dropdown
            // 
            dropdown.BackColor = Color.White;
            dropdown.Controls.Add(panel1);
            dropdown.Controls.Add(posButton);
            dropdown.Controls.Add(inventoryButton);
            dropdown.Controls.Add(settingsButton);
            dropdown.FlowDirection = FlowDirection.TopDown;
            dropdown.Location = new Point(1710, 0);
            dropdown.MaximumSize = new Size(212, 232);
            dropdown.MinimumSize = new Size(212, 65);
            dropdown.Name = "dropdown";
            dropdown.Size = new Size(212, 65);
            dropdown.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(dropdownButton);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 65);
            panel1.TabIndex = 0;
            // 
            // dropdownButton
            // 
            dropdownButton.Cursor = Cursors.Hand;
            dropdownButton.FlatStyle = FlatStyle.Flat;
            dropdownButton.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dropdownButton.ForeColor = Color.Black;
            dropdownButton.Location = new Point(0, 0);
            dropdownButton.Margin = new Padding(0);
            dropdownButton.Name = "dropdownButton";
            dropdownButton.Size = new Size(212, 65);
            dropdownButton.TabIndex = 0;
            dropdownButton.Text = "☰";
            dropdownButton.UseVisualStyleBackColor = true;
            dropdownButton.Click += dropdownButton_Click;
            // 
            // posButton
            // 
            posButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            posButton.ForeColor = Color.Black;
            posButton.Location = new Point(212, 0);
            posButton.Margin = new Padding(0);
            posButton.Name = "posButton";
            posButton.Size = new Size(210, 56);
            posButton.TabIndex = 1;
            posButton.Text = "POS";
            posButton.UseVisualStyleBackColor = true;
            posButton.Click += posButton_Click;
            // 
            // inventoryButton
            // 
            inventoryButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inventoryButton.ForeColor = Color.Black;
            inventoryButton.Location = new Point(422, 0);
            inventoryButton.Margin = new Padding(0);
            inventoryButton.Name = "inventoryButton";
            inventoryButton.Size = new Size(210, 56);
            inventoryButton.TabIndex = 2;
            inventoryButton.Text = "Inventory";
            inventoryButton.UseVisualStyleBackColor = true;
            inventoryButton.Click += inventoryButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settingsButton.ForeColor = Color.Black;
            settingsButton.Location = new Point(632, 0);
            settingsButton.Margin = new Padding(0);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(210, 54);
            settingsButton.TabIndex = 5;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // header
            // 
            header.BackColor = Color.White;
            header.Controls.Add(homepagetag);
            header.Controls.Add(profilepicture);
            header.Controls.Add(profilename);
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1710, 65);
            header.TabIndex = 1;
            // 
            // homepagetag
            // 
            homepagetag.AutoSize = true;
            homepagetag.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homepagetag.ForeColor = Color.Black;
            homepagetag.Location = new Point(915, 9);
            homepagetag.Name = "homepagetag";
            homepagetag.Size = new Size(230, 54);
            homepagetag.TabIndex = 2;
            homepagetag.Text = "HomePage";
            homepagetag.TextAlign = ContentAlignment.TopCenter;
            // 
            // profilepicture
            // 
            profilepicture.Location = new Point(27, 3);
            profilepicture.Name = "profilepicture";
            profilepicture.Size = new Size(60, 60);
            profilepicture.SizeMode = PictureBoxSizeMode.StretchImage;
            profilepicture.TabIndex = 1;
            profilepicture.TabStop = false;
            // 
            // profilename
            // 
            profilename.AutoSize = true;
            profilename.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profilename.ForeColor = Color.Black;
            profilename.Location = new Point(90, 6);
            profilename.Name = "profilename";
            profilename.Size = new Size(191, 50);
            profilename.TabIndex = 0;
            profilename.Text = "username";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1922, 993);
            Controls.Add(dropdown);
            Controls.Add(header);
            Controls.Add(mainframe);
            ForeColor = Color.CornflowerBlue;
            Name = "Home";
            Text = "CorFish/Home";
            mainframe.ResumeLayout(false);
            dropdown.ResumeLayout(false);
            panel1.ResumeLayout(false);
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilepicture).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer2;
        private Panel panel3;
        private Panel mainframe;
        private FlowLayoutPanel dropdown;
        private Panel panel1;
        private Button dropdownButton;
        private Button posButton;
        private Button inventoryButton;
        private Button settingsButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel header;
        private Label profilename;
        private PictureBox profilepicture;
        private Label homepagetag;
    }
}