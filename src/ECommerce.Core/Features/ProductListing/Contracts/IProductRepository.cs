using ECommerce.Core.Features.ProductListing.Models;

namespace ECommerce.Core.Features.ProductListing.Contracts;

public interface IProductRepository
{
    List<Product> GetAllProducts();
    Product GetProductById(int productId);
}