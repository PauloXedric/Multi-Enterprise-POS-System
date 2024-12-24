namespace PointOfSale.Controls
{
    partial class SettingsChangePassword
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            savechanges = new Button();
            update = new Button();
            border4 = new Panel();
            confirmnewpassword = new TextBox();
            border3 = new Panel();
            showpass = new CheckBox();
            newpassword = new TextBox();
            username = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            border1 = new Panel();
            border2 = new Panel();
            password = new TextBox();
            panel1.SuspendLayout();
            border4.SuspendLayout();
            border3.SuspendLayout();
            border2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(144, 16);
            label1.Name = "label1";
            label1.Size = new Size(295, 38);
            label1.TabIndex = 0;
            label1.Text = "CHANGE PASSWORD";
            // 
            // panel1
            // 
            panel1.Controls.Add(savechanges);
            panel1.Controls.Add(update);
            panel1.Controls.Add(border4);
            panel1.Controls.Add(border3);
            panel1.Controls.Add(username);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(border1);
            panel1.Controls.Add(border2);
            panel1.Location = new Point(378, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 595);
            panel1.TabIndex = 1;
            // 
            // savechanges
            // 
            savechanges.FlatStyle = FlatStyle.Flat;
            savechanges.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            savechanges.Location = new Point(202, 534);
            savechanges.Name = "savechanges";
            savechanges.Size = new Size(181, 41);
            savechanges.TabIndex = 9;
            savechanges.Text = "SAVE CHANGES";
            savechanges.UseVisualStyleBackColor = true;
            savechanges.Click += savechanges_Click;
            // 
            // update
            // 
            update.FlatStyle = FlatStyle.Flat;
            update.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update.Location = new Point(234, 298);
            update.Name = "update";
            update.Size = new Size(126, 41);
            update.TabIndex = 8;
            update.Text = "UPDATE";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // border4
            // 
            border4.BackColor = SystemColors.ActiveCaption;
            border4.Controls.Add(confirmnewpassword);
            border4.Location = new Point(57, 466);
            border4.Name = "border4";
            border4.Size = new Size(478, 46);
            border4.TabIndex = 7;
            // 
            // confirmnewpassword
            // 
            confirmnewpassword.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmnewpassword.ForeColor = Color.Black;
            confirmnewpassword.Location = new Point(4, 4);
            confirmnewpassword.Name = "confirmnewpassword";
            confirmnewpassword.Size = new Size(469, 38);
            confirmnewpassword.TabIndex = 6;
            // 
            // border3
            // 
            border3.BackColor = SystemColors.ActiveCaption;
            border3.Controls.Add(showpass);
            border3.Controls.Add(newpassword);
            border3.Location = new Point(57, 372);
            border3.Name = "border3";
            border3.Size = new Size(478, 46);
            border3.TabIndex = 7;
            // 
            // showpass
            // 
            showpass.AutoSize = true;
            showpass.BackColor = Color.White;
            showpass.Location = new Point(448, 15);
            showpass.Name = "showpass";
            showpass.Size = new Size(18, 17);
            showpass.TabIndex = 7;
            showpass.UseVisualStyleBackColor = false;
            showpass.CheckedChanged += showpass_CheckedChanged;
            // 
            // newpassword
            // 
            newpassword.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newpassword.ForeColor = Color.Black;
            newpassword.Location = new Point(4, 4);
            newpassword.Name = "newpassword";
            newpassword.Size = new Size(469, 38);
            newpassword.TabIndex = 6;
            // 
            // username
            // 
            username.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username.ForeColor = Color.Black;
            username.Location = new Point(57, 139);
            username.Name = "username";
            username.ReadOnly = true;
            username.Size = new Size(469, 38);
            username.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(57, 436);
            label5.Name = "label5";
            label5.Size = new Size(309, 31);
            label5.TabIndex = 3;
            label5.Text = "CONFIRM NEW PASSWORD:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(55, 342);
            label4.Name = "label4";
            label4.Size = new Size(200, 31);
            label4.TabIndex = 2;
            label4.Text = "NEW PASSWORD:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(52, 204);
            label3.Name = "label3";
            label3.Size = new Size(142, 31);
            label3.TabIndex = 1;
            label3.Text = "PASSWORD:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(55, 103);
            label2.Name = "label2";
            label2.Size = new Size(141, 31);
            label2.TabIndex = 0;
            label2.Text = "USERNAME:";
            // 
            // border1
            // 
            border1.BackColor = SystemColors.ActiveCaption;
            border1.Location = new Point(53, 135);
            border1.Name = "border1";
            border1.Size = new Size(478, 46);
            border1.TabIndex = 5;
            // 
            // border2
            // 
            border2.BackColor = SystemColors.ActiveCaption;
            border2.Controls.Add(password);
            border2.Location = new Point(53, 238);
            border2.Name = "border2";
            border2.Size = new Size(478, 46);
            border2.TabIndex = 6;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password.ForeColor = Color.Black;
            password.Location = new Point(4, 4);
            password.Name = "password";
            password.Size = new Size(469, 38);
            password.TabIndex = 6;
            // 
            // SettingsChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(panel1);
            Name = "SettingsChangePassword";
            Size = new Size(1340, 663);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            border4.ResumeLayout(false);
            border4.PerformLayout();
            border3.ResumeLayout(false);
            border3.PerformLayout();
            border2.ResumeLayout(false);
            border2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox username;
        private Panel border1;
        private Panel border2;
        private TextBox password;
        private Panel border4;
        private TextBox confirmnewpassword;
        private Panel border3;
        private TextBox newpassword;
        private Button update;
        private CheckBox showpass;
        private Button savechanges;
    }
}
