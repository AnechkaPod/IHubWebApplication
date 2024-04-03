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
    public class MutzarController : ControllerBase
    {
        private readonly MutzarService _service;
        private readonly ILogger<MutzarController> _logger;


        private readonly IConfiguration _configuration;
        public MutzarController(MutzarService service)
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
                List<HgdrMutzar> list = _service.GetAll().ToList();

                // Return the data as a JSON array
                return Ok(list);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                // Handle exceptions if needed
                return BadRequest("An error occurred: " + ex.Message);
            }

        }


        [HttpPut]
        [Route("{id}")]
        public ActionResult Update(int id, [FromBody] HgdrMutzar ent)
        {
            _service.Update(ent);
            return NoContent();
        }



        [HttpPost]
        //[Route("AddMatbea")]
        public ActionResult Add([FromBody] HgdrMutzar ent)
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