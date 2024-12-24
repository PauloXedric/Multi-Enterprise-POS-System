using FirstTrypos.Database;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using PointOfSale.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTrypos.DatabaseQuery
{
    internal class InventoryQuery
    {
     //Content Guide for each Line

     //Line 23++ Inventory.cs
     //Line 245++ inventoryupdate.cs

        
        //Inventory DATABASE QUERY


        //Usage at Inventory.cs Line 58

        public DataTable InventoryPageTable(string Userid) 
        {
            DataTable inventorytable = new DataTable();

            try
            {
                var dbconnection = new DatabaseConnection();
                using (SqlConnection connection = dbconnection.getdbconnection())
                {
                    connection.Open();
                    string query = "SELECT ProductPic, ProductName, ProductCategory, ProductQuantity, ProductPrice FROM Inventories WHERE UserID = @UserID";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@UserID", Userid);

                    cmd.ExecuteScalar();

                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);                                
                    adapt.Fill(inventorytable);

                }
            }
            catch (Exception e)
            { MessageBox.Show("Database ERROR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
         return inventorytable;
        }


        //Usage at Inventory.cs Line 126

        public Product ProductSearching(string Productname, string Userid)
        {
            try
            {
                Product product = null;

                var dbconnection = new DatabaseConnection();
                using (SqlConnection connection = dbconnection.getdbconnection())
                {
                    connection.Open();

                    string query = "SELECT ProductCode, ProductCategory, ProductPrice, ProductPic FROM Inventories WHERE ProductName = @ProductName AND UserID = @UserID";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@ProductName", Productname);
                    cmd.Parameters.AddWithValue("@UserID", Userid);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())  
                        {                           
                            product = new Product
                            {
                                ProductCode = reader["ProductCode"].ToString(),
                                ProductCategory = reader["ProductCategory"].ToString(),
                                ProductPrice = reader["ProductPrice"].ToString(),
                                ProductPic = reader["ProductPic"] as byte[] 
                            };
                        }
                    }
                }
                return product;
            }
            catch (Exception e)
            {
                MessageBox.Show("Database ERROR: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; 
            }
        }



        //ColumnName for Database Table named InventoryPos
        //ProductName for Name of Product
        //ProductCode for Name of Product Code

        //Usage at Inventory.cs Line 197, 207

        public bool CheckExistingProduct(string Productcode, string Userid, string ColumnName)
        {
            try
            {
                var dbconnection = new DatabaseConnection();
                using (SqlConnection connection = dbconnection.getdbconnection())
                {
                    connection.Open();
                    string query = $"SELECT COUNT(*) FROM Inventories WHERE {ColumnName} = @ColumnName AND UserID = @UserID";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@ColumnName", Productcode);
                    cmd.Parameters.AddWithValue("@UserID", Userid);

                    int existingaccount = (int)cmd.ExecuteScalar();

                    return existingaccount > 0;
                }
            }
            catch (Exception ex)
            {
              MessageBox.Show("Database ERROR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
              return false; 
            }
        }


        //Usage at Inventory.cs Line 217

        public bool AddProduct(Image Productpic, string Productname, string Productcode, string Productcategory, string Productquantity, string Productprice, string Userid)
        {
            try
            {
                var dbconnection = new DatabaseConnection();
                using (SqlConnection connection = dbconnection.getdbconnection())
                {
                    connection.Open();
                    string query = "INSERT INTO Inventories (ProductPic, ProductName, ProductCode, ProductCategory, ProductQuantity, ProductPrice,UserID) VALUES (@ProductPic, @ProductName, @ProductCode, @ProductCategory, @ProductQuantity, @ProductPrice,@UserID)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        byte[] NewProductPic;
                        using (MemoryStream ms = new MemoryStream())
                        {
                            Productpic.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            NewProductPic = ms.ToArray();
                        }
                        cmd.Parameters.AddWithValue("@ProductPic", NewProductPic);
                        cmd.Parameters.AddWithValue("@ProductName", Productname);
                        cmd.Parameters.AddWithValue("@ProductCode", Productcode);
                        cmd.Parameters.AddWithValue("@ProductCategory", Productcategory);
                        cmd.Parameters.AddWithValue("@ProductQuantity", Productquantity);
                        cmd.Parameters.AddWithValue("@ProductPrice", Productprice);
                        cmd.Parameters.AddWithValue("@UserID", Userid);
                        int returnvalue = cmd.ExecuteNonQuery();

                        return returnvalue > 0;
                    }
                }
            }
            catch (Exception ex)
            {
             MessageBox.Show("Database ERROR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
            }
        }


        //Usage at Inventory.cs Line 237 

        public Product GetCurrentStocks(string Productname, string Userid)
        {
            try
            {
                Product product = new Product();

                var dbconnection = new DatabaseConnection();
                using (SqlConnection connection = dbconnection.getdbconnection())
                {
                    connection.Open();
                    string query = "SELECT ProductQuantity FROM Inventories WHERE ProductName = @ProductName AND UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", Productname);
                        cmd.Parameters.AddWithValue("@UserID", Userid);

                        cmd.ExecuteScalar();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                product.ProductQuantity = reader["ProductQuantity"].ToString();
                                return product;
                            }
                        } return new Product();
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Database ERROR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
              throw; }
        }


        //Usage at Inventory.cs Line 248

        public bool UpdateProductStocks(string Productname, string Userid, string Productquantity)
        {
            try
            {
                var dbconnection = new DatabaseConnection();
                using (SqlConnection connection = dbconnection.getdbconnection())
                {
                    connection.Open();
                    string query = "UPDATE Inventories SET ProductQuantity = @ProductQuantity WHERE ProductName = @ProductName AND UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", Productname);
                        cmd.Parameters.AddWithValue("@UserID", Userid);
                        cmd.Parameters.AddWithValue("@ProductQuantity", Productquantity);

                        int returnvalue = cmd.ExecuteNonQuery();

                        return returnvalue > 0;
                    }
                }
            }
            catch (Exception ex)
            { 
             MessageBox.Show("Database ERROR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
             return false; 
            }

        }


        //inventoryupdate DATABASE QUERY


        //Usage at inventoryupdate.cs Line 44

        public Product FillShowProductToUpdate(string Productname, string Userid)
        {
            try
            {
                Product product = new Product();  

                var dbconnection = new DatabaseConnection();
                using (SqlConnection connection = dbconnection.getdbconnection())
                {
                    connection.Open();
                    string query = "SELECT ProductPic, ProductName, ProductCode, ProductCategory, ProductQuantity, ProductPrice FROM Inventories WHERE UserID = @UserID AND ProductName = @ProductName";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@UserID", Userid);
                    cmd.Parameters.AddWithValue("@ProductName", Productname);

                    cmd.ExecuteScalar();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            product.ProductPic = (byte[])reader["ProductPic"];
                            product.ProductName = reader["ProductName"].ToString();
                            product.ProductCode = reader["ProductCode"].ToString();
                            product.ProductCategory = reader["ProductCategory"].ToString();
                            product.ProductQuantity = reader["ProductQuantity"].ToString();
                            product.ProductPrice = reader["ProductPrice"].ToString();
                            return product;
                        }
                    }
                    return new Product();
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Database ERROR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  throw; }
        }


        //Usage at inventoryupdate.cs Line 71

        public bool UpdateProductInformation(Image Productpic, string Oldproductname, string Productname, string Productcode, string Productcategory, string Productquantity, string Productprice, string Userid)
        {
            try
            {
                var dbconnection = new DatabaseConnection();
                using (SqlConnection connection = dbconnection.getdbconnection())
                {
                    connection.Open();
                    string query = "UPDATE Inventories SET ProductPic = @ProductPic, ProductName = @ProductName, ProductCode = @ProductCode, ProductCategory = @ProductCategory, ProductQuantity = @ProductQuantity, ProductPrice = @ProductPrice WHERE ProductName = @OldProductName AND UserID = @UserID";

                    byte[] productpic;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        Productpic.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        productpic = ms.ToArray();
                    }

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ProductPic", productpic);
                        cmd.Parameters.AddWithValue("@ProductName", Productname);
                        cmd.Parameters.AddWithValue("@ProductCode", Productcode);
                        cmd.Parameters.AddWithValue("@ProductCategory", Productcategory);
                        cmd.Parameters.AddWithValue("@ProductQuantity", Productquantity);
                        cmd.Parameters.AddWithValue("@ProductPrice", Productprice);
                        cmd.Parameters.AddWithValue("@OldProductName", Oldproductname);
                        cmd.Parameters.AddWithValue("@UserID", Userid);

                        int returnvalue = cmd.ExecuteNonQuery();

                        return returnvalue > 0;
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Database ERROR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
        }


        //Usage at inventoryupdate.cs Line 91

        public bool DeleteProductInformation(string Productname, string Userid)
        {
            try
            {
                var dbconnection = new DatabaseConnection();
                using (SqlConnection connection = dbconnection.getdbconnection())
                {
                    connection.Open();
                    string query = "DELETE FROM Inventories WHERE ProductName = @ProductName AND UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", Productname);
                        cmd.Parameters.AddWithValue("@UserID", Userid);

                        int returnvalue = cmd.ExecuteNonQuery();

                        return returnvalue > 0;
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Database ERROR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
        }

    }
}
