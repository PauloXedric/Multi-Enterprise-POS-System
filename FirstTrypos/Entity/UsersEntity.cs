using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Entity
{

    public class UserInfo
    {
        public string EnterpriseName { get; set; }
        public string Address { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CpNumber { get; set; }
        public byte[] ProfilePicture { get; set; }
        public byte[] QrCode { get; set; }
        public string UserId { get; set; }
    }
}
