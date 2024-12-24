using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Drawing.Drawing2D;
using FirstTrypos.Utility;
using FirstTrypos.DatabaseQuery;

namespace FirstTrypos
{
    public partial class Login : Form
    {
        private string UserId; 

        public Login()
        {
            InitializeComponent();
            LoginDesign();
            Showpassword();
        }


        private void loginAction(object sender, EventArgs e)
        {

            UsersQuery login = new UsersQuery();

            bool gologin = login.Login(usernameLogin.Text, passwordLogin.Text);

            if (gologin)
            {

                UsersQuery usersquery = new UsersQuery();
                var getid = usersquery.GetUserId(usernameLogin.Text);

                if (getid != null)
                {
                    UserId = getid.UserId.ToString();

                    DbRelated transfer = new DbRelated();
                    transfer.SetEnterpriseName(usernameLogin.Text);
                    transfer.SetUserId(UserId);

                    Home HomeForm = new Home(transfer);
                    HomeForm.Show();


                    HomeForm.WindowState = FormWindowState.Maximized;

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Account Does Not Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void signupClick(object sender, EventArgs e)
        {
            Signup signform = new Signup();
            Visible = false;
            signform.Show();
            signform.WindowState = FormWindowState.Maximized;

            this.Close();
        }

        private void showpasswordLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (showpasswordLogin.Checked)
            {
                passwordLogin.UseSystemPasswordChar = false;
            }
            else
            {
                passwordLogin.UseSystemPasswordChar = true;
            }
        }

        public void Showpassword()
        {
            passwordLogin.UseSystemPasswordChar = true;
        }


        //Page design
        private void LoginDesign()
        {
            Design buttonone = new Design();
            Design buttontwo = new Design();

            Design panelone = new Design();
            Design paneltwo = new Design();
            Design panelthree = new Design();

            Design textboxBorderone = new Design();
            Design textboxBordertwo = new Design();


            buttonone.BorderRadiuswithColor(gotosignupButton, "#FA8072", 15, true, true, true, true);
            buttontwo.BorderRadiuswithGradient(loginButton, "Salmon", "SaddleBrown", "Vertical", 20, true, true, true, true);

            panelone.BorderRadiuswithGradient(panel1, "Salmon", "SaddleBrown", "ForwardDiagonal", 60, true, false, true, false);
            paneltwo.BorderRadiuswithColor(panel2, "#FFFFFF", 60, true, true, true, true);
            panelthree.BorderRadiuswithColor(panel3, "#E5E5E5", 60, true, true, true, true);

            textboxBorderone.BorderRadiuswithGradient(border1, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
            textboxBordertwo.BorderRadiuswithGradient(border2, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
        }

    }
}