using FirstTrypos.DatabaseQuery;
using FirstTrypos.Utility;
using PointOfSale.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstTrypos
{   
    public partial class Pos : Form
    {
        private DbRelated transferName;
        private string UserId,usernamebased;
        private string Enterprisename, Address, CpNumber, FirstName, LastName;
        BindingSource BindSource = new BindingSource();

        public Pos(DbRelated Namevalue)
        {
            InitializeComponent();
            PosDesign();
            transferName = Namevalue;
            UserId = transferName.UserId;
            usernamebased = transferName.EnterpriseName;


            UsersQuery userinfo = new UsersQuery();
            var usersinfo = userinfo.Receipt(usernamebased);

            if (usersinfo != null)
            {
                Enterprisename = usersinfo.EnterpriseName.ToString();
                Address = usersinfo.Address.ToString();
                LastName = usersinfo.LastName.ToString();
                FirstName = usersinfo.FirstName.ToString();
                CpNumber = usersinfo.CpNumber.ToString();              
            }
            
            posTable.CellFormatting += PosTable_CellFormatting;
            ordertable.CellFormatting += ordertable_CellFormatting;

            ordertable.EditingControlShowing += ordertable_EditingControlShowing;
            ordertable.CellBeginEdit += ordertable_CellBeginEdit;
            ordertable.CellValueChanged += ordertable_CellValueChanged;

            ordertable.RowsAdded += (s, e) => UpdateTotal();
            ordertable.RowsRemoved += (s, e) => UpdateTotal();

            PayButton.Visible = false;

            FeaturesandFunctions.PayButton(GCash,Cash, panel2,label4, false);
            FeaturesandFunctions.CashButton(GenerateReceipt, panel31, cashinput, customername, customeraddress, label5, label6, label7, false);
            FeaturesandFunctions.GcashButton(qrcode, GenerateReceiptG, panel5, panel4, gcashinput, customernameg, customeraddressg, label8, label9, label10, label11, false);
        }

        private void Pos_Load(object sender, EventArgs e)
        {
            PosTable();
            ordertable.DataSourceChanged += ordertable_DataContextChanged;
            ordertable.RowsAdded += (s, args) => CheckOrderTableRows();
            ordertable.RowsRemoved += (s, args) => CheckOrderTableRows();
            CheckOrderTableRows();

            UsersQuery usersquery = new UsersQuery();
            var userquery = usersquery.ShowQrCode(UserId);

            if (userquery != null)
            {            
                byte[] imageBytes = (byte[])userquery.QrCode;
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        qrcode.Image = Image.FromStream(ms);
                    }
                }
            }
        }


        //Table
        public void PosTable()
        {
            PosQuery ShowTable = new PosQuery();

            DataTable inventoryData = ShowTable.PosPageTable(UserId);

            BindSource.DataSource = inventoryData;
            posTable.DataSource = BindSource;

            searchitem.TextChanged += (s, e) => FilterDataGridView(searchitem.Text, "ProductName");
        }

        private void FilterDataGridView(string filterText, string column)
        {
            if (string.IsNullOrEmpty(filterText))
            {
                BindSource.RemoveFilter();
            }
            else
            {
                BindSource.Filter = $"{column} LIKE '%{filterText}%'";
            }
        }

        private void PosTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (posTable.Columns[e.ColumnIndex].Name == "pprice" && e.Value != null)
            {
                e.Value = $"₱{e.Value}";
                e.FormattingApplied = true;
            }
        }


        private void ordertable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (ordertable.Columns[e.ColumnIndex].Name == "orderprice" && e.Value != null)
            {
                e.Value = $"₱{e.Value:F2}";
                e.FormattingApplied = true;
            }
            else if (ordertable.Columns[e.ColumnIndex].Name == "ordertotal" && e.Value != null)
            {
                e.Value = $"₱{e.Value:F2}";
                e.FormattingApplied = true;
            }
        }


        //table function

        private void posTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = posTable.Rows[e.RowIndex];

                var productName = clickedRow.Cells["pname"].Value.ToString();
                var productPrice = Convert.ToDecimal(clickedRow.Cells["pprice"].Value);

                bool productFound = false;

                foreach (DataGridViewRow row in ordertable.Rows)
                {
                    if (row.Cells[0].Value.ToString() == productName)
                    {
                        int currentQuantity = Convert.ToInt32(row.Cells[1].Value);
                        row.Cells[1].Value = currentQuantity + 1;

                        decimal total = (currentQuantity + 1) * productPrice;
                        row.Cells[3].Value = total;

                        productFound = true;
                        break;
                    }
                }
                if (!productFound)
                {
                    decimal total = productPrice * 1;
                    ordertable.Rows.Add(productName, 1, productPrice, total);
                }
            }
        }


        private void ordertable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                ordertable.Rows.RemoveAt(e.RowIndex);
            }
        }



        private void ordertable_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                DataGridViewRow editedRow = ordertable.Rows[e.RowIndex];

                if (int.TryParse(editedRow.Cells[1].Value?.ToString(), out int newQuantity) && newQuantity > 0)
                {
                    decimal productPrice = Convert.ToDecimal(editedRow.Cells[2].Value);
                    decimal total = newQuantity * productPrice;
                    editedRow.Cells[3].Value = total;
                }
                else
                {
                    MessageBox.Show("Please enter a valid quantity (numbers only).");
                    e.Cancel = true;
                }
            }
        }


        private void ordertable_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (ordertable.CurrentCell.ColumnIndex == 1)
            {
                TextBox editingTextBox = e.Control as TextBox;
                if (editingTextBox != null)
                {
                    editingTextBox.KeyPress -= EditingTextBox_KeyPress;
                    editingTextBox.KeyPress += EditingTextBox_KeyPress;
                }
            }
        }


        private void EditingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void ordertable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                DataGridViewRow updatedRow = ordertable.Rows[e.RowIndex];
                if (int.TryParse(updatedRow.Cells[1].Value?.ToString(), out int newQuantity) && newQuantity > 0)
                {
                    decimal productPrice = Convert.ToDecimal(updatedRow.Cells[2].Value);
                    decimal total = newQuantity * productPrice;
                    updatedRow.Cells[3].Value = total;
                }

            }
            UpdateTotal();
        }


        private void UpdateTotal()
        {
            decimal totalget = 0;

            foreach (DataGridViewRow row in ordertable.Rows)
            {
                if (row.Cells[3].Value != null && decimal.TryParse(row.Cells[3].Value.ToString(), out decimal value))
                {
                    totalget += value;
                }
            }
            total.Text = $"₱{totalget:F2}";
        }


        private void CheckOrderTableRows()
        {
            if (ordertable.RowCount > 0)
            {
                PayButton.Visible = true;
            }
            else
            {
                PayButton.Visible = false;
                FeaturesandFunctions.PayButton(GCash, Cash, panel2, label4, false);
                FeaturesandFunctions.CashButton(GenerateReceipt, panel31, cashinput, customername, customeraddress, label5, label6, label7, false);
                FeaturesandFunctions.GcashButton(qrcode, GenerateReceiptG, panel5, panel4, gcashinput, customernameg, customeraddressg, label8, label9, label10, label11, false);
            }
        }


        private void ordertable_DataContextChanged(object sender, EventArgs e)
        {
            CheckOrderTableRows();
        }


        private void PayButton_Click(object sender, EventArgs e)
        {
            FeaturesandFunctions.PayButton(GCash, Cash, panel2, label4, true);          
        }


        private void Cash_Click(object sender, EventArgs e)
        {
            FeaturesandFunctions.CashButton(GenerateReceipt, panel31, cashinput, customername, customeraddress, label5, label6, label7, true);
            FeaturesandFunctions.GcashButton(qrcode, GenerateReceiptG, panel5, panel4, gcashinput, customernameg, customeraddressg, label8, label9, label10, label11, false);
        }

        private void GCash_Click(object sender, EventArgs e)
        {
            FeaturesandFunctions.CashButton(GenerateReceipt, panel31, cashinput, customername, customeraddress, label5, label6, label7, false);
            FeaturesandFunctions.GcashButton(qrcode, GenerateReceiptG, panel5, panel4, gcashinput, customernameg, customeraddressg, label8, label9, label10, label11, true);
        }



        //Generate Receipt
        private void GenerateReceipt_Click(object sender, EventArgs e)
        {
            Receipt receipt = new Receipt();

            receipt.ReceiptSlip(ordertable, cashinput, customername, customeraddress, Enterprisename, Address, CpNumber, FirstName, LastName, "Cash");
          
            FeaturesandFunctions.PayButton(GCash, Cash, panel2, label4, false);
            FeaturesandFunctions.CashButton(GenerateReceipt, panel31, cashinput, customername, customeraddress, label5, label6, label7, false);
            FeaturesandFunctions.GcashButton(qrcode, GenerateReceiptG, panel5, panel4, gcashinput, customernameg, customeraddressg, label8, label9, label10, label11, false);
        }


        private void GenerateReceiptG_Click(object sender, EventArgs e)
        {
            Receipt receipt = new Receipt();

            receipt.ReceiptSlip(ordertable, gcashinput, customernameg, customeraddressg, Enterprisename, Address, CpNumber, FirstName, LastName, "GCash");

            FeaturesandFunctions.PayButton(GCash, Cash, panel2, label4, false);
            FeaturesandFunctions.CashButton(GenerateReceipt, panel31, cashinput, customername, customeraddress, label5, label6, label7, false);
            FeaturesandFunctions.GcashButton(qrcode, GenerateReceiptG, panel5, panel4, gcashinput, customernameg, customeraddressg, label8, label9, label10, label11, false);
        }


        //Allow numbers only
        private void cashinput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void gcashinput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        //Page Design
        private void PosDesign()
        {
            Design buttonone = new Design();
            Design buttontwo = new Design();
            Design buttonthree = new Design();
            Design buttonfour = new Design();
            Design buttonfive = new Design();

            Design panelone = new Design();
            Design paneltwo = new Design();
            Design panelthree = new Design();
            Design panelfour = new Design();
            Design panelfive = new Design();
            Design panelsix = new Design();


            Design textboxBorderone = new Design();

            buttonone.BorderRadiuswithGradient(PayButton, "Salmon", "SaddleBrown", "Vertical", 20, true, true, true, true);
            buttontwo.BorderRadiuswithGradient(Cash, "Salmon", "SaddleBrown", "Vertical", 20, true, true, true, true);
            buttonthree.BorderRadiuswithGradient(GCash, "Salmon", "SaddleBrown", "Vertical", 20, true, true, true, true);
            buttonfour.BorderRadiuswithGradient(GenerateReceipt, "Salmon", "SaddleBrown", "Vertical", 20, true, true, true, true);
            buttonfive.BorderRadiuswithGradient(GenerateReceiptG, "Salmon", "SaddleBrown", "Vertical", 20, true, true, true, true);

            panelone.BorderRadiuswithColor(tablepanel, "#FFFFFF", 40, true, true, true, true);
            paneltwo.BorderRadiuswithColor(panel1, "#FFFFFF", 40, true, true, true, true);
            panelthree.BorderRadiuswithColor(panel2, "#FFFFFF", 40, true, true, true, true);
            panelfour.BorderRadiuswithColor(panel31, "#FFFFFF", 40, true, true, true, true);
            panelfive.BorderRadiuswithColor(panel4, "#FFFFFF", 40, true, true, true, true);
            panelsix.BorderRadiuswithColor(panel5, "#FFFFFF", 40, true, true, true, true);

            textboxBorderone.BorderRadiuswithGradient(border1, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
        }

    }
}
