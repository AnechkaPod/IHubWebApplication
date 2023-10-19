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
           return  _dbSet.ToList();
            //        var entities = _dbContext.HgdrMutzars
            //.Select(x => new HgdrMutzar
            //{
            //    Id = x.Id,
            //    Mutzar = x.Mutzar,
            //    KodSugMutzarNavigation = x.KodSugMutzarNavigation // Include the referenced entity
            //})
            //.ToList();

            //        return entities;
            //_dbSet.Include(x=>x.KodSugMutzarNavigation).ToList();
        }
    }
}
