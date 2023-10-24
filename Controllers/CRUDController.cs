using IHubWebApplication.BLL;
using IHubWebApplication.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace IHubWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class CRUDController<TEntity> : ControllerBase where TEntity : class
    {
        protected readonly CRUDService<TEntity> _service;

        private readonly IConfiguration _configuration;
        public CRUDController(CRUDService<TEntity> service)
        {
            _service = service;
        }


     

        [HttpGet]
        //[Route("GetAll")]
        [EnableCors("AllowSpecificOrigin")]
        public ActionResult GetAll()
        {
            List<TEntity> list = _service.GetAll();
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
