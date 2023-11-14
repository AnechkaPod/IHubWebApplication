using IHubWebApplication.DAL;
using IHubWebApplication.Model;

namespace IHubWebApplication.BLL
{
    public class HeshbonService
    {
        private readonly HeshbonRepository _repository;

        public HeshbonService(HeshbonRepository repository)
        {
            _repository = repository;
        }


        internal bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        internal HgdrCheshbon Add(HgdrCheshbon ent)
        {
            return _repository.Add(ent);
        }
        internal List<HgdrCheshbon> GetAll()
        {
            return _repository.GetAll();
        }
        internal List<HgdrCheshbon> GetAllWithSatus(short sugHeshbonStatus)
        {
            return _repository.GetAllWithSatus(sugHeshbonStatus);
        }
        internal void Update(HgdrCheshbon ent)
        {
            _repository.Update(ent);
        }
    }
}
