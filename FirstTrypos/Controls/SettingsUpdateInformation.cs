using FirstTrypos;
using FirstTrypos.DatabaseQuery;
using FirstTrypos.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.Controls
{
    public partial class SettingsUpdateInformation : UserControl
    {
        private DbRelated transferName;
        private string usernamebased;

        public SettingsUpdateInformation(DbRelated Namevalue)
        {
            InitializeComponent();
            SettingsUpdateInformationDesign();

            transferName = Namevalue;
            usernamebased = transferName.EnterpriseName;  
            enterprisename.ReadOnly = true;
        }


        private void SettingsUpdateInformation_Load(object sender, EventArgs e)
        {
            UsersQuery userinfo = new UsersQuery();
            var usersinfo = userinfo.UserInformation(usernamebased);

            if (usersinfo != null)
            {
                enterprisename.Text = usersinfo.EnterpriseName.ToString();
                address.Text = usersinfo.Address.ToString();
                lastname.Text = usersinfo.LastName.ToString();
                firstname.Text = usersinfo.FirstName.ToString();
                cpnumber.Text = usersinfo.CpNumber.ToString();
                byte[] imageBytes = (byte[])usersinfo.ProfilePicture;
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        profile.Image = Image.FromStream(ms);
                    }
                }
                byte[] imageByte = (byte[])usersinfo.QrCode;
                if (imageByte != null && imageByte.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageByte))
                    {
                        qrcode.Image = Image.FromStream(ms);
                    }
                }
            }
        }


        private void UpdateInfo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you change your information?",
            "Save Changes",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UsersQuery usersQuery = new UsersQuery();

                bool userupdate = usersQuery.UpdateUserInformation(enterprisename.Text, address.Text, lastname.Text, firstname.Text, cpnumber.Text, usernamebased, profile.Image, qrcode.Image);
                if (userupdate)
                { MessageBox.Show("UPDATED SUCCESSFULLY. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                    return;
                }
            }
        }


        //Browse Image
        private void setprofile_Click(object sender, EventArgs e)
        {
            OpenFileDialog corfile = new OpenFileDialog();

            corfile.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

            if (corfile.ShowDialog() == DialogResult.OK)
            {
                profile.Image = Image.FromFile(corfile.FileName);
            }
        }


        private void setqrcode_Click(object sender, EventArgs e)
        {
            OpenFileDialog corfile = new OpenFileDialog();

            corfile.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

            if (corfile.ShowDialog() == DialogResult.OK)
            {
                qrcode.Image = Image.FromFile(corfile.FileName);
            }
        }

    
        //Page Design
        private void SettingsUpdateInformationDesign()
        {
            Design buttonone = new Design();
            Design buttontwo = new Design();
            Design buttonthree = new Design();

            Design panelone = new Design();
            Design paneltwo = new Design();

            Design textboxBorderone = new Design();
            Design textboxBordertwo = new Design();
            Design textboxBorderthree = new Design();
            Design textboxBorderfour = new Design();
            Design textboxBorderfive = new Design();
            Design textboxBordersix = new Design();
            Design textboxBorderseven = new Design();

            buttonone.BorderRadiuswithColor(setprofile, "#FA8072", 15, true, true, true, true);
            buttontwo.BorderRadiuswithColor(setqrcode, "#FA8072", 15, true, true, true, true);
            buttonthree.BorderRadiuswithGradient(UpdateInfo, "Salmon", "SaddleBrown", "Vertical", 20, true, true, true, true);

            panelone.BorderRadiuswithColor(panel1, "#FFFFFF", 40, true, true, true, true);
            paneltwo.BorderRadiuswithColor(panel2, "#FFFFFF", 40, true, true, true, true);

            textboxBorderone.BorderRadiuswithGradient(border1, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
            textboxBordertwo.BorderRadiuswithGradient(border2, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
            textboxBorderthree.BorderRadiuswithGradient(border3, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
            textboxBorderfour.BorderRadiuswithGradient(border4, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
            textboxBorderfive.BorderRadiuswithGradient(border5, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
            textboxBordersix.BorderRadiuswithGradient(border6, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);
            textboxBorderseven.BorderRadiuswithGradient(border7, "Salmon", "SaddleBrown", "ForwardDiagonal", 20, false, false, false, false);

        }

       
    }
}
