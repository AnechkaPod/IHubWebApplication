using IHubWebApplication.BLL;
using IHubWebApplication.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Net.WebRequestMethods;

namespace IHubWebApplication.Controllers
{
    public class BankNechesController : CRUDController<HgdrBankNech>
    {
        public BankNechesController(CRUDService<HgdrBankNech> service) : base(service)
        {
        }
    }
}
