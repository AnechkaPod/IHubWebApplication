using IHubWebApplication.DAL;
using IHubWebApplication.Model;
using Microsoft.EntityFrameworkCore;

namespace IHubWebApplication.BLL
{
    public class CRUDService<TEntity> where TEntity : class
    {
        private readonly CRUDRepository<TEntity> _repository;

        public CRUDService(CRUDRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public List<TEntity> GetAll()
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        internal void Add(TEntity ent)
        {
            _repository.Add(ent);
        }

        internal bool Delete<TKey>(TKey id)
        {
            return _repository.Delete(id);
        }

        internal void Update(TEntity ent)
        {
            _repository.Update(ent);
        }

    }
}
