using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceProduct : IServiceProduct
    {
        private readonly IProduct _product;
        public ServiceProduct(IProduct product)
        {
            _product = product;
        }  
        public async Task AddProduct(Product product)
        {
            var checkName = product.CheckPropertyString(product.Name, "Name");
            var checkValue = product.CheckPropertyDecimal(product.Value, "Value");

            if (checkName && checkValue)
            {
                product.State = true;
                await _product.Add(product);
            }
        }

        public async Task UpdateProduct(Product product)
        {
            var checkName = product.CheckPropertyString(product.Name, "Name");
            var checkValue = product.CheckPropertyDecimal(product.Value, "Value");

            if (checkName && checkValue)
            {
                await _product.Update(product);
            }
        }
    }
}
