namespace FirstTrypos
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            gotosignupButton = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            showpasswordLogin = new CheckBox();
            label4 = new Label();
            passwordLogin = new TextBox();
            label3 = new Label();
            usernameLogin = new TextBox();
            loginButton = new Button();
            border2 = new Panel();
            border1 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 41);
            label1.Name = "label1";
            label1.Size = new Size(225, 31);
            label1.TabIndex = 0;
            label1.Text = "ENTERPRISE NAME:";
            // 
            // gotosignupButton
            // 
            gotosignupButton.Cursor = Cursors.Hand;
            gotosignupButton.FlatStyle = FlatStyle.Flat;
            gotosignupButton.Location = new Point(218, 392);
            gotosignupButton.Name = "gotosignupButton";
            gotosignupButton.Size = new Size(81, 29);
            gotosignupButton.TabIndex = 1;
            gotosignupButton.Text = "Sign up";
            gotosignupButton.UseVisualStyleBackColor = true;
            gotosignupButton.Click += signupClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1239, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(686, 992);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(66, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(565, 866);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.ErrorImage = PointOfSale.Properties.Resources.logomy;
            pictureBox1.Image = PointOfSale.Properties.Resources.logomy;
            pictureBox1.Location = new Point(230, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(showpasswordLogin);
            panel3.Controls.Add(gotosignupButton);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(passwordLogin);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(usernameLogin);
            panel3.Controls.Add(loginButton);
            panel3.Controls.Add(border2);
            panel3.Controls.Add(border1);
            panel3.Location = new Point(70, 239);
            panel3.Name = "panel3";
            panel3.Size = new Size(430, 433);
            panel3.TabIndex = 0;
            // 
            // showpasswordLogin
            // 
            showpasswordLogin.AutoSize = true;
            showpasswordLogin.CheckAlign = ContentAlignment.MiddleRight;
            showpasswordLogin.Cursor = Cursors.Hand;
            showpasswordLogin.Location = new Point(361, 184);
            showpasswordLogin.Name = "showpasswordLogin";
            showpasswordLogin.Size = new Size(18, 17);
            showpasswordLogin.TabIndex = 8;
            showpasswordLogin.TextImageRelation = TextImageRelation.ImageAboveText;
            showpasswordLogin.UseVisualStyleBackColor = true;
            showpasswordLogin.CheckedChanged += showpasswordLogin_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 395);
            label4.Name = "label4";
            label4.Size = new Size(203, 20);
            label4.TabIndex = 4;
            label4.Text = "Doesn't have an Account yet?";
            // 
            // passwordLogin
            // 
            passwordLogin.Cursor = Cursors.Hand;
            passwordLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLogin.Location = new Point(41, 173);
            passwordLogin.Name = "passwordLogin";
            passwordLogin.Size = new Size(347, 34);
            passwordLogin.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 136);
            label3.Name = "label3";
            label3.Size = new Size(147, 31);
            label3.TabIndex = 3;
            label3.Text = "PASSWORD:";
            // 
            // usernameLogin
            // 
            usernameLogin.BackColor = SystemColors.Window;
            usernameLogin.Cursor = Cursors.Hand;
            usernameLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLogin.Location = new Point(37, 77);
            usernameLogin.Name = "usernameLogin";
            usernameLogin.Size = new Size(351, 34);
            usernameLogin.TabIndex = 6;
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.Window;
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.Black;
            loginButton.Location = new Point(119, 249);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(197, 46);
            loginButton.TabIndex = 0;
            loginButton.Text = "LOG IN";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginAction;
            // 
            // border2
            // 
            border2.BackColor = SystemColors.ActiveCaption;
            border2.Location = new Point(37, 169);
            border2.Name = "border2";
            border2.Size = new Size(355, 42);
            border2.TabIndex = 10;
            // 
            // border1
            // 
            border1.BackColor = SystemColors.ActiveCaption;
            border1.Location = new Point(33, 73);
            border1.Name = "border1";
            border1.Size = new Size(359, 42);
            border1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(229, 174);
            label2.Name = "label2";
            label2.Size = new Size(121, 41);
            label2.TabIndex = 2;
            label2.Text = "LOG IN";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1922, 993);
            Controls.Add(panel1);
            Name = "Login";
            Text = "CorFish/Login";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button gotosignupButton;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button loginButton;
        private TextBox passwordLogin;
        private TextBox usernameLogin;
        private CheckBox showpasswordLogin;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel border1;
        private Panel border2;
    }
}