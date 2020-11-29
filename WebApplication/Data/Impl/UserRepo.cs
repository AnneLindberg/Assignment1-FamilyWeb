using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Models;
using WebApplication.DataAccess;

namespace AdultService
{
    public class UserRepo : IUserService
    {
        private AdultDBContext dbContext;

        public UserRepo(AdultDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<User> ValidateUser(string userName, string password)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IList<User>> GetUsersAsync()
        {
            return await dbContext.Users.ToListAsync();
        }

        public async Task<User> AddUserAsync(User user)
        {
            EntityEntry<User> newlyAdded = await dbContext.Users.AddAsync(user);
            await dbContext.SaveChangesAsync();
            return newlyAdded.Entity;
        }
    }
}