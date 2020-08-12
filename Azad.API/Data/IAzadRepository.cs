using System.Collections.Generic;
using System.Threading.Tasks;
using Azad.API.Models;

namespace Azad.API.Data
{
    public interface IAzadRepository
    {
        void Add<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        Task<bool> SaveAll();
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
        Task<Photo> GetPhoto(int id);
    }
}