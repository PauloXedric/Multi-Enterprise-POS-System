using FirstTrypos.DatabaseQuery;
using FirstTrypos.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.Controls
{
    public partial class SettingsUserInformation : UserControl
    {
        private DbRelated transferName;
        private string usernamebased;
        public SettingsUserInformation(DbRelated Namevalue)
        {
            InitializeComponent();
            SettingsUserInformationDesign();

            transferName = Namevalue;
            usernamebased = transferName.EnterpriseName;

        }


        private void SettingsUserInformation_Load(object sender, EventArgs e)
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


        // Page Design
        private void SettingsUserInformationDesign()
        {
            Design panelone = new Design();
            Design paneltwo = new Design();

            Design textboxBorderone = new Design();
            Design textboxBordertwo = new Design();
            Design textboxBorderthree = new Design();
            Design textboxBorderfour = new Design();
            Design textboxBorderfive = new Design();
            Design textboxBordersix = new Design();
            Design textboxBorderseven = new Design();

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
