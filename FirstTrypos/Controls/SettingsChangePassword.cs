using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirstTrypos.Utility;
using FirstTrypos.DatabaseQuery;
using System.Net;

namespace PointOfSale.Controls
{
    public partial class SettingsChangePassword : UserControl
    {
        private DbRelated transferName;
        private string usernamebased;

        public SettingsChangePassword(DbRelated Namevalue)
        {
            InitializeComponent();
            SettingsChangePasswordDesign();
            Showpassword();

            transferName = Namevalue;
            usernamebased = transferName.EnterpriseName;

            username.Text = usernamebased;

            FeaturesandFunctions.SettingsChangePasswordControl(border3, border4, newpassword, confirmnewpassword, savechanges, label4, label5, showpass, false);
        }


        private void update_Click(object sender, EventArgs e)
        {
            UsersQuery userquery = new UsersQuery();

            bool Usersquery = userquery.Login(username.Text, password.Text);

            if (Usersquery)
            {
                FeaturesandFunctions.SettingsChangePasswordControl(border3, border4, newpassword, confirmnewpassword, savechanges, label4, label5, showpass, true);
            }
            else
            {
                MessageBox.Show("Incorrect Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void savechanges_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username.Text) ||
                string.IsNullOrWhiteSpace(newpassword.Text) ||
                string.IsNullOrWhiteSpace(confirmnewpassword.Text))
            {
                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newpassword.Text != confirmnewpassword.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newpassword.Text.Length < 8)
            {
                MessageBox.Show("Password should be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to update your password?", "Confirm Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            UsersQuery usersquery = new UsersQuery();

            bool UsersqueryResult = usersquery.UpdatePassword(username.Text, newpassword.Text);

            if (UsersqueryResult)
            {
                FeaturesandFunctions.SettingsChangePasswordControl(border3, border4, newpassword, confirmnewpassword, savechanges, label4, label5, showpass, false);
                password.Text = string.Empty;
                MessageBox.Show("Password updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }       
        }


        public void Showpassword()
        {
            newpassword.UseSystemPasswordChar = true;
            confirmnewpassword.UseSystemPasswordChar = true;
        }


        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked)
            {
                newpassword.UseSystemPasswordChar = false;
            }
            else
            {
                newpassword.UseSystemPasswordChar = true;
            }
        }


        //Page Design 
        private void SettingsChangePasswordDesign()
        {
            Design buttonone = new Design();
            Design buttontwo = new Design();

            Design panelone = new Design();

            Design textboxBorderone = new Design();
            Design textboxBordertwo = new Design();
            Design textboxBorderthree = new Design();
            Design textboxBorderfour = new Design();

            buttonone.BorderRadiuswithGradient(update, "Salmon", "SaddleBrown", "Vertical", 20, true, true, true, true);
            buttontwo.BorderRadiuswithGradient(savechanges, "Salmon", "SaddleBrown", "Vertical", 20, true, true, true, true);

            panelone.BorderRadiuswithColor(panel1, "#FFFFFF", 40, true, true, true, true);

            textboxBorderone.BorderRadiuswithGradient(border1, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
            textboxBordertwo.BorderRadiuswithGradient(border2, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
            textboxBorderthree.BorderRadiuswithGradient(border3, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
            textboxBorderfour.BorderRadiuswithGradient(border4, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
        }
     
    }
}
