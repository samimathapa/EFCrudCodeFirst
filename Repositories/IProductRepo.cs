using EFCoreCodeFirstCrudApp.Models;

namespace EFCoreCodeFirstCrudApp.Repositories
{
    public interface IProductRepo
    {
        void AddProduct(Product product);
        IEnumerable<Product> GetAllProducts();
        Product GetProductDetail(int id);
        Product EditProduct(Product p);
        Product DeleteProduct(int id);
    }
}
