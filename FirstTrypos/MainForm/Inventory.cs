using FirstTrypos.DatabaseQuery;
using FirstTrypos.Utility;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FirstTrypos
{
    public partial class Inventory : Form
    {
        private string UserId;
        private DbRelated transferName;
        BindingSource BindSource = new BindingSource();


        public Inventory(DbRelated Namevalue)
        {
            InitializeComponent();

            transferName = Namevalue;
            UserId = transferName.UserId;
            

            FeaturesandFunctions.cleanfiltering(searchproduct, searchcategory);
            InventoryDesign();
            inventoryTable.CellFormatting += InventoryTable_CellFormatting;

            addstocksbutton.Visible = false;
            editproductbutton.Visible = false;
            label9.Visible = false;
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            InventoryTable();
        }



        //Table of Page
        public void InventoryTable()
        {

            InventoryQuery ShowTable = new InventoryQuery();

            DataTable inventoryData = ShowTable.InventoryPageTable(UserId);

            BindSource.DataSource = inventoryData;
            inventoryTable.DataSource = BindSource;

            searchproduct.TextChanged += (s, e) => FilterDataGridView(searchproduct.Text, "ProductName");
            searchcategory.TextChanged += (s, e) => FilterDataGridView(searchcategory.Text, "ProductCategory");

         
            inventoryTable.CellClick += InventoryTable_CellClick;
        }



        //InventoryTable Data Filtration
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

        private void InventoryTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == inventoryTable.Columns["pname"].Index)
                {
                    DataGridViewRow row = inventoryTable.Rows[e.RowIndex];

                    productname.Text = row.Cells["pname"].Value.ToString();
                    productcategory.Text = row.Cells["pcategory"].Value.ToString();
                    productprice.Text = row.Cells["pprice"].Value.ToString();

                    byte[] imageBytes = row.Cells["productimage"].Value as byte[];
                    if (imageBytes != null && imageBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            productpic.Image = Image.FromStream(ms);

                            productcode.ReadOnly = true;
                            productcategory.Enabled = false;
                            productprice.ReadOnly = true;
                        }
                    }
                    else
                    {
                        productpic.Image = null;
                    }
                }               
            }
        }



        //Product Textchanged Checker
  
        private void productname_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(productname.Text))
            {
                InventoryQuery inventoryQuery = new InventoryQuery();
                var productchecking = inventoryQuery.ProductSearching(productname.Text, UserId);

                if (productchecking != null)
                {
                    productcode.Text = productchecking.ProductCode  ;
                    productcategory.Text = productchecking.ProductCategory ;
                    productprice.Text = productchecking.ProductPrice ;

                    byte[] imageBytes = productchecking.ProductPic;
                    if (imageBytes != null && imageBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            productpic.Image = Image.FromStream(ms);
                        }
                    }
                    productpic.Enabled = false;
                    productcode.ReadOnly = true;
                    productcategory.Enabled = false;
                    productprice.ReadOnly = true;
                    FeaturesandFunctions.HideProductChecker(addproductbutton, chooseimage, label1, false);
                    FeaturesandFunctions.HideProductChecker(addstocksbutton, editproductbutton, label9, true);                
                }
                else
                {
                   productpic.Enabled = true;
                    productcode.ReadOnly = false;
                    productcategory.Enabled = true;
                  productprice.ReadOnly = false;
                  FeaturesandFunctions.HideProductChecker(addproductbutton, chooseimage, label1, true);
                  FeaturesandFunctions.HideProductChecker(addstocksbutton, editproductbutton, label9, false);
                   
                }
            }
            else
            {
                FeaturesandFunctions.HideProductChecker(addproductbutton, chooseimage, label1, true);
                FeaturesandFunctions.HideProductChecker(addstocksbutton, editproductbutton, label9, false);
                productpic.Image = null;
                productcode.Text = string.Empty;
                productcategory.SelectedIndex = -1;
                productquantity.Text = string.Empty;
                productprice.Text = string.Empty;
            }
        }



        //Product insertion
        private void addproductbutton_Click(object sender, EventArgs e)
        {
            if (productpic.Image == null ||
                 string.IsNullOrWhiteSpace(productname.Text) ||
                 string.IsNullOrWhiteSpace(productcode.Text) ||
                 string.IsNullOrWhiteSpace(productcategory.Text) ||
                 string.IsNullOrWhiteSpace(productquantity.Text) ||
                 string.IsNullOrWhiteSpace(productprice.Text))
            {

                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //In actual field product code is identical to a specific product
            //product name == product code


            //Check if product name already exist

            InventoryQuery existingproduct = new InventoryQuery();

            bool ifexistingname = existingproduct.CheckExistingProduct(productname.Text, UserId, "ProductName");

            if (ifexistingname)
            { MessageBox.Show("The Product Name already exists. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }


            //Check if product code already exist

            InventoryQuery existingproductcode = new InventoryQuery();

            bool ifexistingcode = existingproductcode.CheckExistingProduct(productcode.Text, UserId, "ProductCode");

            if (ifexistingcode)
            { MessageBox.Show("The Product Code already exists. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }


            //Adding of  product

            InventoryQuery addproduct = new InventoryQuery();

            bool successfulltAddproduct = addproduct.AddProduct(productpic.Image, productname.Text, productcode.Text, productcategory.Text, productquantity.Text, productprice.Text, UserId);


            if (successfulltAddproduct)
            {
                MessageBox.Show("Product Added Succesfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                InventoryTable();
                FeaturesandFunctions.AddProductClearFields(productpic, productname, productcode, productcategory, productquantity, productprice);
            }
        }


        //Product Stock Adding
        private void addstocksbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productquantity.Text))
            { MessageBox.Show("Product Quantity must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            InventoryQuery getStocks = new InventoryQuery();
            var gettingstocks = getStocks.GetCurrentStocks(productname.Text, UserId);

            if (gettingstocks != null)
            {
                int currentStock = Convert.ToInt32(gettingstocks.ProductQuantity);
                int addedstock = Convert.ToInt32(productquantity.Text);
                int addstock = currentStock + addedstock;
                string newstock = addstock.ToString();

                InventoryQuery updateStocks = new InventoryQuery();

                bool stocksUpdate = updateStocks.UpdateProductStocks(productname.Text, UserId, newstock);

                if (stocksUpdate)
                {
                    MessageBox.Show("Product Stock Succesfully Updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    InventoryTable();
                    FeaturesandFunctions.AddProductClearFields(productpic, productname, productcode, productcategory, productquantity, productprice);
                }
            }
        }


        //Pass data to Modal inventoryupdate.cs
        private void editproductbutton_Click(object sender, EventArgs e)
        {
            DbRelated transfer = new DbRelated();
            transfer.SetProductValue(UserId, productname.Text);

            inventoryupdate showform = new inventoryupdate(transfer, this);
            showform.ShowDialog();
        }


        // Allow numbers only
        private void inventoryQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void inventoryUprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void chooseimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();

            openfile.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                productpic.Image = Image.FromFile(openfile.FileName);
            }
        }

        private void InventoryTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (inventoryTable.Columns[e.ColumnIndex].Name == "pprice" && e.Value != null)
            {
                e.Value = $"₱{e.Value}";
                e.FormattingApplied = true;
            }
        }


        //Page Design
        private void InventoryDesign()
        {
            Design buttonone = new Design();
            Design buttontwo = new Design();
            Design buttonthree = new Design();
            Design buttonfour = new Design();


            Design panelone = new Design();
            Design paneltwo = new Design();

            Design textboxBorderone = new Design();
            Design textboxBordertwo = new Design();
            Design textboxBorderthree = new Design();
            Design textboxBorderfour = new Design();
            Design textboxBorderfive = new Design();
            Design textboxBordersix = new Design();
            Design textboxBorderseven = new Design();
            Design textboxBordereight = new Design();

            buttonone.BorderRadiuswithColor(chooseimage, "#FA8072", 15, true, true, true, true);
            buttontwo.BorderRadiuswithGradient(addproductbutton, "Salmon", "SaddleBrown", "Vertical", 20, true, true, true, true);
            buttonthree.BorderRadiuswithColor(editproductbutton, "#FA8072", 15, true, true, true, true);
            buttonfour.BorderRadiuswithGradient(addstocksbutton, "Salmon", "SaddleBrown", "Vertical", 20, true, true, true, true);

            panelone.BorderRadiuswithColor(panel1, "#FFFFFF", 40, true, true, true, true);
            paneltwo.BorderRadiuswithColor(tablepanel, "#FFFFFF", 40, true, true, true, true);

            textboxBorderone.BorderRadiuswithGradient(border1, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
            textboxBordertwo.BorderRadiuswithGradient(border2, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
            textboxBorderthree.BorderRadiuswithGradient(border3, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
            textboxBorderfour.BorderRadiuswithGradient(border4, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
            textboxBorderfive.BorderRadiuswithGradient(border5, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
            textboxBordersix.BorderRadiuswithGradient(border6, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
            textboxBorderseven.BorderRadiuswithGradient(border7, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
            textboxBordereight.BorderRadiuswithGradient(border8, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
        }


    }
}
