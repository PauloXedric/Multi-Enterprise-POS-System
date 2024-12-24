using FirstTrypos;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Utility
{
    internal class Receipt
    {
        public void ReceiptSlip(DataGridView Table, TextBox Amount, TextBox Name, TextBox Address, string EnterpriseR, string AddressR, string CpnumberR, string FirstR, string LastR, string ModeofPayment) 
        {   
            int receiptWidth = 400;
            int rowHeight = 40;
            int headerHeight = 220;
            int footerHeight = 350;
            int totalHeight = headerHeight + footerHeight + (Table.RowCount * rowHeight);

            using (Bitmap receiptBitmap = new Bitmap(receiptWidth, totalHeight))
            {
                using (Graphics graphics = Graphics.FromImage(receiptBitmap))
                {
                    Font headerFont = new Font("Arial", 14, FontStyle.Bold);
                    Font bodyFont = new Font("Arial", 12, FontStyle.Regular);
                    Font footerFont = new Font("Arial", 12, FontStyle.Bold);
                    Font Cashfont = new Font("Arial", 16, FontStyle.Bold);
                    Font Developer = new Font("Arial", 10, FontStyle.Regular);
                    Brush textBrush = Brushes.Black;

                    graphics.FillRectangle(Brushes.White, 0, 0, receiptWidth, totalHeight);

                    //Header
                    string ename = EnterpriseR;
                    string address = AddressR;
                    string cpnum = CpnumberR;
                    string cashier = $"{FirstR} {LastR}";
                    string currentDate = DateTime.Now.ToString("MM/dd/yyyy");
                    string currentTime = DateTime.Now.ToString("HH:mm:ss");

                    SizeF textSize = graphics.MeasureString(ename, headerFont);
                    SizeF addressSize = graphics.MeasureString(address, bodyFont);
                    SizeF cpnumSize = graphics.MeasureString(cpnum, bodyFont);
                    SizeF cashierLabelSize = graphics.MeasureString("Cashier: ", bodyFont);
                    SizeF cashierSize = graphics.MeasureString(cashier, bodyFont);
                    SizeF dateSize = graphics.MeasureString(currentDate, bodyFont);
                    SizeF timeSize = graphics.MeasureString(currentTime, bodyFont);

                    float centerX = (receiptWidth - textSize.Width) / 2;

                    graphics.DrawString(address, bodyFont, textBrush, new PointF((receiptWidth - addressSize.Width) / 2, 40));
                    graphics.DrawString(cpnum, bodyFont, textBrush, new PointF((receiptWidth - cpnumSize.Width) / 2, 70));
                    graphics.DrawString(ename, headerFont, textBrush, new PointF(centerX, 10));
                    graphics.DrawString("Cashier: ", bodyFont, textBrush, new PointF(10, 120));
                    graphics.DrawString(cashier, bodyFont, textBrush, new PointF(5 + cashierLabelSize.Width, 120));
                    graphics.DrawString(currentDate, bodyFont, textBrush, new PointF(10, 150));
                    graphics.DrawString(currentTime, bodyFont, textBrush, new PointF(160 + dateSize.Width + 10, 150));



                    //Body
                    graphics.DrawLine(Pens.Black, 10, headerHeight - 40, receiptWidth - 10, headerHeight - 40);
                    graphics.DrawString("Item", bodyFont, textBrush, new PointF(10, headerHeight - 30));
                    graphics.DrawString("Qty", bodyFont, textBrush, new PointF(200, headerHeight - 30));
                    graphics.DrawString("Price", bodyFont, textBrush, new PointF(300, headerHeight - 30));

                    int currentY = headerHeight;
                    foreach (DataGridViewRow row in Table.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string item = row.Cells["ordername"].Value?.ToString() ?? string.Empty;
                        string qty = row.Cells["orderquantity"].Value?.ToString() ?? "0";
                        string price = row.Cells["orderprice"].Value?.ToString() ?? "0.00";

                        graphics.DrawString(item, bodyFont, textBrush, new PointF(10, currentY));
                        graphics.DrawString(qty, bodyFont, textBrush, new PointF(200, currentY));
                        graphics.DrawString(price, bodyFont, textBrush, new PointF(300, currentY));

                        currentY += rowHeight;
                    }

                    decimal total = 0;
                    foreach (DataGridViewRow row in Table.Rows)
                    {
                        if (row.IsNewRow) continue;
                        string qtyString = row.Cells["orderquantity"].Value?.ToString() ?? "0";
                        string priceString = row.Cells["orderprice"].Value?.ToString() ?? "0.00";

                        decimal qty = 0;
                        decimal price = 0;

                        if (decimal.TryParse(qtyString, out qty) && decimal.TryParse(priceString, out price))
                        { 
                            decimal rowTotal = qty * price;
                            total += rowTotal;
                        }
                      
                    }
                    decimal cash = 0;
                    if (!decimal.TryParse(Amount.Text, out cash))
                    {
                        MessageBox.Show("Please enter a valid cash amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    decimal change = cash - total;
                    string footerText = $"Total: {total:C}";
                    string cashText = $"{ModeofPayment}: {cash:C}";
                    string changeText = $"Change: {change:C}";

                    graphics.DrawLine(Pens.Black, 10, totalHeight - footerHeight, receiptWidth - 10, totalHeight - footerHeight);
                    graphics.DrawString(footerText, Cashfont, textBrush, new PointF(10, totalHeight - footerHeight + 20));
                    graphics.DrawString(cashText, headerFont, textBrush, new PointF(10, totalHeight - footerHeight + 50));
                    graphics.DrawLine(Pens.Black, 10, totalHeight - footerHeight + 80, receiptWidth - 10, totalHeight - footerHeight + 80);
                    graphics.DrawString(changeText, Cashfont, textBrush, new PointF(10, totalHeight - footerHeight + 80));

                    //Footer
                    string customerNameLabel = "Customer Name:";
                    string customerAddressLabel = "Customer Address:";

                    string customerName = string.IsNullOrWhiteSpace(Name.Text)
                        ? "N/A"
                        : Name.Text;
                    string customerAddress = string.IsNullOrWhiteSpace(Address.Text)
                        ? "N/A"
                        : Address.Text;
                    string developer = "POS DEVELOPER:";
                    string developer1 = "PAULO XEDRIC SOLTES LOZANO";
                    string developer2 = "Frontend: C# WinForms";
                    string developer3 = "Database: Microsoft SQL Server";
                    string developer4 = "Date Completed: 23/DEC/2024";

                    float spaceAbove = 20;
                    graphics.DrawString(customerNameLabel, bodyFont, textBrush, new PointF(10, totalHeight - footerHeight + 120 + spaceAbove));
                    graphics.DrawString(customerName, bodyFont, textBrush, new PointF(170, totalHeight - footerHeight + 120 + spaceAbove));
                    graphics.DrawString(customerAddressLabel, bodyFont, textBrush, new PointF(10, totalHeight - footerHeight + 150 + spaceAbove));
                    graphics.DrawString(customerAddress, bodyFont, textBrush, new PointF(195, totalHeight - footerHeight + 150 + spaceAbove));

                    float spaceBetween = 40;
                    graphics.DrawString(developer, footerFont, textBrush, new PointF(10, totalHeight - footerHeight + 180 + spaceAbove + spaceBetween));
                    graphics.DrawString(developer1, Developer, textBrush, new PointF(10, totalHeight - footerHeight + 200 + spaceAbove + spaceBetween));
                    graphics.DrawString(developer2, Developer, textBrush, new PointF(10, totalHeight - footerHeight + 218 + spaceAbove + spaceBetween));
                    graphics.DrawString(developer3, Developer, textBrush, new PointF(10, totalHeight - footerHeight + 236 + spaceAbove + spaceBetween));
                    graphics.DrawString(developer4, Developer, textBrush, new PointF(10, totalHeight - footerHeight + 254 + spaceAbove + spaceBetween));

                }

                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Receipt_POS.png");
                receiptBitmap.Save(filePath, ImageFormat.Png);
                
                MessageBox.Show($"Receipt saved successfully at: {filePath}", "Receipt Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Table.Rows.Clear();
            }
        }
    }
}
