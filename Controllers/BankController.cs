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
    public class BankController : ControllerBase

    //https://www.youtube.com/watch?v=CouLqTfr9Y8&ab_channel=ManojKumar
    {
        private readonly CRUDService<HgdrBank> _service;

        private readonly IConfiguration _configuration;
        public BankController(CRUDService<HgdrBank> service)
        {
            _service = service;
        }

        [HttpGet]
        //[Route("GetAll")]
        [EnableCors("AllowSpecificOrigin")]
        public ActionResult GetAllHgdrMatbeas()
        {
            List<HgdrBank> list = _service.GetAll();
            return Ok(list);
  
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult UpdateMatbea(int id, [FromBody] HgdrBank updatedMatbea)
        {
            _service.Update(updatedMatbea);
            return NoContent();
        }

        [HttpPost]
        //[Route("AddMatbea")]
        public ActionResult AddMatbea([FromBody] HgdrBank matbea)
        {
            _service.Add(matbea);
            return Ok(matbea);
        }



        [HttpDelete]
        [Route("{id}")]
        public ActionResult DeleteMatbea(short id)
        {
            _service.Delete<short>(id);
            return NoContent();
        }
    }
}
