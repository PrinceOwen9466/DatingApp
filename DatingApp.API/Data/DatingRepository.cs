using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DatingRepository : IDatingRepository
    {
        #region Properties

        #region Internals
        DataContext Context { get; set; }
        #endregion

        #endregion

        #region Constructors
        public DatingRepository(DataContext context)
        {
            Context = context;
        }
        #endregion

        #region Methods
        
        #region IDatingRepository Implementation
        public void Add<T>(T entity) where T : class
        {
            Context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            Context.Remove(entity);
        }

        public async Task<User> GetUser(int id)
        {
            return await Context.Users.Include(p => p.Photos).FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await Context.Users.Include(p => p.Photos).ToListAsync();
        }

        public async Task<bool> SaveAll()
        {
            return await Context.SaveChangesAsync() > 0;
        }
        #endregion

        #endregion
    }
}