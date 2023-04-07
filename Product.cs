using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    public class Product
    {
        [Key]
        public int IProductId { get; set; }
        public string ProductName { get; set; }
        public string Descriptions { get; set; }
        public int Price { get; set; }
        public bool Discontinued { get; set; }
    }
}
