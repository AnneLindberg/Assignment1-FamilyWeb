﻿﻿using System.Threading.Tasks;
  using Models;

namespace Assignment1.Data
{
    public interface IUserService
    {
        public Task<User> ValidateLogin(string userName, string password);
    }
}