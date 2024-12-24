using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirstTrypos.DatabaseQuery;
using FirstTrypos.Utility;

namespace FirstTrypos
{
    public partial class Home : Form
    {
        
        private string UserId;

        private DbRelated transferName;

        public Home(DbRelated Namevalue)
        {
            InitializeComponent();
            HomeDesign();
            this.Load += Home_Load;

            DbRelated transfer = new DbRelated();
            transfer.SetEnterpriseName(profilename.Text);
            transfer.SetUserId(UserId);

            closeDropdownTimer.Interval = 2000;
            closeDropdownTimer.Tick += CloseDropdownTimer_Tick;

            transferName = Namevalue;
            profilename.Text = transferName.EnterpriseName;
            UserId = transferName.UserId;


            UsersQuery GetProfile = new UsersQuery();
            var ShowProfile = GetProfile.Profilepic(profilename.Text);

            if (ShowProfile != null)
            {
                byte[] imageBytes = (byte[])ShowProfile.ProfilePicture;
                if (imageBytes != null && imageBytes.Length > 0)
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        profilepicture.Image = Image.FromStream(ms);
                    }
            }
        }
         

        public void LoadPages(object Form)
        {
            if (this.mainframe.Controls.Count > 0)
                this.mainframe.Controls.RemoveAt(0);

            Form form = Form as Form;
            form.TopLevel = false;

            form.Dock = DockStyle.Fill;
            this.mainframe.Controls.Add(form);
            this.mainframe.Tag = form;
            form.Show();

            homepagetag.Text = "POS";
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Pos posForm = new Pos(transferName);
            posForm.PosTable();
            LoadPages(posForm);
        }


        private void posButton_Click(object sender, EventArgs e)
        {
            DbRelated transfer = new DbRelated();
            transfer.SetEnterpriseName(profilename.Text);
            transfer.SetUserId(UserId);

            Pos posForm = new Pos(transfer);
            LoadPages(posForm);

            homepagetag.Text = "POS";
        }


        private void inventoryButton_Click(object sender, EventArgs e)
        {
            DbRelated transfer = new DbRelated();
            transfer.SetEnterpriseName(profilename.Text);
            transfer.SetUserId(UserId);

            Inventory inventoryForm = new Inventory(transfer);
            LoadPages(inventoryForm);

            homepagetag.Text = "INVENTORY";
        }


        private void settingsButton_Click(object sender, EventArgs e)
        {
            DbRelated transfer = new DbRelated();
            transfer.SetEnterpriseName(profilename.Text);
            transfer.SetUserId(UserId);

            Settings settingForm = new Settings(transfer);
            LoadPages(settingForm);

            homepagetag.Text = "SETTINGS";
        }


        private void dropdownButton_Click(object sender, EventArgs e)
        {
            dropdown.BringToFront();
            timer2.Start();
        }


        System.Windows.Forms.Timer closeDropdownTimer = new System.Windows.Forms.Timer();
        bool expand = false;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (expand == false)
            {
                dropdown.Height += 15;
                if (dropdown.Height >= dropdown.MaximumSize.Height)
                {
                    timer2.Stop();
                    expand = true;
                    closeDropdownTimer.Start();
                }
            }
            else
            {
                dropdown.Height -= 15;
                if (dropdown.Height <= dropdown.MinimumSize.Height)
                {
                    timer2.Stop();
                    expand = false;
                    closeDropdownTimer.Stop();
                }
            }
        }

        private void CloseDropdownTimer_Tick(object sender, EventArgs e)
        {
            if (expand)
            {
                timer2.Start();
                closeDropdownTimer.Stop();
            }
        }
        

        //Page design
        private void HomeDesign()
        {
            Design button1 = new Design();
            Design button2 = new Design();
            Design button3 = new Design();
            Design button4 = new Design();

            button1.BorderRadiuswithGradient(dropdownButton, "Salmon", "SaddleBrown", "ForwardDiagonal", 10, true, true, true, true);
            button2.BorderRadiuswithGradient(posButton, "Salmon", "SaddleBrown", "Vertical", 10, true, true, true, true);
            button3.BorderRadiuswithGradient(inventoryButton, "Salmon", "SaddleBrown", "Vertical", 10, true, true, true, true);
            button4.BorderRadiuswithGradient(settingsButton, "Salmon", "SaddleBrown", "Vertical", 10, true, true, true, true);
        }

       
    }
}
