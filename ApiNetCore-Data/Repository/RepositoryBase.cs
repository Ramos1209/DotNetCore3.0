using ApiNetCore_Data.Context;
using ApiNetCore_Domain.Entitys;
using ApiNetCore_Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiNetCore_Data.Repository
{
    public class RepositoryBase<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly DotNetContext _context;
        private DbSet<T> _dbset;

        public RepositoryBase(DotNetContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();

        }
        public async Task<T> InsertAsync(T item)
        {
            try
            {
                if (item.Id == Guid.Empty)
                {
                    item.Id = Guid.NewGuid();
                }
                item.CreateAt = DateTime.UtcNow;
                _dbset.Add(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return item;
        }
        public async Task<T> UpdateAsync(T item)
        {
            try
            {
                var result = await _dbset.SingleOrDefaultAsync(x => x.Id.Equals(item.Id));
                if (result == null)
                    return null;

                item.UpdateAt = DateTime.UtcNow;
                item.CreateAt = result.CreateAt;

                _context.Entry(result).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return item;
        }
        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                var result = await _dbset.SingleOrDefaultAsync(x => x.Id.Equals(id));
                if (result == null)
                    return false;

                _dbset.Remove(result);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public async Task<bool> ExistAsync(Guid id)
        {
            return await _dbset.AnyAsync(x => x.Id.Equals(id));
        }

        public async Task<T> SelectAsync(Guid id)
        {
            return await _dbset.SingleOrDefaultAsync(x => x.Id.Equals(id));
        }

        public async Task<IEnumerable<T>> SelectAsync()
        {
            return await _dbset.ToListAsync();
        }
    }
}

