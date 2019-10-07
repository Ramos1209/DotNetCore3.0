using ApiNetCore_Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiNetCore_Domain.Interfaces.Repository
{
   public interface IRepository<T> where T : BaseEntity
    {
        Task<T> InsertAsync(T obj);
        Task<T> UpdateAsync(T obj);
        Task<bool> DeleteAsync(Guid id);
        Task<T> SelectAsync(Guid id);
        Task<IEnumerable<T>> SelectAsync();
        Task<bool> ExistAsync(Guid id);
    }
}
