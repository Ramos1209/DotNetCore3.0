using ApiNetCore_Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiNetCore_Domain.Interfaces.Services
{
   public interface IUserService
    {
        Task<User> Get(Guid id);
        Task<IEnumerable<User>> GetAll();
        Task<User> Post(User user);
        Task<User> Put(User user);
        Task<bool> Delete(Guid id);
    }
}
