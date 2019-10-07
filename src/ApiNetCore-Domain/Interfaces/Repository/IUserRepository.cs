using ApiNetCore_Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiNetCore_Domain.Interfaces.Repository
{
   public interface IUserRepository : IRepository<User>
    {
        Task<User> FindByLogin(string email);
    }
}
