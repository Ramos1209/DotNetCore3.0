using ApiNetCore_Domain.Entitys;
using ApiNetCore_Domain.Interfaces.Repository;
using ApiNetCore_Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiNetCore_Service.Services
{
   public class UserService : IUserService
    {

        public IRepository<User> _repository;

        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<User> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<User> Post(User user)
        {
            return await _repository.InsertAsync(user);
        }

        public async Task<User> Put(User user)
        {
            return await _repository.UpdateAsync(user);
        }
    }
}
