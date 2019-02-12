using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        #region Properties
        
        public DbSet<Value> Values { get; set; }
        #endregion

        #region Constructors
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        #endregion

        #region Methods


        #endregion
    }
}