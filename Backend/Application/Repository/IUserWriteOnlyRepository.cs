﻿using System;
using System.Threading.Tasks;
using Domain.Model;

namespace Application.Repository
{
    public interface IUserWriteOnlyRepository
    {
        Task AddUser(User user);
        Task DeleteUser(string username);
        Task UpdateUser(User user);
    }
}
