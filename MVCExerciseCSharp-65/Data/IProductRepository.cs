using MVCExerciseCSharp_65.Models;

namespace MVCExerciseCSharp_65.Data;

public interface IProductRepository
{
    public IEnumerable<Product> GetAllProducts();
    public Product GetProduct(int id);
    void UpdateProduct(Product product);
}