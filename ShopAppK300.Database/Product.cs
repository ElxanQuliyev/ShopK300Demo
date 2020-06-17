using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppK300.Database
{
   public class Product:BaseTable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description{ get; set; }

        public int ThumbnailID { get; set; }

        public Category Category { get; set; }

        public List<ProductToPicture> ProductToPictures { get; set; }
    }
}
