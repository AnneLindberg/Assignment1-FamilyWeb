﻿using System;
using System.Collections.Generic;
using System.Linq;
using Assignment1.Data;
using Models;

namespace LoginExample.Data.Impl
{
    public class InMemoryUserService : IUserService {
        private List<User> users;

        public InMemoryUserService() {
            users = new[] {
                new User {
                   Password = "12345",
                    Role = "Admin",
                    SecurityLevel = 5,
                    UserName = "Anne"
                },
                new User {
                    Password = "12345",
                    Role = "User",
                    SecurityLevel = 3,
                    UserName = "Sonny"
                }
            }.ToList();
        }


        public User ValidateUser(string userName, string password) {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null) {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password)) {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}