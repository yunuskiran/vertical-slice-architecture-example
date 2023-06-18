

using ECommerce.Core.Features.ProductListing.Contracts;
using ECommerce.Core.Features.ProductListing.Models;

namespace ECommerce.Infrastructure.Data.Repositories;

public class ProductRepository : IProductRepository
{
    private List<Product> products;

    public ProductRepository()
    {
        products = new List<Product>
        {
            new Product { Id = 1, Name = "Product 1", Description = "Description 1", Price = 10.99m },
            new Product { Id = 2, Name = "Product 2", Description = "Description 2", Price = 19.99m },
        };
    }

    public List<Product> GetAllProducts()
    {
        return products;
    }

    public Product GetProductById(int productId)
    {
        return products.FirstOrDefault(p => p.Id == productId);
    }
}
