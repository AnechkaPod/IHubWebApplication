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
    [Route("api/[controller]")]
    [ApiController]
    public class HeshbonController : ControllerBase
    {
        private readonly HeshbonService _service;

        private readonly IConfiguration _configuration;
        public HeshbonController(HeshbonService service)
        {
            _service = service;
        }


        [HttpGet]
        //  [Route("GetAll")]
        [EnableCors("AllowSpecificOrigin")]
        public IActionResult GetAll()
        {
            try
            {
                // Retrieve your data from a repository or service
                List<HgdrCheshbon> list = _service.GetAll().ToList();

                // Return the data as a JSON array
                return Ok(list);
            }
            catch (Exception ex)
            {
                // Handle exceptions if needed
                return BadRequest("An error occurred: " + ex.Message);
            }

        }


        [HttpGet]
        [Route("GetAllWithSugHeshbonStatus")]
        [EnableCors("AllowSpecificOrigin")]
        public IActionResult GetAllWithSugHeshbonStatus(short status)
        {
            try
            {
                // Retrieve your data from a repository or service
                List<HgdrCheshbon> list = _service.GetAllWithSatus(status);

                // Return the data as a JSON array
                return Ok(list);
            }
            catch (Exception ex)
            {
                // Handle exceptions if needed
                return BadRequest("An error occurred: " + ex.Message);
            }

        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult Update(int id, [FromBody] HgdrCheshbon ent)
        {
            _service.Update(ent);
            return NoContent();
        }



        [HttpPost]
        //[Route("AddMatbea")]
        public ActionResult Add([FromBody] HgdrCheshbon ent)
        {
            _service.Add(ent);
            return Ok(ent);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }

    }
}
