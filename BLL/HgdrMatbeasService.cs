using IHubWebApplication.DAL;
using IHubWebApplication.Model;
using Microsoft.EntityFrameworkCore;

namespace IHubWebApplication.BLL
{
    public class HgdrMatbeasService
    {
        private readonly Repository<HgdrMatbea> _repository;

        public HgdrMatbeasService(Repository<HgdrMatbea> repository)
        {
            _repository = repository;
        }

        public List<HgdrMatbea> GetAllHgdrMatbeas()
        {
            return _repository.GetAll();
        }

        internal void AddMatbea(HgdrMatbea matbea)
        {
            _repository.Add(matbea);
        }

        internal bool DeleteMatbea(int id)
        {
            return _repository.Delete(id);
        }

        internal void UpdateMatbea(HgdrMatbea updatedMatbea)
        {
            _repository.Update(updatedMatbea);
        }
    }
}
