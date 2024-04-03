
using IHubWebApplication.Controllers;
using IHubWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace IHubWebApplication.DAL
{
    public class HeshbonRepository
    {
        private readonly InvestHubContext _dbContext;
        private readonly DbSet<HgdrCheshbon> _dbSet;
        private readonly ILogger<HeshbonRepository> _logger;

        public HeshbonRepository(InvestHubContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<HgdrCheshbon>();
        }


        internal List<HgdrCheshbon> GetAll()
        {

            return _dbSet.Include(x => x.SugCheshbonNavigation)
                .Include(x => x.KodBankNavigation)
                .ToList();
        }
        internal List<HgdrCheshbon> GetAllWithSatus(short statusSugHeshbon)
        {

            return _dbSet.Where(x=>x.SugCheshbon == statusSugHeshbon).Include(x => x.SugCheshbonNavigation)
                .Include(x => x.KodBankNavigation)
                .ToList();
        }
        internal void Update(HgdrCheshbon ent)
        {
            DbSet<HgdrSugCheshbon> dbset = _dbContext.Set<HgdrSugCheshbon>();
            HgdrSugCheshbon hgdrSugHeshbon = dbset.ToList().FirstOrDefault(x => x.Id == ent.SugCheshbon);
            ent.SugCheshbonNavigation = hgdrSugHeshbon;

            DbSet<HgdrBank> dbsetBank = _dbContext.Set<HgdrBank>();
            HgdrBank hgrdBank = dbsetBank.ToList().FirstOrDefault(x => x.KodBank == ent.KodBank);
            ent.KodBankNavigation = hgrdBank;

            _dbSet.Update(ent);
            _dbContext.SaveChanges();
        }


        internal HgdrCheshbon Add(HgdrCheshbon entity)
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
