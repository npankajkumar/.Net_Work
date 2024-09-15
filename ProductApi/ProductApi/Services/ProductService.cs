using ProductApi.Models;

namespace ProductApi.Services
{
    public class ProductService : IProductService
    {
        private readonly ProductContext _context = new ProductContext();
        public List<Product> GetProducts()
        {

            return _context.Products.ToList();

        }
        public bool AddProduct(Product p)
        {
            _context.Products.Add(p);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateProduct(int id, Product p)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                product.Name = p.Name;
                product.Price = p.Price;
                product.Image = p.Image;
                product.StoreId = p.StoreId;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool DeleteProduct(int id)
        {

            var p = _context.Products.Find(id);
            if (p != null)
            {
                _context.Products.Remove(p);
                _context.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
