using FirstTrypos.Database;
using FirstTrypos.Utility;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTrypos.DatabaseQuery
{
    internal class PosQuery
    {
      // Content Guide for each Line 
     
      //Line 20++ Pos.cs 


        //Pos DATABASE QUERY


        // Usage at Pos.cs Line 95

        public DataTable PosPageTable(string Userid)
        {
            DataTable inventorytable = new DataTable();

            try
            {
                var dbconnection = new DatabaseConnection();
                using (SqlConnection connection = dbconnection.getdbconnection())
                {
                    connection.Open();
                    string query = "SELECT ProductPic, ProductName, ProductPrice FROM Inventories WHERE UserID = @UserID";
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


    }
}
