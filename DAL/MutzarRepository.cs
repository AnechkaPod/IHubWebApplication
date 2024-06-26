﻿
using IHubWebApplication.Controllers;
using IHubWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace IHubWebApplication.DAL
{
    public class MutzarRepository
    {
        private readonly InvestHubContext _dbContext;
        private readonly DbSet<HgdrMutzar> _dbSet;
        private readonly ILogger<MutzarRepository> _logger;
        public MutzarRepository(InvestHubContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<HgdrMutzar>();
        }


        internal List<HgdrMutzar> GetAll()
        {
            return _dbSet.Include(x=>x.KodSugMutzarNavigation)
                .Include(x => x.KodMutzarCategoryNavigation)
                .ToList();
        }

        internal void Update(HgdrMutzar ent)
        {

            //DbSet<HgdrSugMutzar> dbset = _dbContext.Set<HgdrSugMutzar>();
            //HgdrSugMutzar hgdrSugMutzar = dbset.ToList().FirstOrDefault(x => x.Id == ent.KodSugMutzar);

            //ent.KodSugMutzarNavigation = hgdrSugMutzar;

            //if (ent.KodMutzarCategory.HasValue)
            //{
            //    DbSet<HgdrMutzarCategory> dbsetHgdrMutzarCategory = _dbContext.Set<HgdrMutzarCategory>();
            //    HgdrMutzarCategory hgdrMutzarCategory = dbsetHgdrMutzarCategory.ToList().FirstOrDefault(x => x.Id == ent.KodMutzarCategory.Value);
            //    ent.KodMutzarCategoryNavigation = hgdrMutzarCategory;
            //}
            //_dbSet.Update(ent);
            //_dbContext.SaveChanges();
        }


        internal HgdrMutzar Add(HgdrMutzar entity)
        {
            //DbSet<HgdrSugMutzar> dbset = _dbContext.Set<HgdrSugMutzar>();
            //HgdrSugMutzar hgdrSugMutzar = dbset.ToList().FirstOrDefault(x => x.Id == entity.KodSugMutzar);
            //entity.KodSugMutzarNavigation = hgdrSugMutzar;
            //if (entity.KodMutzarCategory.HasValue)
            //{
            //    DbSet<HgdrMutzarCategory> dbsetHgdrMutzarCategory = _dbContext.Set<HgdrMutzarCategory>();
            //    HgdrMutzarCategory hgdrMutzarCategory = dbsetHgdrMutzarCategory.ToList().FirstOrDefault(x => x.Id == entity.KodMutzarCategory.Value);
            //    entity.KodMutzarCategoryNavigation = hgdrMutzarCategory;
            //}

            //_dbSet.Add(entity);
            //_dbContext.SaveChanges();
            return entity;
        }

        internal bool Delete(int id)
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
                _logger.LogError(ex.Message);
                return false;
            }
        }
    }
}
