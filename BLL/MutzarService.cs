using IHubWebApplication.DAL;
using IHubWebApplication.Model;

namespace IHubWebApplication.BLL
{
    public class MutzarService
    {
        private readonly MutzarRepository _repository;

        public MutzarService(MutzarRepository repository)
        {
            _repository = repository;
        }

        internal void Add(HgdrMutzar ent)
        {
            _repository.Add(ent);
        }

        internal bool Delete(int id)
        {
            return _repository.Delete(id);
        }


        internal List<HgdrMutzar> GetAll()
        {
            return _repository.GetAll();
        }

        internal void Update(HgdrMutzar ent)
        {
            _repository.Update(ent);
        }
    }
}
