public interface ICartService
{
    void AddToCart(int productId);
    void RemoveFromCart(int productId);
    List<CartItem> GetCartItems();
}
