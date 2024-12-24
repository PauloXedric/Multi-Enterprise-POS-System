namespace FirstTrypos
{
    partial class Settings
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
            logout = new Button();
            settingpanel = new Panel();
            changepassword = new Button();
            updateinformation = new Button();
            mainpanel = new Panel();
            label6 = new Label();
            showinfo = new Button();
            panel1 = new Panel();
            settingpanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // logout
            // 
            logout.FlatStyle = FlatStyle.Flat;
            logout.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout.Location = new Point(291, 21);
            logout.Name = "logout";
            logout.Size = new Size(159, 39);
            logout.TabIndex = 2;
            logout.Text = "LOG OUT";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // settingpanel
            // 
            settingpanel.Controls.Add(changepassword);
            settingpanel.Controls.Add(updateinformation);
            settingpanel.Controls.Add(mainpanel);
            settingpanel.Controls.Add(label6);
            settingpanel.Controls.Add(showinfo);
            settingpanel.Location = new Point(305, 28);
            settingpanel.Name = "settingpanel";
            settingpanel.Size = new Size(1389, 785);
            settingpanel.TabIndex = 3;
            // 
            // changepassword
            // 
            changepassword.FlatStyle = FlatStyle.Flat;
            changepassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changepassword.Location = new Point(1109, 56);
            changepassword.Name = "changepassword";
            changepassword.Size = new Size(255, 42);
            changepassword.TabIndex = 5;
            changepassword.Text = "CHANGE PASSWORD";
            changepassword.UseVisualStyleBackColor = true;
            changepassword.Click += changepassword_Click;
            // 
            // updateinformation
            // 
            updateinformation.FlatStyle = FlatStyle.Flat;
            updateinformation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateinformation.Location = new Point(1109, 12);
            updateinformation.Name = "updateinformation";
            updateinformation.Size = new Size(255, 38);
            updateinformation.TabIndex = 4;
            updateinformation.Text = "UPDATE INFORMATION";
            updateinformation.UseVisualStyleBackColor = true;
            updateinformation.Click += updateinformation_Click;
            // 
            // mainpanel
            // 
            mainpanel.Location = new Point(24, 104);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1340, 663);
            mainpanel.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 19);
            label6.Name = "label6";
            label6.Size = new Size(381, 46);
            label6.TabIndex = 2;
            label6.Text = "USER INFORMATION:";
            // 
            // showinfo
            // 
            showinfo.FlatStyle = FlatStyle.Flat;
            showinfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showinfo.Location = new Point(1274, 56);
            showinfo.Name = "showinfo";
            showinfo.Size = new Size(90, 42);
            showinfo.TabIndex = 6;
            showinfo.Text = "↩";
            showinfo.UseVisualStyleBackColor = true;
            showinfo.Click += showinfo_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(logout);
            panel1.Location = new Point(631, 823);
            panel1.Name = "panel1";
            panel1.Size = new Size(738, 86);
            panel1.TabIndex = 4;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1904, 921);
            Controls.Add(settingpanel);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Name = "Settings";
            Text = "Settings";
            Load += Settings_Load;
            settingpanel.ResumeLayout(false);
            settingpanel.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button logout;
        private Panel settingpanel;
        private Label label6;
        private Panel mainpanel;
        private Panel panel1;
        private Button updateinformation;
        private Button changepassword;
        private Button showinfo;
    }
}