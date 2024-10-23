using ProductApi.Models;

namespace ProductApi.Data
{
    public class SeedData
    {
        public static void Initialize(AppDbContext context)
        {
            if (!context.ProductCategories.Any())
            {
                // Добавляем категории
                var categories = new List<ProductCategory>
                {
                    new ProductCategory { Name = "Electronics", Description = "Electronic devices and gadgets" },
                    new ProductCategory { Name = "Books", Description = "Books of various genres" },
                    new ProductCategory { Name = "Clothing", Description = "Men's and Women's clothing" }
                };

                context.ProductCategories.AddRange(categories);
                context.SaveChanges();
            }

            if (!context.Products.Any())
            {
                // Добавляем продукты
                var products = new List<Product>
                {
                    new Product { Name = "Smartphone", Description = "Latest model smartphone", Price = 699.99M, CategoryId = 1 },
                    new Product { Name = "Laptop", Description = "High performance laptop", Price = 1199.99M, CategoryId = 1 },
                    new Product { Name = "Novel", Description = "Best-selling novel", Price = 14.99M, CategoryId = 2 },
                    new Product { Name = "Jeans", Description = "Comfortable jeans", Price = 49.99M, CategoryId = 3 }
                };

                context.Products.AddRange(products);
                context.SaveChanges();
            }
        }
    }
}
