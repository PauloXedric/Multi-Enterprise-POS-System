using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FirstTrypos.Database
{

    public class DatabaseConnection
    {
        public string connectiondb { get; } = "Data Source=localhost\\sqlexpress;Initial Catalog=posdatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public SqlConnection getdbconnection()
        {
            return new SqlConnection(connectiondb);
        }
    }
                
}      
     
    
       
    

