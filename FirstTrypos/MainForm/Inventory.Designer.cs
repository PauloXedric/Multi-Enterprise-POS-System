namespace FirstTrypos
{
    partial class Inventory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            editproductbutton = new Button();
            label1 = new Label();
            label9 = new Label();
            chooseimage = new Button();
            label8 = new Label();
            border2 = new Panel();
            productname = new TextBox();
            label5 = new Label();
            label3 = new Label();
            border3 = new Panel();
            productcode = new TextBox();
            border4 = new Panel();
            productcategory = new ComboBox();
            label4 = new Label();
            border5 = new Panel();
            productquantity = new TextBox();
            border6 = new Panel();
            productprice = new TextBox();
            label6 = new Label();
            border1 = new Panel();
            productpic = new PictureBox();
            addproductbutton = new Button();
            addstocksbutton = new Button();
            inventoryTable = new DataGridView();
            productimage = new DataGridViewImageColumn();
            pname = new DataGridViewTextBoxColumn();
            pcategory = new DataGridViewTextBoxColumn();
            pquantity = new DataGridViewTextBoxColumn();
            pprice = new DataGridViewTextBoxColumn();
            Activity = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label7 = new Label();
            searchcategory = new ComboBox();
            searchproduct = new TextBox();
            tablepanel = new Panel();
            border8 = new Panel();
            border7 = new Panel();
            panel1.SuspendLayout();
            border2.SuspendLayout();
            border3.SuspendLayout();
            border4.SuspendLayout();
            border5.SuspendLayout();
            border6.SuspendLayout();
            border1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productpic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventoryTable).BeginInit();
            tablepanel.SuspendLayout();
            border8.SuspendLayout();
            border7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(editproductbutton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(chooseimage);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(border2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(border3);
            panel1.Controls.Add(border4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(border5);
            panel1.Controls.Add(border6);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(border1);
            panel1.Controls.Add(addproductbutton);
            panel1.Controls.Add(addstocksbutton);
            panel1.Location = new Point(1413, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 808);
            panel1.TabIndex = 0;
            // 
            // editproductbutton
            // 
            editproductbutton.Cursor = Cursors.Hand;
            editproductbutton.FlatStyle = FlatStyle.Flat;
            editproductbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editproductbutton.ForeColor = Color.Black;
            editproductbutton.Location = new Point(372, 6);
            editproductbutton.Name = "editproductbutton";
            editproductbutton.Size = new Size(57, 29);
            editproductbutton.TabIndex = 17;
            editproductbutton.Text = "EDIT";
            editproductbutton.UseVisualStyleBackColor = true;
            editproductbutton.Click += editproductbutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(107, 9);
            label1.Name = "label1";
            label1.Size = new Size(241, 41);
            label1.TabIndex = 0;
            label1.Text = "ADD PRODUCT";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(124, 37);
            label9.Name = "label9";
            label9.Size = new Size(211, 41);
            label9.TabIndex = 8;
            label9.Text = "ADD STOCKS";
            // 
            // chooseimage
            // 
            chooseimage.Cursor = Cursors.Hand;
            chooseimage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chooseimage.ForeColor = Color.Black;
            chooseimage.Location = new Point(193, 285);
            chooseimage.Name = "chooseimage";
            chooseimage.Size = new Size(77, 36);
            chooseimage.TabIndex = 12;
            chooseimage.Text = "Image";
            chooseimage.UseVisualStyleBackColor = true;
            chooseimage.Click += chooseimage_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(41, 432);
            label8.Name = "label8";
            label8.Size = new Size(74, 31);
            label8.TabIndex = 13;
            label8.Text = "Code:";
            // 
            // border2
            // 
            border2.BackColor = SystemColors.ActiveCaption;
            border2.Controls.Add(productname);
            border2.Location = new Point(33, 368);
            border2.Name = "border2";
            border2.Size = new Size(378, 42);
            border2.TabIndex = 15;
            // 
            // productname
            // 
            productname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productname.Location = new Point(4, 4);
            productname.Name = "productname";
            productname.Size = new Size(371, 34);
            productname.TabIndex = 6;
            productname.TextChanged += productname_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(41, 543);
            label5.Name = "label5";
            label5.Size = new Size(109, 31);
            label5.TabIndex = 4;
            label5.Text = "Quantity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(33, 334);
            label3.Name = "label3";
            label3.Size = new Size(170, 31);
            label3.TabIndex = 2;
            label3.Text = "Product Name:";
            // 
            // border3
            // 
            border3.BackColor = SystemColors.ActiveCaption;
            border3.Controls.Add(productcode);
            border3.Location = new Point(154, 425);
            border3.Name = "border3";
            border3.Size = new Size(257, 42);
            border3.TabIndex = 7;
            // 
            // productcode
            // 
            productcode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productcode.Location = new Point(4, 4);
            productcode.Name = "productcode";
            productcode.Size = new Size(249, 34);
            productcode.TabIndex = 14;
            // 
            // border4
            // 
            border4.BackColor = SystemColors.ActiveCaption;
            border4.Controls.Add(productcategory);
            border4.Location = new Point(154, 480);
            border4.Name = "border4";
            border4.Size = new Size(257, 43);
            border4.TabIndex = 8;
            // 
            // productcategory
            // 
            productcategory.DropDownStyle = ComboBoxStyle.DropDownList;
            productcategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productcategory.FormattingEnabled = true;
            productcategory.Items.AddRange(new object[] { "Accessories", "Clothing", "Electronics", "Food and Beverage", "Sports and Outdoors", "Toys and Games" });
            productcategory.Location = new Point(5, 3);
            productcategory.Name = "productcategory";
            productcategory.Size = new Size(249, 36);
            productcategory.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(41, 488);
            label4.Name = "label4";
            label4.Size = new Size(116, 31);
            label4.TabIndex = 3;
            label4.Text = "Category:";
            // 
            // border5
            // 
            border5.BackColor = SystemColors.ActiveCaption;
            border5.Controls.Add(productquantity);
            border5.Location = new Point(154, 536);
            border5.Name = "border5";
            border5.Size = new Size(257, 42);
            border5.TabIndex = 7;
            // 
            // productquantity
            // 
            productquantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productquantity.Location = new Point(4, 4);
            productquantity.Name = "productquantity";
            productquantity.Size = new Size(249, 34);
            productquantity.TabIndex = 7;
            productquantity.KeyPress += inventoryQuantity_KeyPress;
            // 
            // border6
            // 
            border6.BackColor = SystemColors.ActiveCaption;
            border6.Controls.Add(productprice);
            border6.Location = new Point(154, 592);
            border6.Name = "border6";
            border6.Size = new Size(257, 42);
            border6.TabIndex = 9;
            // 
            // productprice
            // 
            productprice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productprice.Location = new Point(4, 4);
            productprice.Name = "productprice";
            productprice.Size = new Size(249, 34);
            productprice.TabIndex = 8;
            productprice.KeyPress += inventoryUprice_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(41, 599);
            label6.Name = "label6";
            label6.Size = new Size(120, 31);
            label6.TabIndex = 5;
            label6.Text = "Unit Price:";
            // 
            // border1
            // 
            border1.BackColor = SystemColors.ActiveCaption;
            border1.Controls.Add(productpic);
            border1.Location = new Point(93, 81);
            border1.Name = "border1";
            border1.Size = new Size(264, 198);
            border1.TabIndex = 0;
            // 
            // productpic
            // 
            productpic.BackColor = SystemColors.Control;
            productpic.Location = new Point(4, 4);
            productpic.Name = "productpic";
            productpic.Size = new Size(256, 190);
            productpic.SizeMode = PictureBoxSizeMode.StretchImage;
            productpic.TabIndex = 11;
            productpic.TabStop = false;
            // 
            // addproductbutton
            // 
            addproductbutton.Cursor = Cursors.Hand;
            addproductbutton.FlatStyle = FlatStyle.Flat;
            addproductbutton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addproductbutton.ForeColor = Color.Black;
            addproductbutton.Location = new Point(107, 700);
            addproductbutton.Name = "addproductbutton";
            addproductbutton.Size = new Size(237, 45);
            addproductbutton.TabIndex = 10;
            addproductbutton.Text = "ADD";
            addproductbutton.UseVisualStyleBackColor = true;
            addproductbutton.Click += addproductbutton_Click;
            // 
            // addstocksbutton
            // 
            addstocksbutton.Cursor = Cursors.Hand;
            addstocksbutton.FlatStyle = FlatStyle.Flat;
            addstocksbutton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addstocksbutton.ForeColor = Color.Black;
            addstocksbutton.Location = new Point(107, 700);
            addstocksbutton.Name = "addstocksbutton";
            addstocksbutton.Size = new Size(237, 45);
            addstocksbutton.TabIndex = 16;
            addstocksbutton.Text = "ADD STOCKS";
            addstocksbutton.UseVisualStyleBackColor = true;
            addstocksbutton.Click += addstocksbutton_Click;
            // 
            // inventoryTable
            // 
            inventoryTable.AllowUserToAddRows = false;
            inventoryTable.AllowUserToDeleteRows = false;
            inventoryTable.AllowUserToResizeColumns = false;
            inventoryTable.AllowUserToResizeRows = false;
            inventoryTable.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            inventoryTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            inventoryTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryTable.Columns.AddRange(new DataGridViewColumn[] { productimage, pname, pcategory, pquantity, pprice, Activity });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            inventoryTable.DefaultCellStyle = dataGridViewCellStyle2;
            inventoryTable.Location = new Point(87, 132);
            inventoryTable.Name = "inventoryTable";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            inventoryTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            inventoryTable.RowHeadersVisible = false;
            inventoryTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            inventoryTable.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            inventoryTable.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inventoryTable.RowTemplate.Height = 150;
            inventoryTable.Size = new Size(1218, 717);
            inventoryTable.TabIndex = 1;
            // 
            // productimage
            // 
            productimage.DataPropertyName = "ProductPic";
            productimage.HeaderText = "IMAGE";
            productimage.ImageLayout = DataGridViewImageCellLayout.Zoom;
            productimage.MinimumWidth = 6;
            productimage.Name = "productimage";
            productimage.Resizable = DataGridViewTriState.True;
            productimage.SortMode = DataGridViewColumnSortMode.Automatic;
            productimage.Width = 250;
            // 
            // pname
            // 
            pname.DataPropertyName = "ProductName";
            pname.HeaderText = "PRODUCT NAME";
            pname.MinimumWidth = 6;
            pname.Name = "pname";
            pname.ReadOnly = true;
            pname.Width = 220;
            // 
            // pcategory
            // 
            pcategory.DataPropertyName = "ProductCategory";
            pcategory.HeaderText = "CATEGORY";
            pcategory.MinimumWidth = 6;
            pcategory.Name = "pcategory";
            pcategory.ReadOnly = true;
            pcategory.Width = 200;
            // 
            // pquantity
            // 
            pquantity.DataPropertyName = "ProductQuantity";
            pquantity.HeaderText = "STOCKS";
            pquantity.MinimumWidth = 6;
            pquantity.Name = "pquantity";
            pquantity.ReadOnly = true;
            pquantity.Width = 184;
            // 
            // pprice
            // 
            pprice.DataPropertyName = "ProductPrice";
            pprice.HeaderText = "UNIT PRICE";
            pprice.MinimumWidth = 6;
            pprice.Name = "pprice";
            pprice.ReadOnly = true;
            pprice.Width = 184;
            // 
            // Activity
            // 
            Activity.HeaderText = "ACTIVITY";
            Activity.MinimumWidth = 6;
            Activity.Name = "Activity";
            Activity.ReadOnly = true;
            Activity.Width = 155;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(30, 32);
            label2.Name = "label2";
            label2.Size = new Size(182, 31);
            label2.TabIndex = 3;
            label2.Text = "Search Product:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(894, 32);
            label7.Name = "label7";
            label7.Size = new Size(109, 31);
            label7.TabIndex = 4;
            label7.Text = "Filter By:";
            // 
            // searchcategory
            // 
            searchcategory.DropDownStyle = ComboBoxStyle.DropDownList;
            searchcategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchcategory.FormattingEnabled = true;
            searchcategory.Items.AddRange(new object[] { "Accessories", "Clothing", "Electronics", "Food and Beverage", "Sports and Outdoors", "Toys and Games" });
            searchcategory.Location = new Point(4, 4);
            searchcategory.Name = "searchcategory";
            searchcategory.Size = new Size(240, 36);
            searchcategory.TabIndex = 5;
            // 
            // searchproduct
            // 
            searchproduct.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchproduct.Location = new Point(4, 4);
            searchproduct.Name = "searchproduct";
            searchproduct.Size = new Size(240, 34);
            searchproduct.TabIndex = 6;
            // 
            // tablepanel
            // 
            tablepanel.Controls.Add(border8);
            tablepanel.Controls.Add(border7);
            tablepanel.Controls.Add(label7);
            tablepanel.Controls.Add(label2);
            tablepanel.Location = new Point(57, 60);
            tablepanel.Name = "tablepanel";
            tablepanel.Size = new Size(1280, 808);
            tablepanel.TabIndex = 7;
            // 
            // border8
            // 
            border8.BackColor = SystemColors.ActiveCaption;
            border8.Controls.Add(searchproduct);
            border8.Location = new Point(208, 21);
            border8.Name = "border8";
            border8.Size = new Size(248, 42);
            border8.TabIndex = 8;
            // 
            // border7
            // 
            border7.BackColor = SystemColors.ActiveCaption;
            border7.Controls.Add(searchcategory);
            border7.Location = new Point(1000, 21);
            border7.Name = "border7";
            border7.Size = new Size(248, 44);
            border7.TabIndex = 9;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1904, 921);
            Controls.Add(inventoryTable);
            Controls.Add(panel1);
            Controls.Add(tablepanel);
            Name = "Inventory";
            Text = "Inventory";
            Load += Inventory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            border2.ResumeLayout(false);
            border2.PerformLayout();
            border3.ResumeLayout(false);
            border3.PerformLayout();
            border4.ResumeLayout(false);
            border5.ResumeLayout(false);
            border5.PerformLayout();
            border6.ResumeLayout(false);
            border6.PerformLayout();
            border1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productpic).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventoryTable).EndInit();
            tablepanel.ResumeLayout(false);
            tablepanel.PerformLayout();
            border8.ResumeLayout(false);
            border8.PerformLayout();
            border7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox productcategory;
        private TextBox productprice;
        private TextBox productquantity;
        private RichTextBox richTextBox1;
        private Label label7;
        private Button addproductbutton;
        private PictureBox productpic;
        private Button chooseimage;
        private DataGridView inventoryTable;
        private Label label8;
        private TextBox productcode;
        private ComboBox searchcategory;
        private TextBox searchproduct;
        private Panel border2;
        private TextBox productname;
        private Panel border3;
        private Panel border5;
        private Panel border4;
        private Panel border6;
        private Panel border1;
        private Panel tablepanel;
        private Panel border8;
        private Panel border7;
        private Label label9;
        private Button editproductbutton;
        private Button addstocksbutton;
        private DataGridViewImageColumn productimage;
        private DataGridViewTextBoxColumn pname;
        private DataGridViewTextBoxColumn pcategory;
        private DataGridViewTextBoxColumn pquantity;
        private DataGridViewTextBoxColumn pprice;
        private DataGridViewTextBoxColumn Activity;
    }
}