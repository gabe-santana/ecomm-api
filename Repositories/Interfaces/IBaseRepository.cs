using System.Collections.Generic;
using System.Threading.Tasks;

namespace ecomm.api.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task Delete(T entity);
    }
}