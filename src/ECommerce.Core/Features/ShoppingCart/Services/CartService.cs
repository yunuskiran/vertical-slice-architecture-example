using ECommerce.Core.Features.Contracts;

public class CartService : ICartService
{
    private readonly IProductService productService;
    private readonly List<CartItem> cartItems;

    public CartService(IProductService productService)
    {
        this.productService = productService;
        cartItems = new List<CartItem>();
    }

    public void AddToCart(int productId)
    {
        var product = productService.GetProductById(productId);
        if (product != null)
        {
            cartItems.Add(new CartItem { Product = product, Quantity = 1 });
        }
    }

    public void RemoveFromCart(int productId)
    {
        var cartItem = cartItems.FirstOrDefault(item => item.Product.Id == productId);
        if (cartItem != null)
        {
            cartItems.Remove(cartItem);
        }
    }

    public List<CartItem> GetCartItems()
    {
        return cartItems;
    }
}
