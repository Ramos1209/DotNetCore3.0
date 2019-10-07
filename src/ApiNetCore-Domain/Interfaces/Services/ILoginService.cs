using ApiNetCore_Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiNetCore_Domain.Interfaces.Services
{
   public interface ILoginService
    {
        Task<object> FindByLogin(User user);
    }
}
