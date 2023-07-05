using ECommerce.API.Models;

namespace ECommerce.API.DataAccess
{
    public interface IDataAccess
    {
        List<ProductCategory> GetProductCategories();
        ProductCategory GetProductCategory(int id);
        Offer GetOffer(int id);
        List<Product> GetProducts(string category, string subcategory, int count);

        Product GetProduct(int id);
        bool InsertUser(User user);
        string LoginUser(string email, string password);
        void InsertReview(Review review);
        List<Review> GetProductReviews(int productId);
        User GetUser(int id);
        bool InsertCartItem(int userId, int productId);
        Cart GetActiveCartofUser(int userId);
        Cart GetCart(int cartId);
        List<Cart> GetAllPreviousCartofUser(int userId);

        List<PaymentMethod> GetPaymentMethods();

        int InsertOrder(Order order);
        int InsertPayment(Payment payment);
    }
}
