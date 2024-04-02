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
        string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs", $"log-{DateTime.Now:yyyy-MM-dd}.txt");
        string logsDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs");

        public CRUDRepository(InvestHubContext dbContext)
        {
            if (!Directory.Exists(logsDirectory))
            {
                Directory.CreateDirectory(logsDirectory);
            }

            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        internal List<TEntity> GetAll()
        {

            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                if (_dbSet != null)
                    writer.WriteLine("CRUDRepository in get all : _dbSet is" + _dbSet);
                if (_dbContext != null)
                    writer.WriteLine("CRUDRepository in get all : _dbContext is" + _dbContext);

                // You can write more log messages here...

            }
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
                return false;
            }
        }
    }

}
