using System.Collections.Generic;
using System.Threading.Tasks;
using INPRO.API.Models;

namespace INPRO.API.Data
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int id);
    }
}