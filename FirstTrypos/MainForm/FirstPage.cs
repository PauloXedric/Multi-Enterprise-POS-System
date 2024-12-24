using System.Drawing.Drawing2D;
using System.Security.Cryptography.Xml;
using FirstTrypos.Utility;

namespace FirstTrypos
{
    public partial class FirstPage : Form
    {
       

        public FirstPage()
        {
            InitializeComponent();
            FirstPageDesign();
        }

        private void welcomeClick(object sender, EventArgs e)
        {         
            Login login = new Login();
            Visible = false;
            login.Show();
            login.WindowState = FormWindowState.Maximized;
          
        }

        // Page Design
        private void FirstPageDesign() 
        {
            Design buttonone = new Design();
            buttonone.BorderRadiuswithGradient(gotologin, "LightSkyBlue", "RoyalBlue", "ForwardDiagonal", 30, true, true, true, true);
        }
     
    }
}
