namespace FirstTrypos
{
    partial class inventoryupdate
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            iuproductname = new TextBox();
            iuproductcode = new TextBox();
            iuproductquantity = new TextBox();
            iuproductprice = new TextBox();
            iuproductcategory = new ComboBox();
            iuproductpic = new PictureBox();
            buttonofimage = new Button();
            close = new Button();
            panel1 = new Panel();
            updatebutton = new Button();
            deletebutton = new Button();
            ((System.ComponentModel.ISupportInitialize)iuproductpic).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 39);
            label1.Name = "label1";
            label1.Size = new Size(370, 38);
            label1.TabIndex = 0;
            label1.Text = "PRODUCT INFORMATION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 324);
            label2.Name = "label2";
            label2.Size = new Size(170, 31);
            label2.TabIndex = 1;
            label2.Text = "Product Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 417);
            label3.Name = "label3";
            label3.Size = new Size(74, 31);
            label3.TabIndex = 2;
            label3.Text = "Code:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 475);
            label4.Name = "label4";
            label4.Size = new Size(116, 31);
            label4.TabIndex = 3;
            label4.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 529);
            label5.Name = "label5";
            label5.Size = new Size(109, 31);
            label5.TabIndex = 4;
            label5.Text = "Quantity:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 581);
            label6.Name = "label6";
            label6.Size = new Size(120, 31);
            label6.TabIndex = 5;
            label6.Text = "Unit Price:";
            // 
            // iuproductname
            // 
            iuproductname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iuproductname.Location = new Point(31, 358);
            iuproductname.Name = "iuproductname";
            iuproductname.Size = new Size(371, 34);
            iuproductname.TabIndex = 7;
            // 
            // iuproductcode
            // 
            iuproductcode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iuproductcode.Location = new Point(153, 414);
            iuproductcode.Name = "iuproductcode";
            iuproductcode.Size = new Size(249, 34);
            iuproductcode.TabIndex = 8;
            // 
            // iuproductquantity
            // 
            iuproductquantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iuproductquantity.Location = new Point(153, 526);
            iuproductquantity.Name = "iuproductquantity";
            iuproductquantity.Size = new Size(249, 34);
            iuproductquantity.TabIndex = 10;
            // 
            // iuproductprice
            // 
            iuproductprice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iuproductprice.Location = new Point(153, 578);
            iuproductprice.Name = "iuproductprice";
            iuproductprice.Size = new Size(249, 34);
            iuproductprice.TabIndex = 11;
            // 
            // iuproductcategory
            // 
            iuproductcategory.DropDownStyle = ComboBoxStyle.DropDownList;
            iuproductcategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iuproductcategory.FormattingEnabled = true;
            iuproductcategory.Items.AddRange(new object[] { "Accessories", "Clothing", "Electronics", "Food and Beverage", "Sports and Outdoors", "Toys and Games" });
            iuproductcategory.Location = new Point(153, 470);
            iuproductcategory.Name = "iuproductcategory";
            iuproductcategory.Size = new Size(249, 36);
            iuproductcategory.TabIndex = 12;
            // 
            // iuproductpic
            // 
            iuproductpic.Location = new Point(91, 80);
            iuproductpic.Name = "iuproductpic";
            iuproductpic.Size = new Size(256, 190);
            iuproductpic.SizeMode = PictureBoxSizeMode.StretchImage;
            iuproductpic.TabIndex = 13;
            iuproductpic.TabStop = false;
            // 
            // buttonofimage
            // 
            buttonofimage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonofimage.Location = new Point(170, 276);
            buttonofimage.Name = "buttonofimage";
            buttonofimage.Size = new Size(94, 29);
            buttonofimage.TabIndex = 14;
            buttonofimage.Text = "Image";
            buttonofimage.UseVisualStyleBackColor = true;
            buttonofimage.Click += buttonofimage_Click;
            // 
            // close
            // 
            close.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.Location = new Point(404, 0);
            close.Name = "close";
            close.Size = new Size(33, 29);
            close.TabIndex = 15;
            close.Text = "X";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(updatebutton);
            panel1.Controls.Add(deletebutton);
            panel1.Controls.Add(iuproductcategory);
            panel1.Controls.Add(buttonofimage);
            panel1.Controls.Add(iuproductprice);
            panel1.Controls.Add(close);
            panel1.Controls.Add(iuproductquantity);
            panel1.Controls.Add(iuproductpic);
            panel1.Controls.Add(iuproductcode);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(iuproductname);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(7, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 712);
            panel1.TabIndex = 16;
            // 
            // updatebutton
            // 
            updatebutton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updatebutton.ForeColor = Color.Black;
            updatebutton.Location = new Point(114, 639);
            updatebutton.Name = "updatebutton";
            updatebutton.Size = new Size(194, 38);
            updatebutton.TabIndex = 17;
            updatebutton.Text = "SAVE CHANGES";
            updatebutton.UseVisualStyleBackColor = true;
            updatebutton.Click += updatebutton_Click;
            // 
            // deletebutton
            // 
            deletebutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deletebutton.ForeColor = Color.Red;
            deletebutton.Location = new Point(0, 0);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(42, 29);
            deletebutton.TabIndex = 16;
            deletebutton.Text = "🗑";
            deletebutton.UseVisualStyleBackColor = true;
            deletebutton.Click += deletebutton_Click;
            // 
            // inventoryupdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(452, 728);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "inventoryupdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "inventoryupdate";
            ((System.ComponentModel.ISupportInitialize)iuproductpic).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox iuproductname;
        private TextBox iuproductcode;
        private TextBox iuproductquantity;
        private TextBox iuproductprice;
        private ComboBox iuproductcategory;
        private PictureBox iuproductpic;
        private Button buttonofimage;
        private Button close;
        private Panel panel1;
        private Button updatebutton;
        private Button deletebutton;
    }
}