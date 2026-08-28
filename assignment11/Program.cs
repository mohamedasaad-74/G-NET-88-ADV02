using assignment11.Online_Store;

namespace assignment11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> catalog = new()
{
    new Product { Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10 },
    new Product { Id=2, Name="Phone", Category="Electronics", Price=800, Stock=25 },
    new Product { Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
    new Product { Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
    new Product { Id=5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
    new Product { Id=6, Name="Coffee Beans", Category="Food", Price=15, Stock=80 },
    new Product { Id=7, Name="C# Book", Category="Books", Price=45, Stock=30 },
    new Product { Id=8, Name="Novel", Category="Books", Price=20, Stock=60 },
    new Product { Id=9, Name="Headphones", Category="Electronics", Price=150, Stock=40 },
    new Product { Id=10, Name="Jacket", Category="Clothing", Price=120, Stock=15 }
};

            #region Task 01 : Smart Product Search




            //List<Product> electronics = Product.SearchProducts(catalog, p => p.Category == "Electronics");

            //List<Product> cheaperThan50 = Product.SearchProducts(catalog, p => p.Price < 50);

            //List<Product> inStock = Product.SearchProducts(catalog, p => p.Stock > 0);

            //List<Product> clothingUnder100 = Product.SearchProducts(catalog, p => p.Category == "Clothing" && p.Price < 100);


            //foreach (Product p in electronics)
            //{
            //    Console.WriteLine($"Name: {p.Name}, Price: {p.Price}, Stock: {p.Stock}");
            //}

            //foreach (Product p in cheaperThan50)
            //{
            //    Console.WriteLine($"Name: {p.Name}, Price: {p.Price}, Stock: {p.Stock}");
            //}

            //foreach (Product p in inStock)
            //{
            //    Console.WriteLine($"Name: {p.Name}, Price: {p.Price}, Stock: {p.Stock}");
            //}

            //foreach (Product p in clothingUnder100)
            //{
            //    Console.WriteLine($"Name: {p.Name}, Price: {p.Price}, Stock: {p.Stock}");
          
            //}
            #endregion

        }

    }
}