using System.Collections.Generic;
using System.Threading.Tasks;
using INPRO.API.Models;

namespace INPRO.API.Data
{
    public interface IInproRepository
    {
        void Add<T> (T entity) where T: class;
        void Delete<T> (T entity) where T: class;
        Task<bool> SaveAll();  
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
    }
}