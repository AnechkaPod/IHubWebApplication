using IHubWebApplication.BLL;
using IHubWebApplication.Models;
namespace IHubWebApplication.Controllers
{
    public class MutzarCategoryController : CRUDController<HgdrMutzarCategory>
    {
        public MutzarCategoryController(CRUDService<HgdrMutzarCategory> service) : base(service)
        {
        }
    }
}
