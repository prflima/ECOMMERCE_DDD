using Entities.Entities;
using System.Threading.Tasks;

namespace ApplicationApp.Interfaces
{
    public interface IProductApp : IGenericApp<Product>
    {
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);    
    }
}
