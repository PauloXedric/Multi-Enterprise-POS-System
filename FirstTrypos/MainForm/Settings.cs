using FirstTrypos.DatabaseQuery;
using FirstTrypos.Utility;
using Microsoft.VisualBasic.Logging;
using PointOfSale.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FirstTrypos
{
    public partial class Settings : Form
    {
        private DbRelated transferName;
        private string UserId;

        public Settings(DbRelated Namevalue)
        {
            InitializeComponent();
            SettingsDesign();

            transferName = Namevalue;
            UserId = transferName.EnterpriseName;
        }


        private void Settings_Load(object sender, EventArgs e)
        {
            SettingsUserInformation settingsusersinformation = new SettingsUserInformation(transferName);

            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(settingsusersinformation);
            settingsusersinformation.Dock = DockStyle.Fill;
        }


        private void updateinformation_Click(object sender, EventArgs e)
        {
            SettingsUpdateInformation settingsupdateinformation = new SettingsUpdateInformation(transferName);

            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(settingsupdateinformation);
            settingsupdateinformation.Dock = DockStyle.Fill;
            
            FeaturesandFunctions.SettingsUserControl(updateinformation, changepassword, false, showinfo, true);
        }


        private void showinfo_Click(object sender, EventArgs e)
        {
            SettingsUserInformation settingsusersinformation = new SettingsUserInformation(transferName);

            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(settingsusersinformation);
            settingsusersinformation.Dock = DockStyle.Fill;

            FeaturesandFunctions.SettingsUserControl(updateinformation, changepassword, true, showinfo, false);
        }


        private void changepassword_Click(object sender, EventArgs e)
        {
            SettingsChangePassword settingschangepassword = new SettingsChangePassword(transferName);

            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(settingschangepassword); 
            settingschangepassword.Dock = DockStyle.Fill;

            FeaturesandFunctions.SettingsUserControl(updateinformation, changepassword, false, showinfo, true);
        }


        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to log out? All unsaved changes will be lost.",
            "Logout Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login logout = new Login();

                logout.Show();
                Visible = false;
                logout.WindowState = FormWindowState.Maximized;

                this.Close();

                foreach (Form openForm in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (openForm is Home || openForm == this)
                    {
                        openForm.Close();
                    }
                }
            }
        }


        //Page Design
        private void SettingsDesign()
        {
            Design buttonone = new Design();
            Design buttontwo = new Design();
            Design buttonthree = new Design();
            Design buttonfour = new Design();

            Design panelone = new Design();
            Design paneltwo = new Design();


            buttonone.BorderRadiuswithGradient(logout, "Salmon", "SaddleBrown", "Vertical", 20, true, true, true, true);
            buttontwo.BorderRadiuswithGradient(updateinformation, "Salmon", "SaddleBrown", "Vertical", 20, true, true, true, true);
            buttonthree.BorderRadiuswithGradient(changepassword, "Salmon", "SaddleBrown", "Vertical", 20, true, true, true, true);
            buttonfour.BorderRadiuswithGradient(showinfo, "Salmon", "SaddleBrown", "Vertical", 20, true, true, true, true);

            panelone.BorderRadiuswithColor(settingpanel, "#FFFFFF", 40, true, true, true, true);
            paneltwo.BorderRadiuswithColor(panel1, "#FFFFFF", 40, true, true, true, true);
        }

      
    }
}
