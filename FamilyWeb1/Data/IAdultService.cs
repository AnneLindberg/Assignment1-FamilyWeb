using System.Collections.Generic;
using Models;

namespace FamilyWeb1.Data
{
    public interface IAdultService
    {
        IList<Adult> getAdults();
        void addAdult(Adult adult);
        void removeAdult(Adult adult);
    }
}