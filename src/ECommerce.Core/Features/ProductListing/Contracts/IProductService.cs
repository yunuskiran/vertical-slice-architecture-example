
using ECommerce.Core.Features.ProductListing.Models;

namespace ECommerce.Core.Features.Contracts;

public interface IProductService
{
    List<Product> GetProducts();
    Product GetProductById(int productId);
}
