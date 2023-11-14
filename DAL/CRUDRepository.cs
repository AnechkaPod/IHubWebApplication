using IHubWebApplication.Model;
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
        private readonly IhubWebApplicationContextB59ddbde0599485c928aEe460f987da4Context _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public CRUDRepository(IhubWebApplicationContextB59ddbde0599485c928aEe460f987da4Context dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        internal List<TEntity> GetAll()
        {
            //var navigationProperties = typeof(TEntity).GetProperties()
            //.Where(p => IsNavigationProperty(p.PropertyType));

            //IQueryable<TEntity> query = _dbSet;
            //foreach (var property in navigationProperties)
            //{
            //    query = query.Include(property.Name);
            //}


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
