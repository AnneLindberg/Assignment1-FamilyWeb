using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace FamilyWeb1.Data
{
    public interface IAdultService
    {
        Task<IList<Adult>> GetAdultsAsync();
        Task <Adult>AddAdultAsync(Adult adult);
        Task RemoveAdultAsync(Adult adult);
        Task UpdateAsync(Adult adult);
    }
}