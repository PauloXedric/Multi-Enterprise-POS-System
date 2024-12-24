namespace FirstTrypos
{
    partial class FirstPage
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
            gotologin = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // gotologin
            // 
            gotologin.BackColor = Color.White;
            gotologin.Cursor = Cursors.Hand;
            gotologin.FlatStyle = FlatStyle.Flat;
            gotologin.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            gotologin.ForeColor = Color.Black;
            gotologin.Location = new Point(858, 755);
            gotologin.Name = "gotologin";
            gotologin.Size = new Size(210, 77);
            gotologin.TabIndex = 0;
            gotologin.Text = "WELCOME";
            gotologin.UseVisualStyleBackColor = false;
            gotologin.Click += welcomeClick;
            // 
            // FirstPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1922, 993);
            Controls.Add(gotologin);
            Name = "FirstPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CorFish";
            ResumeLayout(false);
        }

        #endregion

        private Button gotologin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
