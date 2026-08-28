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

        #region Smart Product Search


        public static List<Product> SearchProducts(
                 List<Product> products,
                 Func<Product, bool> filter)
        {
            return products.Where(filter).ToList();
        }
        #endregion
        #region 3.1. Print Reports


        public static void PrintReport(List<Product> products, Action<Product> action)
        {
            foreach (Product p in products)
            {
                action(p);
            }

        }
        #endregion
        #region 3.2. Transform Products


        public static List<string> TransformProducts(
        List<Product> products,
        Func<Product, string> transform)
        {
            List<string> result = new List<string>();

            foreach (Product p in products)
            {
                result.Add(transform(p));
            }

            return result;
        }
        #endregion
        # region 3.3. Filter Products
        public static List<Product> FilterProducts(
    List<Product> products,
    Predicate<Product> condition)
        {
            List<Product> result = new List<Product>();

            foreach (Product p in products)
            {
                if (condition(p))
                {
                    result.Add(p);
                }
            }

            return result;
        }
        #endregion
    }
}
