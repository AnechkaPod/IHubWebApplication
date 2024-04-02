using IHubWebApplication.BLL;
using IHubWebApplication.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Principal;
using static System.Net.WebRequestMethods;

namespace IHubWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScreensController : ControllerBase

    //https://www.youtube.com/watch?v=CouLqTfr9Y8&ab_channel=ManojKumar
    {
        private readonly CRUDService<Screen> _service;

        private readonly IConfiguration _configuration;
        public ScreensController(CRUDService<Screen> service)
        {
            _service = service;
        }

        [HttpGet]
        [EnableCors("AllowSpecificOrigin")]
        public ActionResult GetAll()
        {
            string username1 = HttpContext.User.Identity.Name;
            string username = User.Identity.Name;
            List<Screen> list = _service.GetAll();
            return Ok(list);
  
        }

        [HttpGet]
        [Route("GetMainMenus")]
        [EnableCors("AllowSpecificOrigin")]
        public ActionResult GetMainMenus()
        {
            List<Screen> list = _service.GetAll().Where(x=>x.ScreenParentId == null).ToList();
            return Ok(list);
        }

        [HttpGet]
        [Route("GetSubMenus")]
        [EnableCors("AllowSpecificOrigin")]
        [Route("{id}")]
        public ActionResult GetSubMenus(int id)
        {
            List<Screen> list = _service.GetAll().Where(x => x.ScreenParentId == id).ToList();
            return Ok(list);
        }
    }
}
