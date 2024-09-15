using ProductApi.Models;

namespace ProductApi.Services
{
    public interface IProductService
    {
        bool AddProduct(Product p);
        bool DeleteProduct(int id);
        List<Product> GetProducts();
        bool UpdateProduct(int id, Product p);
    }
}