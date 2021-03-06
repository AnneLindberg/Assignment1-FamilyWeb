﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace FamilyWeb1.Data
{
    public interface IAdultService
    {
        Task<IList<Adult>> GetAdultsAsync();
        Task AddAdultAsync(Adult adult);
      
    }
}