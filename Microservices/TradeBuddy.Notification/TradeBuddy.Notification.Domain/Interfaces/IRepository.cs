﻿
using TradeBuddy.Notification.Domain.Entities;

namespace TradeBuddy.Notification.Domain.Interfaces
{

    public interface IRepository<T, TKey> where T : BaseEntity<TKey>
    {
        Task<T> GetByIdAsync(TKey id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(TKey id);
    }
}
