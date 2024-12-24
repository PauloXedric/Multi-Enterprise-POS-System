using FirstTrypos.Database;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using PointOfSale.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FirstTrypos.DatabaseQuery
{
    internal class UsersQuery
    {   // Content Guide each Line

        //Line 26++ Home.cs
        //Line 64++ Signup.cs
        //Line 125++ Login.cs
        //Line 188++ Settings.cs
        //Line 384++ Pos.cs


        //Home DATABASE QUERY


        // Usage at Home.cs Line 42
        
        public UserInfo Profilepic(string Username)
        {
            try
            {
                UserInfo userinfo = new UserInfo();

                var dbconnection = new DatabaseConnection();
                using (SqlConnection connection = dbconnection.getdbconnection())
                {
                    connection.Open();
                    string query = "SELECT picture FROM Users WHERE enterpriseName = @enterpriseName";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@enterpriseName", Username);

                    cmd.ExecuteScalar();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userinfo.ProfilePicture = reader["picture"] as byte[];
                            return userinfo;
                        }
                    }
                }
                return new UserInfo();
            }
            catch (Exception e)
            { MessageBox.Show("Database ERROR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); throw; }
        }


        //Signup DATABASE QUERY


        // Usage at Signup.cs Line 47  

        public bool CheckUser(string Enterprisename)
        {
            try
            {
                var dbconnection = new DatabaseConnection();
                using (SqlConnection connection = dbconnection.getdbconnection())
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE enterpriseName = @enterpriseName";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@enterpriseName", Enterprisename);

                    int existingaccount = (int)cmd.ExecuteScalar();

                    return existingaccount > 0;
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Database ERROR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
        }


        // Usage at Signup.cs Line 57 

        public bool AddUser(string Enterprisename, string Address, string Firstname, string Lastname, string Password)
        {
            try
            {
                var dbconnection = new DatabaseConnection();
                using (SqlConnection connection = dbconnection.getdbconnection())
                {
                    connection.Open();
                    string query = " INSERT INTO Users(enterpriseName, address, firstName, lastName, password) VALUES(@enterpriseName, @address, @firstName, @lastName, @password)";
                    
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@enterpriseName", Enterprisename);
                        cmd.Parameters.AddWithValue("@address", Address);
                        cmd.Parameters.AddWithValue("@firstName", Firstname);
                        cmd.Parameters.AddWithValue("@lastName", Lastname);
                        cmd.Parameters.AddWithValue("@password", Password);

                       int returnvalue =  cmd.ExecuteNonQuery();

                        return returnvalue > 0;
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Database ERROR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }

        }

   

        // Login DATABASE QUERY


        //Usage at  Login.cs Line 40 / SettingsChangePassword.cs Line 35

        public bool Login(string Enterprisename, string Password)
        {
          try
          {
                var dbconnection = new DatabaseConnection();
                using (SqlConnection connection = dbconnection.getdbconnection())
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE enterpriseName = @enterpriseName AND password = @password";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@enterpriseName", Enterprisename);
                    cmd.Parameters.AddWithValue("@password", Password);

                    int existingaccount = (int)cmd.ExecuteScalar();

                    return existingaccount > 0;
                }
          } 
          catch (Exception e)
          { MessageBox.Show("Database ERROR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;} 
        }


        // Usage at Login.cs Line 41

        public UserInfo GetUserId(string Username)
        {
            try
            {

                UserInfo userinfo = new UserInfo();

                var dbconnection = new DatabaseConnection();
                using (SqlConnection connection = dbconnection.getdbconnection())
                {
                    connection.Open();
                    string query = "SELECT userID FROM Users WHERE enterpriseName = @enterpriseName";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@enterpriseName", Username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userinfo.UserId = reader["userID"].ToString();
                            return userinfo;
                        }
                    }
                    return new UserInfo();
                }
            }
            catch (Exception e)
            { MessageBox.Show("Database ERROR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); throw; }

        }


        //Settings DATABASE QUERY


        // Usage at SettingsUpdateInformation.cs Line 35 / SettingsUserInformation.cs Line 34

        public UserInfo UserInformation(string Username)
        {
            try
            {
                UserInfo user = new UserInfo();

                var dbconnection = new DatabaseConnection();
                using (SqlConnection connection = dbconnection.getdbconnection())
                {
                    connection.Open();
                    string query = "SELECT enterpriseName, address, firstName, lastName, picture, cpnumber, qrcode FROM Users WHERE enterpriseName = @enterpriseName";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@enterpriseName", Username);

                    cmd.ExecuteScalar();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user.EnterpriseName = reader["enterpriseName"].ToString();
                            user.Address = reader["address"].ToString();
                            user.FirstName = reader["firstName"].ToString();
                            user.LastName = reader["lastName"].ToString();
                            user.CpNumber = reader["cpnumber"].ToString();
                            user.ProfilePicture = reader["picture"] as byte[];
                            user.QrCode = reader["qrcode"] as byte[];
                            return user;
                        }
                    }
                }
                return new UserInfo();
            }
            catch (Exception e)
            { 
                MessageBox.Show("Database ERROR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }


        // Usage at SettingUpdateInformation.cs Line 76

        public bool UpdateUserInformation(string Enterprisename, string Address, string Lastname, string Firstname, string Cpnumber, string Username, Image Userpic, Image QrCode)
        {
            try
            {
                var dbconnection = new DatabaseConnection();
                using (SqlConnection connection = dbconnection.getdbconnection())
                {
                    connection.Open();

                    string query = "UPDATE Users SET enterpriseName = @enterpriseName, address = @address, firstName = @firstName, lastName = @lastName, cpnumber = @cpnumber WHERE enterpriseName = @oldenterpriseName";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@enterpriseName", Enterprisename);
                        cmd.Parameters.AddWithValue("@address", Address);
                        cmd.Parameters.AddWithValue("@lastName", Lastname);
                        cmd.Parameters.AddWithValue("@firstName", Firstname);
                        cmd.Parameters.AddWithValue("@cpnumber", Cpnumber);
                        cmd.Parameters.AddWithValue("@oldenterpriseName", Username);

                        int returnvalue = cmd.ExecuteNonQuery();

                        if (returnvalue <= 0)
                        {
                            return false;
                        }
                    }

                    string checkQuery = "SELECT picture, qrcode FROM Users WHERE enterpriseName = @enterpriseName";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@enterpriseName", Username);

                        using (SqlDataReader reader = checkCmd.ExecuteReader())
                        {
                            byte[] existingPicture = null;
                            byte[] existingQrCode = null;

                            if (reader.Read())
                            {
                                existingPicture = reader["picture"] as byte[];
                                existingQrCode = reader["qrcode"] as byte[];
                            }

                            reader.Close();

                            byte[] userPicBytes = null;
                            byte[] qrCodeBytes = null;

                            if (Userpic != null)
                            {
                                using (MemoryStream ms = new MemoryStream())
                                {
                                    Userpic.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                    userPicBytes = ms.ToArray();
                                }
                            }

                            if (QrCode != null)
                            {
                                using (MemoryStream ms = new MemoryStream())
                                {
                                    QrCode.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                    qrCodeBytes = ms.ToArray();
                                }
                            }

                            string imageQuery = "UPDATE Users SET ";
                            bool fieldsToUpdate = false;

                            if (userPicBytes != null || existingPicture != null)  
                            {
                                imageQuery += "picture = @picture, ";
                                fieldsToUpdate = true;
                            }
                            if (qrCodeBytes != null || existingQrCode != null)  
                            {
                                imageQuery += "qrcode = @qrcode, ";
                                fieldsToUpdate = true;
                            }

                            if (fieldsToUpdate)  
                            {
                                imageQuery = imageQuery.TrimEnd(',', ' ');

                                imageQuery += " WHERE enterpriseName = @enterpriseName";

                                using (SqlCommand imageCmd = new SqlCommand(imageQuery, connection))
                                {
                                    imageCmd.Parameters.AddWithValue("@enterpriseName", Username);
                         
                                    if (userPicBytes != null)
                                        imageCmd.Parameters.Add("@picture", SqlDbType.Image).Value = userPicBytes;
                                    else if (existingPicture == null)  
                                        imageCmd.Parameters.Add("@picture", SqlDbType.Image).Value = DBNull.Value;

                                    if (qrCodeBytes != null)
                                        imageCmd.Parameters.Add("@qrcode", SqlDbType.Image).Value = qrCodeBytes;
                                    else if (existingQrCode == null) 
                                        imageCmd.Parameters.Add("@qrcode", SqlDbType.Image).Value = DBNull.Value;

                                    
                                    int imageReturnValue = imageCmd.ExecuteNonQuery();
                                    
                                    if (imageReturnValue > 0)
                                        return true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database ERROR: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return false;
        }


        // Usage at SettingsChangePassword.cs Line 84

        public bool UpdatePassword(string Enterprisename, string Password)
        {
            try
            {
                var dbconnection = new DatabaseConnection();
                using (SqlConnection connection = dbconnection.getdbconnection())
                {
                    connection.Open();
                    string query = "UPDATE Users SET password = @password WHERE enterpriseName = @enterpriseName";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@enterpriseName", Enterprisename);
                    cmd.Parameters.AddWithValue("@password", Password);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception e)
            { MessageBox.Show("Database ERROR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
        }


        //Pos DATABASE QUERY


        // Usage at Pos.cs Line 74

        public UserInfo ShowQrCode(string Userid)
        {
            try
            {
                UserInfo userinfo = new UserInfo();

                var dbconnection = new DatabaseConnection();
                using (SqlConnection connection = dbconnection.getdbconnection())
                {
                    connection.Open();
                    string query = "SELECT qrcode FROM Users WHERE userID = @userID";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@userID", Userid);

                    cmd.ExecuteScalar();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userinfo.QrCode = reader["qrcode"] as byte[];
                            return userinfo;
                        }
                    }
                }
                return new UserInfo();
            }
            catch (Exception e)
            {
                MessageBox.Show("Database ERROR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        // Usage at Pos.cs Line 37

        public UserInfo Receipt(string Username)
        {
            try
            {
                UserInfo user = new UserInfo();

                var dbconnection = new DatabaseConnection();
                using (SqlConnection connection = dbconnection.getdbconnection())
                {
                    connection.Open();
                    string query = "SELECT enterpriseName, address, firstName, lastName, cpnumber  FROM Users WHERE enterpriseName = @enterpriseName";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@enterpriseName", Username);

                    cmd.ExecuteScalar();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user.EnterpriseName = reader["enterpriseName"].ToString();
                            user.Address = reader["address"].ToString();
                            user.FirstName = reader["firstName"].ToString();
                            user.LastName = reader["lastName"].ToString();
                            user.CpNumber = reader["cpnumber"].ToString();                          
                            return user;
                        }
                    }
                }
                return new UserInfo();
            }
            catch (Exception e)
            {
                MessageBox.Show("Database ERROR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }



    }
}
