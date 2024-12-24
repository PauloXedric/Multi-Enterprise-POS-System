using FirstTrypos.DatabaseQuery;
using FirstTrypos.Utility;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstTrypos
{

    public partial class inventoryupdate : Form
    {

        private DbRelated transferName;
        private string UserId;
        private string productnamebased;
        private Inventory parentInventory;


        public inventoryupdate(DbRelated Namevalue, Inventory parentForm)
        {
            InitializeComponent();
            InventoryModalDesign();

            transferName = Namevalue;
            UserId = transferName.UserId;
            productnamebased = transferName.ProductName;

            parentInventory = parentForm;
            ShowProductToUpdate();
        }


        private void ShowProductToUpdate()
        {
            InventoryQuery inventoryQuery = new InventoryQuery();
            var showdata = inventoryQuery.FillShowProductToUpdate(productnamebased, UserId);

            if (showdata != null)
            {
                iuproductname.Text = showdata.ProductName.ToString();
                iuproductquantity.Text = showdata.ProductQuantity.ToString();
                iuproductcode.Text = showdata.ProductCode.ToString();
                iuproductcategory.Text = showdata.ProductCategory.ToString();
                iuproductprice.Text = showdata.ProductPrice.ToString();
                byte[] ProductImage = (byte[])showdata.ProductPic;
                using (MemoryStream ms = new MemoryStream(ProductImage))
                {
                    iuproductpic.Image = Image.FromStream(ms);
                }
            }         
        }


        //Update Product Information
        private void updatebutton_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to Update the Product?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes) {

                InventoryQuery updateinfo = new InventoryQuery();

                bool UpdateProductInfo = updateinfo.UpdateProductInformation(iuproductpic.Image, productnamebased, iuproductname.Text, iuproductcode.Text, iuproductcategory.Text, iuproductquantity.Text, iuproductprice.Text, UserId);

                if (UpdateProductInfo)
                { MessageBox.Show("Product Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    parentInventory.InventoryTable();
                    this.Close();                                     
                }
            }
        }


        //Delete Product Information
        private void deletebutton_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                InventoryQuery deleteinfo = new InventoryQuery();

                bool DeleteProductInfo = deleteinfo.DeleteProductInformation(productnamebased, UserId);

                if (DeleteProductInfo)
                { MessageBox.Show("Product Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    parentInventory.InventoryTable();
                    this.Close();
                }
            }
        }


        private void buttonofimage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog corfile = new OpenFileDialog())
            {
                corfile.Filter = "Image Files (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
                // The line causing the issue
                DialogResult result = corfile.ShowDialog();

                if (result == DialogResult.OK)
                {
                    using (var stream = new FileStream(corfile.FileName, FileMode.Open, FileAccess.Read))
                    {
                        iuproductpic.Image = new Bitmap(stream);
                    }
                }
            }
        }


        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Page Design
        private void InventoryModalDesign()
        {
            Design buttonone = new Design();
            Design buttontwo = new Design();
            Design buttonthree = new Design();
            Design buttonfour = new Design();

            buttonone.BorderRadiuswithColor(deletebutton, "#FFFFFF", 40, false, false, false, false);
            buttontwo.BorderRadiuswithColor(close, "#FFFFFF", 40, false, false, false, false);
            buttonthree.BorderRadiuswithColor(buttonofimage, "#FA8072", 15, true, true, true, true);
            buttonfour.BorderRadiuswithGradient(updatebutton, "Salmon", "SaddleBrown", "Vertical", 20, true, true, true, true);
        }
     
    }
}
