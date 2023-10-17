using IHubWebApplication.BLL;
using IHubWebApplication.Model;

namespace IHubWebApplication.Controllers
{
    public class TatAfikController : CRUDController<HgdrTatAfik>
    {
        public TatAfikController(CRUDService<HgdrTatAfik> service) : base(service)
        {
        }
    }
}
