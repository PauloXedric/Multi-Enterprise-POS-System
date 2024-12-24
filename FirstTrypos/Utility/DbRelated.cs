using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTrypos.Utility
{
    public class DbRelated
    {
        public string EnterpriseName { get; set; }
        public string ProductName { get; set; }
        public string UserId { get; set; }


        public void SetEnterpriseName(string enterpriseName)
        {
            EnterpriseName = enterpriseName;
        }


        public void SetUserId(string userid) 
        {
            UserId = userid;
        }


        public void SetProductValue(string Userid, string nameofproduct)
        {
            UserId = Userid;
            ProductName = nameofproduct;
        }


    }
}
