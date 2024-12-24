using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace FirstTrypos.Utility
{
    internal class FeaturesandFunctions
    {
        // Inventory.cs 
        public static void AddProductClearFields(PictureBox productPic, TextBox productName, TextBox productCode, ComboBox productCategory, TextBox productQuantity, TextBox productPrice)
        {
            productPic.Image = null;
            productName.Text = string.Empty;
            productCode.Text = string.Empty;
            productCategory.SelectedIndex = -1;
            productQuantity.Text = string.Empty;
            productPrice.Text = string.Empty;
        }


        public static void HideProductChecker(Button button1, Button button2, Label label, bool visiblestatus) 
        {
            button1.Visible = visiblestatus;
            button2.Visible = visiblestatus;
            label.Visible = visiblestatus;
        }


        // Pos.cs
        public static void PayButton(Button button1, Button button2, Panel panel, Label label, bool visiblestatus)
        {         
            button1.Visible = visiblestatus;
            button2.Visible = visiblestatus;
            panel.Visible = visiblestatus;
            label.Visible = visiblestatus;
        }


        public static void CashButton(Button button, Panel panel,TextBox textbox1, TextBox textbox2, TextBox textbox3, Label label1, Label label2, Label label3, bool visiblestatus)
        {
            button.Visible = visiblestatus;
            panel.Visible = visiblestatus;
            textbox1.Visible = visiblestatus;
            textbox2.Visible = visiblestatus;
            textbox3.Visible = visiblestatus;
            label1.Visible = visiblestatus;
            label2.Visible = visiblestatus;
            label3.Visible = visiblestatus;      
        }


        public static void GcashButton(PictureBox picturebox, Button button, Panel panel1, Panel panel2, TextBox textbox1, TextBox textbox2, TextBox textbox3, Label label1, Label label2, Label label3, Label label4, bool visiblestatus )
        {
            picturebox.Visible = visiblestatus;
            button.Visible = visiblestatus;
            panel1.Visible = visiblestatus;
            panel2.Visible = visiblestatus;
            textbox1.Visible = visiblestatus;
            textbox2.Visible = visiblestatus;
            textbox3.Visible = visiblestatus;
            label1.Visible = visiblestatus;
            label2.Visible = visiblestatus;
            label3.Visible = visiblestatus;
            label4.Visible = visiblestatus;
        }


        public static void cleanfiltering(TextBox searchProduct, ComboBox searchCategory)
        {
            searchProduct.GotFocus += (s, e) => searchCategory.SelectedIndex = -1; // Clear ComboBox
            searchCategory.GotFocus += (s, e) => searchProduct.Text = string.Empty; // Clear TextBox
        }


        // Settings.cs

        public static void SettingsUserControl(Button button1, Button button2, bool visiblestatus, Button button3, bool visiblestatus2)
        {
            button1.Visible = visiblestatus;
            button2.Visible = visiblestatus;
            button3.Visible = visiblestatus2;
        }


        public static void SettingsChangePasswordControl(Panel panel1, Panel panel2, TextBox textbox1, TextBox textbox2, Button button, Label label1, Label label2, CheckBox checkbox, bool visiblestatus)
        {
            panel1.Visible = visiblestatus;
            panel2.Visible = visiblestatus;
            textbox1.Visible = visiblestatus;
            textbox2.Visible = visiblestatus;
            button.Visible = visiblestatus;
            label1.Visible = visiblestatus;
            label2.Visible = visiblestatus;
            checkbox.Visible = visiblestatus;           
        }

    }
}
