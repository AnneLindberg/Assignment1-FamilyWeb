﻿using System.Collections.Generic;
  using System.Threading.Tasks;
  using Models;

namespace Assignment1.Data
{
    public interface IUserService
    {
        Task<User> ValidateUser(string userName, string password);
        Task<IList<User>> GetUsersAsync();
        Task <User>AddUserAsync(User user);
    }
}