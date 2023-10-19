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
        internal List<HgdrMutzar> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
