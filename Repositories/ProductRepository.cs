
using ecomm.api.Data;
using ecomm.api.Data.Interfaces;
using ecomm.api.Model;
using ecomm.api.Repositories.Interfaces;

namespace ecomm.api.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        IUnitOfWork unitOfWork = new DataContext();
  
        public ProductRepository(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
             
        }
    }
}