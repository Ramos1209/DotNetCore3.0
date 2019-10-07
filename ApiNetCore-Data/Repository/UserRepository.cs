using ApiNetCore_Data.Context;
using ApiNetCore_Domain.Entitys;
using ApiNetCore_Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiNetCore_Data.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        private readonly DbSet<User> _dbset;
        public UserRepository(DotNetContext context) : base(context)
        {
            _dbset = context.Set<User>();
        }
        public async Task<User> FindByLogin(string email)
        {
            return await _dbset.FirstOrDefaultAsync(u => u.Email.Equals(email));
        }
    }
}
