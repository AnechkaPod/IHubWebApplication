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
    public class SugMutzarCategoryController : CRUDController<HgdrMutzarCategory>
    {
        public SugMutzarCategoryController(CRUDService<HgdrMutzarCategory> service) : base(service)
        {
        }

        [HttpGet]
        [Route("{id}")]
        //[Route("GetAll")]
        [EnableCors("AllowSpecificOrigin")]
        public ActionResult GetAll([FromQuery] int kodSugMutzar)
        {
            List<HgdrMutzarCategory> list = _service.GetAll().Where(x=>x.KodSugMutzar == kodSugMutzar).ToList();
            return Ok(list);
        }

    }
}