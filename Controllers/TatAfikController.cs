using IHubWebApplication.BLL;
using IHubWebApplication.Models;

namespace IHubWebApplication.Controllers
{
    public class TatAfikController : CRUDController<HgdrTatAfik>
    {
        public TatAfikController(CRUDService<HgdrTatAfik> service) : base(service)
        {
        }
    }
}
