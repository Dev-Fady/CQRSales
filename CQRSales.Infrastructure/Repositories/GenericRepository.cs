using CQRSales.Domain.Interfaces;
using CQRSales.Domain.Models;
using CQRSales.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSales.Infrastructure.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly SalesContext _dbContext;

        public GenericRepository(SalesContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>();
        }

        public async Task<TEntity> GetByIDAsync(int id)
        {
            return await _dbContext.Set<TEntity>().SingleOrDefaultAsync(a => a.ID == id && !a.IArchived);
        }
        public void Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
        }

        public void Archived(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
        }

        public void UnArchived(TEntity entity)
        {
            entity.ArchivedById = null;
            entity.ArchivedDateTime = null;
            entity.ArchivedByName = null;
            entity.IArchived = false;
        }

        public async Task<bool> SaveChangesAsync()
        {
            int rowsAffected = await _dbContext.SaveChangesAsync();
            return rowsAffected > 0;
        }
    }
}
