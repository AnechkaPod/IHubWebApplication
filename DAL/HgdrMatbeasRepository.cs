using IHubWebApplication.Model;
using Microsoft.EntityFrameworkCore;

namespace IHubWebApplication.DAL
{
    public class HgdrMatbeasRepository
    {
        private readonly IhubWebApplicationContextB59ddbde0599485c928aEe460f987da4Context _dbContext;

        public HgdrMatbeasRepository(IhubWebApplicationContextB59ddbde0599485c928aEe460f987da4Context dbContext)
        {
            _dbContext = dbContext;
        }
        internal List<HgdrMatbea> GetAll()
        {
            return _dbContext.HgdrMatbeas.ToList();
        }

        internal void AddMatbea(HgdrMatbea matbea)
        {
            _dbContext.HgdrMatbeas.Add(matbea);
            _dbContext.SaveChanges();
        }

        internal void UpdateMatbea(HgdrMatbea updatedMatbea)
        {
            _dbContext.Set<HgdrMatbea>().Update(updatedMatbea);
            _dbContext.SaveChanges();
            
        }

        internal bool DeleteMatbea(int id)
        {
            var matbea = _dbContext.HgdrMatbeas.Find(id);

            if (matbea == null)
            {
                // If the Matbea with the specified ID is not found, return false.
                return false;
            }

            try
            {
                // Remove the Matbea from the DbContext and save changes.
                _dbContext.HgdrMatbeas.Remove(matbea);
                _dbContext.SaveChanges();

                return true; // Deletion was successful.
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the deletion.
                // You might want to log the exception for debugging.
                return false; // Deletion failed.
            }
        }
    }
}
