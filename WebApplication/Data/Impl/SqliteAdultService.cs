using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FamilyWeb1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Models;
using WebApplication.DataAccess;

namespace AdultService
{
    public class SqliteAdultService : IAdultService
    {

        private AdultDBContext _adultDbContext;

        public SqliteAdultService(AdultDBContext adultDbContext)
        {
            _adultDbContext = adultDbContext;
        }

        public async Task<IList<Adult>> GetAdultsAsync()
        {
            return await _adultDbContext.Adults.ToListAsync();
        }
        
        public async Task<Adult> AddAdultAsync(Adult adult)
        {
            EntityEntry<Adult> newlyAdded = await _adultDbContext.Adults.AddAsync(adult);
            await _adultDbContext.SaveChangesAsync();
            return newlyAdded.Entity;
        }

        public Task RemoveAdultAsync(Adult adult)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Adult adult)
        {
            throw new System.NotImplementedException();
        }
    }
}