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
        private readonly ILogger<CRUDController<TEntity>> _logger;

        private readonly IConfiguration _configuration;
        public CRUDController(CRUDService<TEntity> service, ILogger<CRUDController<TEntity>> logger)
        {
            _logger = logger;
            _service = service;
        }


        [HttpGet]
        //[Route("GetAll")]
        [EnableCors("AllowSpecificOrigin")]
        public ActionResult GetAll()
        {
            _logger.LogInformation("GetAll command");
            string username1 = HttpContext.User.Identity.Name;
            List<TEntity> list = null;
            list = _service.GetAll();
            return Ok(list);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult Update(int id, [FromBody] TEntity ent)
        {
            _logger.LogInformation("Update command");
            _service.Update(ent);
            return NoContent();
        }

        [HttpPost]
        //[Route("AddMatbea")]
        public ActionResult Add([FromBody] TEntity ent)
        {
            _logger.LogInformation("Add command");
            _service.Add(ent);
            return Ok(ent);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            _logger.LogInformation("Delete command");
            _service.Delete<int>(id);
            return NoContent();
        }

    }
}
