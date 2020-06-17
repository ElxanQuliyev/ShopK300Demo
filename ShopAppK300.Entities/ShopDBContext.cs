using ShopAppK300.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppK300.Entities
{
    class ShopDBContext : DbContext
    {
        public ShopDBContext():base("ShopDBConnection")// Base Valideyn 
        {}
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Picture> Pictures{ get; set; }

    }
}
