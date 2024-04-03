using IHubWebApplication.Controllers;
using IHubWebApplication.DAL;
using IHubWebApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace IHubWebApplication.BLL
{
    public class CRUDService<TEntity> where TEntity : class
    {
        private readonly CRUDRepository<TEntity> _repository;
        private readonly ILogger<CRUDService<TEntity>> _logger;
        public CRUDService(ILogger<CRUDService<TEntity>> logger, CRUDRepository<TEntity> repository)
        {
            _logger = logger;
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
                _logger.LogError(ex.Message);
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
