using IHubWebApplication.Model;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
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
           
            return _dbSet.ToList();
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

        //internal bool Delete<TKey>(TKey id)
        //{
        //    try
        //    {
        //        var entity = _dbSet.Find(id);
        //        if (entity == null)
        //        {
        //            // If the entity with the specified ID is not found, return false.
        //            return false;
        //        }
        //        else
        //        {
        //            _dbSet.Remove(entity);
        //            _dbContext.SaveChanges();

        //            return true; // Deletion was successful.
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}
        internal bool Delete<TKey>(TKey id)
        {
            try
            {
               
                var entity = _dbSet.Find(id);
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
