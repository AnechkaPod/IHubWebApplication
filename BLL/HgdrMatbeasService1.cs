using IHubWebApplication.DAL;
using IHubWebApplication.Model;

namespace IHubWebApplication.BLL
{
    public class HgdrMatbeasService1
    {
        private readonly IRepository<HgdrMatbea> _repository;

        public HgdrMatbeasService(IRepository<HgdrMatbea> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<HgdrMatbea>> GetAllHgdrMatbeas()
        {
            return await _repository.GetAllAsync();
        }

        public async Task AddMatbea(HgdrMatbea matbea)
        {
            await _repository.AddAsync(matbea);
         //   await _repository.SaveChangesAsync(); // If your repository has a SaveChangesAsync method.
        }
    }
}
