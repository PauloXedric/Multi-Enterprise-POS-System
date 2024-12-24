using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstTrypos.Utility
{



    internal class Design
    {

        bool topLeft, topRight;
        bool bottomLeft, bottomRight;

        private Control ControltoDesign;
        private int ControlRadius;
        private string ControlColor = "",
                       color1 = "",//For Gradient
                       color2 = "";//For Gradient
        private string GradientMode = "";




        public void BorderRadiuswithColor(Control control, string color, int radius, bool topLeft, bool topRight, bool bottomLeft, bool bottomRight)
        {
            ControltoDesign = control;
            ControlRadius = radius;
            ControlColor = color;

            this.topLeft = topLeft;
            this.topRight = topRight;
            this.bottomRight = bottomRight;
            this.bottomLeft = bottomLeft;

            ControltoDesign.Paint += BRCvalue;
        }

        private void BRCvalue(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (sender is Control ControltoDesign)
            {
                ControltoDesign.BackColor = Color.Transparent;
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.StartFigure();

                    if (topLeft)
                    {
                        path.AddArc(0, 0, ControlRadius, ControlRadius, 180, 90);
                    }
                    else
                    {
                        path.AddLine(0, 0, ControlRadius, 0);
                    }

                    path.AddLine(ControlRadius, 0, ControltoDesign.Width - (topRight ? ControlRadius : 0), 0);

                    if (topRight)
                    {
                        path.AddArc(ControltoDesign.Width - ControlRadius, 0, ControlRadius, ControlRadius, 270, 90);
                    }
                    else
                    {
                        path.AddLine(ControltoDesign.Width, 0, ControltoDesign.Width, ControlRadius);
                    }

                    path.AddLine(ControltoDesign.Width, ControlRadius, ControltoDesign.Width, ControltoDesign.Height - (bottomRight ? ControlRadius : 0));

                    if (bottomRight)
                    {
                        path.AddArc(ControltoDesign.Width - ControlRadius, ControltoDesign.Height - ControlRadius, ControlRadius, ControlRadius, 0, 90);
                    }
                    else
                    {
                        path.AddLine(ControltoDesign.Width, ControltoDesign.Height, ControltoDesign.Width - ControlRadius, ControltoDesign.Height);
                    }

                    path.AddLine(ControltoDesign.Width - ControlRadius, ControltoDesign.Height, bottomLeft ? ControlRadius : 0, ControltoDesign.Height);

                    if (bottomLeft)
                    {
                        path.AddArc(0, ControltoDesign.Height - ControlRadius, ControlRadius, ControlRadius, 90, 90);
                    }
                    else
                    {
                        path.AddLine(0, ControltoDesign.Height, 0, ControltoDesign.Height - ControlRadius);
                    }

                    path.AddLine(0, ControltoDesign.Height - ControlRadius, 0, ControlRadius);

                    path.CloseFigure();


                    //Set Button Customization
                    if (sender is Button button)
                    {
                        AllowButtonCustomization(button);
                    }


                    using (SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml(ControlColor)))
                    {
                        e.Graphics.FillPath(brush, path);
                    }
                    TextRenderer.DrawText(e, ControltoDesign.Text, ControltoDesign.Font, ControltoDesign.ClientRectangle, ControltoDesign.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }
            }
        }



        public void BorderRadiuswithGradient(Control control, string colorv1, string colorv2, string gmode, int radius, bool topLeft, bool topRight, bool bottomLeft, bool bottomRight)
        {
            ControltoDesign = control;
            ControlRadius = radius;
            color1 = colorv1;
            color2 = colorv2;
            GradientMode = gmode;

            this.topLeft = topLeft;
            this.topRight = topRight;
            this.bottomLeft = bottomLeft;
            this.bottomRight = bottomRight;

            ControltoDesign.Paint += BRGvalue;
        }
       
        private void BRGvalue(object sender, PaintEventArgs e)
        {
            ControltoDesign.BackColor = Color.Transparent;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.StartFigure();


                if (topLeft)
                {
                    path.AddArc(0, 0, ControlRadius, ControlRadius, 180, 90);
                }
                else
                {
                    path.AddLine(0, 0, ControlRadius, 0);
                }
                path.AddLine(ControlRadius, 0, ControltoDesign.Width - (topRight ? ControlRadius : 0), 0);

                if (topRight)
                {
                    path.AddArc(ControltoDesign.Width - ControlRadius, 0, ControlRadius, ControlRadius, 270, 90);
                }
                else
                {
                    path.AddLine(ControltoDesign.Width, 0, ControltoDesign.Width, ControlRadius);
                }


                path.AddLine(ControltoDesign.Width, ControlRadius, ControltoDesign.Width, ControltoDesign.Height - (bottomRight ? ControlRadius : 0));


                if (bottomRight)
                {
                    path.AddArc(ControltoDesign.Width - ControlRadius, ControltoDesign.Height - ControlRadius, ControlRadius, ControlRadius, 0, 90);
                }
                else
                {
                    path.AddLine(ControltoDesign.Width, ControltoDesign.Height, ControltoDesign.Width - ControlRadius, ControltoDesign.Height);
                }

                path.AddLine(ControltoDesign.Width - ControlRadius, ControltoDesign.Height, bottomLeft ? ControlRadius : 0, ControltoDesign.Height);

                if (bottomLeft)
                {
                    path.AddArc(0, ControltoDesign.Height - ControlRadius, ControlRadius, ControlRadius, 90, 90);
                }
                else
                {
                    path.AddLine(0, ControltoDesign.Height, 0, ControltoDesign.Height - ControlRadius);
                }

                path.AddLine(0, ControltoDesign.Height - ControlRadius, 0, ControlRadius);

                path.CloseFigure();


                //Set Button Customization
                if (sender is Button button)
                {
                    AllowButtonCustomization(button);
                }

                LinearGradientMode gradientMode = GetGradientMode(GradientMode);


                using (LinearGradientBrush brush = new LinearGradientBrush(ControltoDesign.ClientRectangle,
                                                                           ColorTranslator.FromHtml(color1),
                                                                           ColorTranslator.FromHtml(color2),
                                                                           gradientMode))
                {
                    e.Graphics.FillPath(brush, path);
                }
                TextRenderer.DrawText(e, ControltoDesign.Text, ControltoDesign.Font, ControltoDesign.ClientRectangle, ControltoDesign.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }
        private LinearGradientMode GetGradientMode(string mode)
        {
            return mode.ToLower() switch
            {
                "ForwardDiagonal" => LinearGradientMode.ForwardDiagonal,
                "BackwardDiagonal" => LinearGradientMode.BackwardDiagonal,
                "Horizontal" => LinearGradientMode.Horizontal,
                "Vertical" => LinearGradientMode.Vertical,
                _ => LinearGradientMode.Vertical,
            };
        }



        //other customization
        //
        //Set Button Flat Apperance to FLAT 
        private void AllowButtonCustomization(Button button)
        {
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

      
    }
}
