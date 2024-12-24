namespace FirstTrypos
{
    partial class Signup
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
            panel1 = new Panel();
            showpassup = new CheckBox();
            cpassword = new TextBox();
            password = new TextBox();
            firstName = new TextBox();
            lastName = new TextBox();
            address = new TextBox();
            enterpriseName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            signupAction = new Button();
            gotologinButton = new Button();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            border1 = new Panel();
            border2 = new Panel();
            border3 = new Panel();
            border4 = new Panel();
            border5 = new Panel();
            border6 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(showpassup);
            panel1.Controls.Add(cpassword);
            panel1.Controls.Add(password);
            panel1.Controls.Add(firstName);
            panel1.Controls.Add(lastName);
            panel1.Controls.Add(address);
            panel1.Controls.Add(enterpriseName);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(signupAction);
            panel1.Controls.Add(gotologinButton);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(border1);
            panel1.Controls.Add(border2);
            panel1.Controls.Add(border3);
            panel1.Controls.Add(border4);
            panel1.Controls.Add(border5);
            panel1.Controls.Add(border6);
            panel1.Cursor = Cursors.SizeAll;
            panel1.Location = new Point(68, 205);
            panel1.Name = "panel1";
            panel1.Size = new Size(430, 619);
            panel1.TabIndex = 0;
            // 
            // showpassup
            // 
            showpassup.AutoSize = true;
            showpassup.Location = new Point(352, 389);
            showpassup.Name = "showpassup";
            showpassup.Size = new Size(18, 17);
            showpassup.TabIndex = 15;
            showpassup.UseVisualStyleBackColor = true;
            showpassup.CheckedChanged += showpassup_CheckedChanged;
            // 
            // cpassword
            // 
            cpassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cpassword.Location = new Point(33, 462);
            cpassword.Name = "cpassword";
            cpassword.Size = new Size(347, 34);
            cpassword.TabIndex = 14;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(33, 379);
            password.Name = "password";
            password.Size = new Size(347, 34);
            password.TabIndex = 13;
            // 
            // firstName
            // 
            firstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstName.Location = new Point(33, 217);
            firstName.Name = "firstName";
            firstName.Size = new Size(347, 34);
            firstName.TabIndex = 12;
            // 
            // lastName
            // 
            lastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastName.Location = new Point(33, 297);
            lastName.Name = "lastName";
            lastName.Size = new Size(347, 34);
            lastName.TabIndex = 11;
            // 
            // address
            // 
            address.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            address.Location = new Point(33, 134);
            address.Name = "address";
            address.Size = new Size(347, 34);
            address.TabIndex = 10;
            // 
            // enterpriseName
            // 
            enterpriseName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enterpriseName.Location = new Point(33, 53);
            enterpriseName.Name = "enterpriseName";
            enterpriseName.Size = new Size(347, 34);
            enterpriseName.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(33, 427);
            label8.Name = "label8";
            label8.Size = new Size(258, 31);
            label8.TabIndex = 8;
            label8.Text = "CONFIRM PASSWORD:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(33, 344);
            label7.Name = "label7";
            label7.Size = new Size(147, 31);
            label7.TabIndex = 7;
            label7.Text = "PASSWORD:";
            // 
            // signupAction
            // 
            signupAction.Cursor = Cursors.Hand;
            signupAction.FlatStyle = FlatStyle.Flat;
            signupAction.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupAction.Location = new Point(115, 513);
            signupAction.Name = "signupAction";
            signupAction.Size = new Size(197, 46);
            signupAction.TabIndex = 6;
            signupAction.Text = "SIGN UP";
            signupAction.TextImageRelation = TextImageRelation.TextAboveImage;
            signupAction.UseVisualStyleBackColor = true;
            signupAction.Click += signupAction_Click;
            // 
            // gotologinButton
            // 
            gotologinButton.Cursor = Cursors.Hand;
            gotologinButton.FlatStyle = FlatStyle.Flat;
            gotologinButton.Location = new Point(183, 586);
            gotologinButton.Name = "gotologinButton";
            gotologinButton.Size = new Size(94, 29);
            gotologinButton.TabIndex = 5;
            gotologinButton.Text = "LOG IN";
            gotologinButton.UseVisualStyleBackColor = true;
            gotologinButton.Click += loginClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 590);
            label6.Name = "label6";
            label6.Size = new Size(180, 20);
            label6.TabIndex = 4;
            label6.Text = "Already have an Account?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 17);
            label4.Name = "label4";
            label4.Size = new Size(225, 31);
            label4.TabIndex = 2;
            label4.Text = "ENTERPRISE NAME:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 98);
            label5.Name = "label5";
            label5.Size = new Size(123, 31);
            label5.TabIndex = 3;
            label5.Text = "ADDRESS:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 181);
            label2.Name = "label2";
            label2.Size = new Size(154, 31);
            label2.TabIndex = 1;
            label2.Text = "FIRST NAME:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 261);
            label3.Name = "label3";
            label3.Size = new Size(149, 31);
            label3.TabIndex = 1;
            label3.Text = "LAST NAME:";
            // 
            // border1
            // 
            border1.BackColor = SystemColors.ActiveCaption;
            border1.Location = new Point(29, 49);
            border1.Name = "border1";
            border1.Size = new Size(355, 42);
            border1.TabIndex = 17;
            // 
            // border2
            // 
            border2.BackColor = SystemColors.ActiveCaption;
            border2.Location = new Point(29, 130);
            border2.Name = "border2";
            border2.Size = new Size(355, 42);
            border2.TabIndex = 16;
            // 
            // border3
            // 
            border3.BackColor = SystemColors.ActiveCaption;
            border3.Location = new Point(29, 213);
            border3.Name = "border3";
            border3.Size = new Size(355, 42);
            border3.TabIndex = 17;
            // 
            // border4
            // 
            border4.BackColor = SystemColors.ActiveCaption;
            border4.Location = new Point(29, 293);
            border4.Name = "border4";
            border4.Size = new Size(355, 42);
            border4.TabIndex = 1;
            // 
            // border5
            // 
            border5.BackColor = SystemColors.ActiveCaption;
            border5.Location = new Point(29, 375);
            border5.Name = "border5";
            border5.Size = new Size(355, 42);
            border5.TabIndex = 2;
            // 
            // border6
            // 
            border6.BackColor = SystemColors.ActiveCaption;
            border6.Location = new Point(29, 458);
            border6.Name = "border6";
            border6.Size = new Size(355, 42);
            border6.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = PointOfSale.Properties.Resources.logomy;
            pictureBox1.Location = new Point(220, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(212, 150);
            label1.Name = "label1";
            label1.Size = new Size(141, 41);
            label1.TabIndex = 0;
            label1.Text = "SIGN UP";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(686, 992);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel1);
            panel3.Location = new Point(60, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(565, 866);
            panel3.TabIndex = 0;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1922, 993);
            Controls.Add(panel2);
            Name = "Signup";
            Text = "CorFish/SignUp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button gotologinButton;
        private Label label6;
        private Button signupAction;
        private Label label8;
        private Label label7;
        private TextBox cpassword;
        private TextBox password;
        private TextBox firstName;
        private TextBox lastName;
        private TextBox address;
        private TextBox enterpriseName;
        private CheckBox showpassup;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel border1;
        private Panel border2;
        private Panel border3;
        private Panel border5;
        private Panel border4;
        private Panel border6;
    }
}