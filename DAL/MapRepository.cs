using IHubWebApplication.Model;

namespace IHubWebApplication.DAL
{
    public class MapRepository
    {
        private readonly IhubWebApplicationContextB59ddbde0599485c928aEe460f987da4Context _dbContext;

        public MapRepository(IhubWebApplicationContextB59ddbde0599485c928aEe460f987da4Context dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Map> GetAll()
        {
            return _dbContext.Maps.ToList();
        }
    }
}
