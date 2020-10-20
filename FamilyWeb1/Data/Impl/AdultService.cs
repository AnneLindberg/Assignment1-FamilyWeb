using System.Collections.Generic;
using System.Linq;
using FileData;
using Models;

namespace FamilyWeb1.Data.Impl
{
    public class AdultService : IAdultService
    {
        private FileContext _fileContext = new FileContext();
        private IList<Adult> _adults;
        public IList<Adult> getAdults()
        {
            return _fileContext.Adults;
        }

        public void addAdult(Adult adult)
        {
          _adults.Add(adult);
          _fileContext.SaveChanges();
        }

        public void removeAdult(Adult adult)
        {
            _fileContext.Adults.Remove(adult);
            _fileContext.SaveChanges();
        }
    }
}