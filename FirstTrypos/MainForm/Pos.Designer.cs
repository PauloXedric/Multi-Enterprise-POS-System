namespace FirstTrypos
{
    partial class Pos
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tablepanel = new Panel();
            searchitem = new TextBox();
            label1 = new Label();
            posTable = new DataGridView();
            productimage = new DataGridViewImageColumn();
            pname = new DataGridViewTextBoxColumn();
            pprice = new DataGridViewTextBoxColumn();
            border1 = new Panel();
            panel4 = new Panel();
            GenerateReceiptG = new Button();
            customeraddressg = new TextBox();
            customernameg = new TextBox();
            label10 = new Label();
            label9 = new Label();
            gcashinput = new TextBox();
            label8 = new Label();
            panel1 = new Panel();
            PayButton = new Button();
            total = new Label();
            label3 = new Label();
            label2 = new Label();
            ordertable = new DataGridView();
            ordername = new DataGridViewTextBoxColumn();
            orderquantity = new DataGridViewTextBoxColumn();
            orderprice = new DataGridViewTextBoxColumn();
            ordertotal = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            label11 = new Label();
            qrcode = new PictureBox();
            panel31 = new Panel();
            GenerateReceipt = new Button();
            customeraddress = new TextBox();
            customername = new TextBox();
            label7 = new Label();
            label6 = new Label();
            cashinput = new TextBox();
            label5 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            GCash = new Button();
            Cash = new Button();
            tablepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)posTable).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordertable).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)qrcode).BeginInit();
            panel31.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tablepanel
            // 
            tablepanel.BackColor = SystemColors.ControlLight;
            tablepanel.Controls.Add(searchitem);
            tablepanel.Controls.Add(label1);
            tablepanel.Controls.Add(posTable);
            tablepanel.Controls.Add(border1);
            tablepanel.Location = new Point(12, 14);
            tablepanel.Name = "tablepanel";
            tablepanel.Size = new Size(741, 897);
            tablepanel.TabIndex = 1;
            // 
            // searchitem
            // 
            searchitem.BackColor = Color.White;
            searchitem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchitem.Location = new Point(144, 31);
            searchitem.Name = "searchitem";
            searchitem.Size = new Size(240, 34);
            searchitem.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(30, 34);
            label1.Name = "label1";
            label1.Size = new Size(108, 31);
            label1.TabIndex = 2;
            label1.Text = "SEARCH:";
            // 
            // posTable
            // 
            posTable.AllowUserToAddRows = false;
            posTable.AllowUserToDeleteRows = false;
            posTable.AllowUserToResizeColumns = false;
            posTable.AllowUserToResizeRows = false;
            posTable.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            posTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            posTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            posTable.Columns.AddRange(new DataGridViewColumn[] { productimage, pname, pprice });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            posTable.DefaultCellStyle = dataGridViewCellStyle2;
            posTable.Location = new Point(30, 87);
            posTable.Name = "posTable";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            posTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            posTable.RowHeadersVisible = false;
            posTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            posTable.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            posTable.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            posTable.RowTemplate.Height = 150;
            posTable.Size = new Size(679, 780);
            posTable.TabIndex = 1;
            posTable.CellClick += posTable_CellClick;
            // 
            // productimage
            // 
            productimage.DataPropertyName = "ProductPic";
            productimage.HeaderText = "IMAGE";
            productimage.ImageLayout = DataGridViewImageCellLayout.Zoom;
            productimage.MinimumWidth = 6;
            productimage.Name = "productimage";
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
            // pprice
            // 
            pprice.DataPropertyName = "ProductPrice";
            pprice.HeaderText = "PRICE";
            pprice.MinimumWidth = 6;
            pprice.Name = "pprice";
            pprice.ReadOnly = true;
            pprice.Width = 184;
            // 
            // border1
            // 
            border1.BackColor = SystemColors.ActiveCaption;
            border1.Location = new Point(140, 27);
            border1.Name = "border1";
            border1.Size = new Size(248, 42);
            border1.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Controls.Add(GenerateReceiptG);
            panel4.Controls.Add(customeraddressg);
            panel4.Controls.Add(customernameg);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(gcashinput);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(1460, 566);
            panel4.Name = "panel4";
            panel4.Size = new Size(432, 322);
            panel4.TabIndex = 5;
            // 
            // GenerateReceiptG
            // 
            GenerateReceiptG.FlatStyle = FlatStyle.Flat;
            GenerateReceiptG.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenerateReceiptG.ForeColor = Color.Black;
            GenerateReceiptG.Location = new Point(43, 264);
            GenerateReceiptG.Name = "GenerateReceiptG";
            GenerateReceiptG.Size = new Size(357, 43);
            GenerateReceiptG.TabIndex = 7;
            GenerateReceiptG.Text = "GENERATE RECEIPT";
            GenerateReceiptG.UseVisualStyleBackColor = true;
            GenerateReceiptG.Click += GenerateReceiptG_Click;
            // 
            // customeraddressg
            // 
            customeraddressg.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customeraddressg.ForeColor = Color.Black;
            customeraddressg.Location = new Point(43, 205);
            customeraddressg.Name = "customeraddressg";
            customeraddressg.Size = new Size(357, 34);
            customeraddressg.TabIndex = 7;
            // 
            // customernameg
            // 
            customernameg.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customernameg.ForeColor = Color.Black;
            customernameg.Location = new Point(43, 134);
            customernameg.Name = "customernameg";
            customernameg.Size = new Size(357, 34);
            customernameg.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(43, 171);
            label10.Name = "label10";
            label10.Size = new Size(210, 31);
            label10.TabIndex = 7;
            label10.Text = "Customer Address:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(39, 100);
            label9.Name = "label9";
            label9.Size = new Size(188, 31);
            label9.TabIndex = 7;
            label9.Text = "Customer Name:";
            // 
            // gcashinput
            // 
            gcashinput.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gcashinput.ForeColor = Color.Black;
            gcashinput.Location = new Point(122, 17);
            gcashinput.Name = "gcashinput";
            gcashinput.Size = new Size(294, 38);
            gcashinput.TabIndex = 7;
            gcashinput.KeyPress += gcashinput_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(3, 17);
            label8.Name = "label8";
            label8.Size = new Size(127, 41);
            label8.TabIndex = 7;
            label8.Text = "GCASH:";
            // 
            // panel1
            // 
            panel1.Controls.Add(PayButton);
            panel1.Controls.Add(total);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ordertable);
            panel1.Location = new Point(772, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(670, 897);
            panel1.TabIndex = 2;
            // 
            // PayButton
            // 
            PayButton.FlatStyle = FlatStyle.Flat;
            PayButton.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PayButton.ForeColor = Color.Black;
            PayButton.Location = new Point(94, 823);
            PayButton.Name = "PayButton";
            PayButton.Size = new Size(202, 49);
            PayButton.TabIndex = 6;
            PayButton.Text = "PAY";
            PayButton.UseVisualStyleBackColor = true;
            PayButton.Click += PayButton_Click;
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total.ForeColor = Color.Black;
            total.Location = new Point(496, 825);
            total.Name = "total";
            total.Size = new Size(0, 38);
            total.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(385, 826);
            label3.Name = "label3";
            label3.Size = new Size(117, 41);
            label3.TabIndex = 4;
            label3.Text = "TOTAL:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(248, 16);
            label2.Name = "label2";
            label2.Size = new Size(178, 54);
            label2.TabIndex = 2;
            label2.Text = "ORDERS";
            // 
            // ordertable
            // 
            ordertable.AllowUserToAddRows = false;
            ordertable.AllowUserToDeleteRows = false;
            ordertable.AllowUserToResizeColumns = false;
            ordertable.AllowUserToResizeRows = false;
            ordertable.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            ordertable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            ordertable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordertable.Columns.AddRange(new DataGridViewColumn[] { ordername, orderquantity, orderprice, ordertotal });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            ordertable.DefaultCellStyle = dataGridViewCellStyle5;
            ordertable.Location = new Point(20, 87);
            ordertable.Name = "ordertable";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            ordertable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            ordertable.RowHeadersVisible = false;
            ordertable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            ordertable.RowTemplate.Height = 50;
            ordertable.Size = new Size(630, 718);
            ordertable.TabIndex = 1;
            ordertable.CellBeginEdit += ordertable_CellBeginEdit;
            ordertable.CellClick += ordertable_CellClick;
            ordertable.CellValueChanged += ordertable_CellValueChanged;
            ordertable.EditingControlShowing += ordertable_EditingControlShowing;
            ordertable.DataContextChanged += ordertable_DataContextChanged;
            // 
            // ordername
            // 
            ordername.HeaderText = "PRODUCT";
            ordername.MinimumWidth = 6;
            ordername.Name = "ordername";
            ordername.ReadOnly = true;
            ordername.Width = 220;
            // 
            // orderquantity
            // 
            orderquantity.HeaderText = "QTY";
            orderquantity.MinimumWidth = 6;
            orderquantity.Name = "orderquantity";
            orderquantity.Width = 125;
            // 
            // orderprice
            // 
            orderprice.HeaderText = "PRICE";
            orderprice.MinimumWidth = 6;
            orderprice.Name = "orderprice";
            orderprice.ReadOnly = true;
            orderprice.Width = 120;
            // 
            // ordertotal
            // 
            ordertotal.HeaderText = "TOTAL PRICE";
            ordertotal.MinimumWidth = 6;
            ordertotal.Name = "ordertotal";
            ordertotal.ReadOnly = true;
            ordertotal.Width = 140;
            // 
            // panel5
            // 
            panel5.Controls.Add(label11);
            panel5.Controls.Add(qrcode);
            panel5.Location = new Point(1457, 141);
            panel5.Name = "panel5";
            panel5.Size = new Size(432, 416);
            panel5.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(135, 2);
            label11.Name = "label11";
            label11.Size = new Size(175, 35);
            label11.TabIndex = 1;
            label11.Text = "SCAN TO PAY";
            // 
            // qrcode
            // 
            qrcode.Location = new Point(37, 38);
            qrcode.Name = "qrcode";
            qrcode.Size = new Size(370, 370);
            qrcode.SizeMode = PictureBoxSizeMode.StretchImage;
            qrcode.TabIndex = 0;
            qrcode.TabStop = false;
            // 
            // panel31
            // 
            panel31.Controls.Add(GenerateReceipt);
            panel31.Controls.Add(customeraddress);
            panel31.Controls.Add(customername);
            panel31.Controls.Add(label7);
            panel31.Controls.Add(label6);
            panel31.Controls.Add(cashinput);
            panel31.Controls.Add(label5);
            panel31.Location = new Point(1460, 141);
            panel31.Name = "panel31";
            panel31.Size = new Size(432, 322);
            panel31.TabIndex = 6;
            // 
            // GenerateReceipt
            // 
            GenerateReceipt.FlatStyle = FlatStyle.Flat;
            GenerateReceipt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenerateReceipt.ForeColor = Color.Black;
            GenerateReceipt.Location = new Point(43, 264);
            GenerateReceipt.Name = "GenerateReceipt";
            GenerateReceipt.Size = new Size(357, 43);
            GenerateReceipt.TabIndex = 6;
            GenerateReceipt.Text = "GENERATE RECEIPT";
            GenerateReceipt.UseVisualStyleBackColor = true;
            GenerateReceipt.Click += GenerateReceipt_Click;
            // 
            // customeraddress
            // 
            customeraddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customeraddress.ForeColor = Color.Black;
            customeraddress.Location = new Point(43, 205);
            customeraddress.Name = "customeraddress";
            customeraddress.Size = new Size(357, 34);
            customeraddress.TabIndex = 5;
            // 
            // customername
            // 
            customername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customername.ForeColor = Color.Black;
            customername.Location = new Point(43, 134);
            customername.Name = "customername";
            customername.Size = new Size(357, 34);
            customername.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(43, 171);
            label7.Name = "label7";
            label7.Size = new Size(210, 31);
            label7.TabIndex = 3;
            label7.Text = "Customer Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(39, 100);
            label6.Name = "label6";
            label6.Size = new Size(188, 31);
            label6.TabIndex = 2;
            label6.Text = "Customer Name:";
            // 
            // cashinput
            // 
            cashinput.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashinput.ForeColor = Color.Black;
            cashinput.Location = new Point(122, 17);
            cashinput.Name = "cashinput";
            cashinput.Size = new Size(294, 38);
            cashinput.TabIndex = 1;
            cashinput.KeyPress += cashinput_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(17, 17);
            label5.Name = "label5";
            label5.Size = new Size(106, 41);
            label5.TabIndex = 0;
            label5.Text = "CASH:";
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(GCash);
            panel2.Controls.Add(Cash);
            panel2.Location = new Point(1460, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(432, 121);
            panel2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(96, 9);
            label4.Name = "label4";
            label4.Size = new Size(252, 38);
            label4.TabIndex = 2;
            label4.Text = "Mode of Payment";
            // 
            // GCash
            // 
            GCash.FlatStyle = FlatStyle.Flat;
            GCash.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GCash.ForeColor = Color.Black;
            GCash.Location = new Point(246, 58);
            GCash.Name = "GCash";
            GCash.Size = new Size(170, 50);
            GCash.TabIndex = 1;
            GCash.Text = "GCASH";
            GCash.UseVisualStyleBackColor = true;
            GCash.Click += GCash_Click;
            // 
            // Cash
            // 
            Cash.FlatStyle = FlatStyle.Flat;
            Cash.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cash.ForeColor = Color.Black;
            Cash.Location = new Point(17, 58);
            Cash.Name = "Cash";
            Cash.Size = new Size(170, 50);
            Cash.TabIndex = 0;
            Cash.Text = "CASH";
            Cash.UseVisualStyleBackColor = true;
            Cash.Click += Cash_Click;
            // 
            // Pos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1904, 921);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel31);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(tablepanel);
            Name = "Pos";
            Text = "Pos";
            Load += Pos_Load;
            tablepanel.ResumeLayout(false);
            tablepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)posTable).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ordertable).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)qrcode).EndInit();
            panel31.ResumeLayout(false);
            panel31.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel tablepanel;
        private DataGridView posTable;
        private Label label1;
        private TextBox searchitem;
        private Panel border1;
        private Panel panel1;
        private DataGridView ordertable;
        private DataGridViewImageColumn productimage;
        private DataGridViewTextBoxColumn pname;
        private DataGridViewTextBoxColumn pprice;
        private DataGridViewTextBoxColumn ordername;
        private DataGridViewTextBoxColumn orderquantity;
        private DataGridViewTextBoxColumn orderprice;
        private DataGridViewTextBoxColumn ordertotal;
        private Label label2;
        private Label total;
        private Label label3;
        private Button PayButton;
        private Panel panel2;
        private Button GCash;
        private Button Cash;
        private Label label4;
        private Panel panel4;
        private Label label8;
        private Label label10;
        private Label label9;
        private TextBox gcashinput;
        private Button GenerateReceiptG;
        private TextBox customeraddressg;
        private TextBox customernameg;
        private Panel panel5;
        private PictureBox qrcode;
        private Label label11;
        private Panel panel31;
        private Button GenerateReceipt;
        private TextBox customeraddress;
        private TextBox customername;
        private Label label7;
        private Label label6;
        private TextBox cashinput;
        private Label label5;
    }
}