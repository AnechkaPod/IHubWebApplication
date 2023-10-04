using IHubWebApplication.DAL;
using IHubWebApplication.Model;

namespace IHubWebApplication.BLL
{
    public class MapService
    {
        private readonly MapRepository _repository;

        public MapService(MapRepository repository)
        {
            _repository = repository;
        }

        public List<Map> GetAllMaps()
        {
            return _repository.GetAll();
        }
    }
}
