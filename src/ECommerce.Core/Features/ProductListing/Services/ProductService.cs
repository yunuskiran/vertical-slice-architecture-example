using ECommerce.Core.Features.Contracts;
using ECommerce.Core.Features.ProductListing.Contracts;
using ECommerce.Core.Features.ProductListing.Models;

public class ProductService : IProductService
{
    private readonly IProductRepository productRepository;

    public ProductService(IProductRepository productRepository)
    {
        this.productRepository = productRepository;
    }

    public List<Product> GetProducts()
    {
        return productRepository.GetAllProducts();
    }

    public Product GetProductById(int productId)
    {
        return productRepository.GetProductById(productId);
    }
}
