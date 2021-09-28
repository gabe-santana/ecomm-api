using ecomm.api.Data.Interfaces;
using ecomm.api.Model;
using Microsoft.EntityFrameworkCore;

namespace ecomm.api.Data
{
    public class DataContext : DbContext, IUnitOfWork
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public void Save()
            =>  base.SaveChanges();
    }
}