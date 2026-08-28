using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment11.Online_Store
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; } // "Electronics", "Clothing", "Food", "Books"
        public double Price { get; set; }
        public int Stock { get; set; }
        public static List<Product> SearchProducts(
                 List<Product> products,
                 Func<Product, bool> filter)
        {
            return products.Where(filter).ToList();
        }
    }
}