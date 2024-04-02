using IHubWebApplication.BLL;
using IHubWebApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Principal;

namespace IHubWebApplication.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public abstract class CRUDController<TEntity> : ControllerBase where TEntity : class
    {
        protected readonly CRUDService<TEntity> _service;
        string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs", $"log-{DateTime.Now:yyyy-MM-dd}.txt");
        string logsDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs");

        private readonly IConfiguration _configuration;
        public CRUDController(CRUDService<TEntity> service)
        {
            _service = service;
            if (!Directory.Exists(logsDirectory))
            {
                Directory.CreateDirectory(logsDirectory);
            }
        }




        [HttpGet]
        //[Route("GetAll")]
        [EnableCors("AllowSpecificOrigin")]
        public ActionResult GetAll()
        {

            string username1 = HttpContext.User.Identity.Name;
            List<TEntity> list = null;
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"in CRUDController before get all");
            }

            list = _service.GetAll();

            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"in CRUDController after get all");
                if (list != null)
                    writer.WriteLine($"in CRUDController list" + list.ToList()); ;
            }
            return Ok(list);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult Update(int id, [FromBody] TEntity ent)
        {
            _service.Update(ent);
            return NoContent();
        }

        [HttpPost]
        //[Route("AddMatbea")]
        public ActionResult Add([FromBody] TEntity ent)
        {
            _service.Add(ent);
            return Ok(ent);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            _service.Delete<int>(id);
            return NoContent();
        }

    }
}
