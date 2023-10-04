using IHubWebApplication.BLL;
using IHubWebApplication.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Net.WebRequestMethods;

namespace IHubWebApplication.Controllers
{
    [Route("api/[controller]/{entityType}")]
    [ApiController]
    [SwaggerTag("Your Controller Description")]
    public class Controller<TEntity> : ControllerBase where TEntity : class
    {
        private readonly Service<TEntity> _service;

        public Controller(Service<TEntity> service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TEntity>> GetAll()
        {
            var entities = _service.GetAll();
            return Ok(entities);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] TEntity updatedEntity)
        {
            _service.Update(updatedEntity);
            return NoContent();
        }

        [HttpPost]
        public ActionResult Add([FromBody] TEntity entity)
        {
            _service.Add(entity);
            return Ok(entity);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}
