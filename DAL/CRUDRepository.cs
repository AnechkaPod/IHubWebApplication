using IHubWebApplication.Controllers;
using IHubWebApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Dynamic;
using System.Reflection;

namespace IHubWebApplication.DAL
{
    public class CRUDRepository<TEntity> where TEntity : class
    {
        private readonly InvestHubContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;
        private readonly ILogger<CRUDRepository<TEntity>> _logger;
        public CRUDRepository(ILogger<CRUDRepository<TEntity>> logger , InvestHubContext dbContext)
        {
            _logger = logger;
             _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        internal List<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }
        private static bool IsNavigationProperty(Type type)
        {
            return typeof(IEnumerable<object>).IsAssignableFrom(type)
                || typeof(object).IsAssignableFrom(type);
        }

        internal void Add(TEntity entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        internal void Update(TEntity updatedEntity)
        {
            _dbSet.Update(updatedEntity);
            _dbContext.SaveChanges();
        }

        internal bool Delete<TKey>(TKey id)
        {
            try
            {
                TEntity entity = null;
                try
                {

                    entity = _dbSet.Find(id);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex.Message);
                    try
                    {
                        entity = _dbSet.Find(short.Parse(id.ToString()));
                    }
                    catch
                    {
                        entity = _dbSet.Find(byte.Parse(id.ToString()));
                    }
                }

                if (entity == null)
                {
                    // If the entity with the specified ID is not found, return false.
                    return false;
                }
                else
                {
                    _dbSet.Remove(entity);
                    _dbContext.SaveChanges();

                    return true; // Deletion was successful.
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return false;
            }
        }
    }

}
