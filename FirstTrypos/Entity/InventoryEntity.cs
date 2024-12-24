using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Entity
{
    public class Product
    {   public int Id { get; set; }
        public byte[] ProductPic { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ProductCategory { get; set; }
        public string ProductQuantity { get; set; }
        public string ProductPrice { get; set; }
        public string UserId { get; set; }
    }

}
