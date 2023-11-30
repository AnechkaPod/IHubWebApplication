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
            List<Screen> list = _service.GetAll();
            return Ok(list);
  
        }

        [HttpGet]
        [Route("GetMainMenus")]
        [EnableCors("AllowSpecificOrigin")]
        public ActionResult GetMainMenus()
        {
            var var = _service.GetAll();
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
