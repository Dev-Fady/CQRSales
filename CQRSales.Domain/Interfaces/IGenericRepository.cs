using CQRSales.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSales.Domain.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetByIDAsync(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Archived(TEntity entity);
        void UnArchived(TEntity entity);

        Task<bool> SaveChangesAsync();
    }
}
