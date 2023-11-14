using IHubWebApplication.BLL;
using IHubWebApplication.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Net.WebRequestMethods;

namespace IHubWebApplication.Controllers
{
    public class ManpikController : CRUDController<HgdrManpik>
    {
        public ManpikController(CRUDService<HgdrManpik> service) : base(service)
        {
        }
    }
}
