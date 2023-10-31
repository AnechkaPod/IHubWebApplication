using IHubWebApplication.Model;
using Microsoft.EntityFrameworkCore;

namespace IHubWebApplication.DAL
{
    public class MutzarRepository
    {
        private readonly IhubWebApplicationContextB59ddbde0599485c928aEe460f987da4Context _dbContext;
        private readonly DbSet<HgdrMutzar> _dbSet;
        public MutzarRepository(IhubWebApplicationContextB59ddbde0599485c928aEe460f987da4Context dbContext)
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
            //HgdrMutzar mutzarToUpdte = _dbSet.Find(ent.KodMutzar);
            //mutzarToUpdte.Mutzar = ent.Mutzar;

            DbSet<HgdrSugMutzar> dbset = _dbContext.Set<HgdrSugMutzar>();
            HgdrSugMutzar hgdrSugMutzar = dbset.ToList().FirstOrDefault(x => x.Id == ent.KodSugMutzar);

            ent.KodSugMutzarNavigation = hgdrSugMutzar;

            if (ent.KodMutzarCategory.HasValue)
            {
                DbSet<HgdrMutzarCategory> dbsetHgdrMutzarCategory = _dbContext.Set<HgdrMutzarCategory>();
                HgdrMutzarCategory hgdrMutzarCategory = dbsetHgdrMutzarCategory.ToList().FirstOrDefault(x => x.Id == ent.KodMutzarCategory.Value);
                ent.KodMutzarCategoryNavigation = hgdrMutzarCategory;
            }
            _dbSet.Update(ent);
            _dbContext.SaveChanges();
        }


        internal void Add(HgdrMutzar entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
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
                return false;
            }
        }
    }
}
