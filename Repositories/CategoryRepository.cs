using ecomm.api.Data;
using ecomm.api.Data.Interfaces;
using ecomm.api.Model;
using ecomm.api.Repositories.Interfaces;

namespace ecomm.api.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        IUnitOfWork unitOfWork = new DataContext();
  
        public CategoryRepository(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
        }
    }
}