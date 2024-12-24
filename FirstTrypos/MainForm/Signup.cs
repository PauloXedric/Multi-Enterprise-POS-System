using FirstTrypos.Utility;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirstTrypos.DatabaseQuery;

namespace FirstTrypos
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
            SignupPanelDesign();
            Showpassword();
        }


        private void signupAction_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrWhiteSpace(enterpriseName.Text) ||
                 string.IsNullOrWhiteSpace(address.Text) ||
                 string.IsNullOrWhiteSpace(firstName.Text) ||
                 string.IsNullOrWhiteSpace(lastName.Text) ||
                 string.IsNullOrWhiteSpace(password.Text) ||
                 string.IsNullOrWhiteSpace(cpassword.Text))

            { MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (password.Text != cpassword.Text)
            { MessageBox.Show("Password and Confirm Password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (password.Text.Length < 8)
            { MessageBox.Show("Password should be atleast 8 characters long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }



            UsersQuery checkaccount = new UsersQuery();

            bool existingaccount = checkaccount.CheckUser(enterpriseName.Text);

            if (existingaccount)
            { MessageBox.Show("The enterprise name already exists. Please choose a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            else
            {

               
                UsersQuery signup = new UsersQuery();

                bool sucessful = signup.AddUser(enterpriseName.Text, address.Text, firstName.Text, lastName.Text, password.Text);

                if (sucessful)
                {

                    MessageBox.Show("Succesfully Register.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login loginform = new Login();
                    loginform.Show();
                    Visible = false;

                    loginform.WindowState = FormWindowState.Maximized;

                    this.Close();

                }
                else
                { MessageBox.Show("Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void showpassup_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassup.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }


        private void loginClick(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            loginform.WindowState = FormWindowState.Maximized;
            Visible = false;

            this.Close();
        }


        public void Showpassword()
        {
            password.UseSystemPasswordChar = true;
            cpassword.UseSystemPasswordChar = true;
        }


        //Page Design
        private void SignupPanelDesign()
        {
            Design buttonone = new Design();
            Design buttontwo = new Design();

            Design panelone = new Design();
            Design paneltwo = new Design();
            Design panelthree = new Design();

            Design textboxBorderone = new Design();
            Design textboxBordertwo = new Design();
            Design textboxBorderthree = new Design();
            Design textboxBorderfour = new Design();
            Design textboxBorderfive = new Design();
            Design textboxBordersix = new Design();



            buttonone.BorderRadiuswithColor(gotologinButton, "#FA8072", 15, true, true, true, true);
            buttontwo.BorderRadiuswithGradient(signupAction, "Salmon", "SaddleBrown", "Vertical", 20, true, true, true, true);

            panelone.BorderRadiuswithColor(panel1, "#E5E5E5", 60, true, true, true, true);
            paneltwo.BorderRadiuswithGradient(panel2, "Salmon", "SaddleBrown", "BackwardDiagonal", 60, false, true, false, true);
            panelthree.BorderRadiuswithColor(panel3, "#FFFFFF", 60, true, true, true, true);

            textboxBorderone.BorderRadiuswithGradient(border1, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
            textboxBordertwo.BorderRadiuswithGradient(border2, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
            textboxBorderthree.BorderRadiuswithGradient(border3, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
            textboxBorderfour.BorderRadiuswithGradient(border4, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
            textboxBorderfive.BorderRadiuswithGradient(border5, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
            textboxBordersix.BorderRadiuswithGradient(border6, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
        }


    }
}
