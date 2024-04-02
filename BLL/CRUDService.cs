using IHubWebApplication.DAL;
using IHubWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace IHubWebApplication.BLL
{
    public class CRUDService<TEntity> where TEntity : class
    {
        private readonly CRUDRepository<TEntity> _repository;
        string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs", $"log-{DateTime.Now:yyyy-MM-dd}.txt");
        string logsDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs");

        public CRUDService(CRUDRepository<TEntity> repository)
        {
            if (!Directory.Exists(logsDirectory))
            {
                Directory.CreateDirectory(logsDirectory);
            }
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
                if (!Directory.Exists(logsDirectory))
                {
                    Directory.CreateDirectory(logsDirectory);
                }
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - This is a log message: " + ex.Message);
                }
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
