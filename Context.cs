using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace Products
{
    public class Context:DbContext
    {
        public Context():base("sqlim")
        {
            
        }

        public DbSet<Product> Productlar { get; set; }
    }
}
