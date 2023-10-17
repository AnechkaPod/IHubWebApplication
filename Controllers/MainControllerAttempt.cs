using IHubWebApplication.BLL;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace IHubWebApplication.Controllers
{
    //public class MainControllerAttempt : ControllerBase
    //{
    //    private readonly Dictionary<Type, object> _services;

    //    public MainControllerAttempt(IEnumerable<object> services)
    //    {
    //        _services = services.ToDictionary(service => service.GetType().GenericTypeArguments[0]);
    //    }

    //    [HttpGet("{entityType}")]
    //    [EnableCors("AllowSpecificOrigin")]
    //    public ActionResult GetAll(string entityType)
    //    {
    //        if (_services.TryGetValue(Type.GetType(entityType), out var service))
    //        {
    //            var method = service.GetType().GetMethod("GetAll");
    //            var result = method.Invoke(service, null);
    //            return Ok(result);
    //        }

    //        return NotFound();
    //    }

    //    [HttpPut("{entityType}/{id}")]
    //    public ActionResult Update(string entityType, int id, [FromBody] object updatedEntity)
    //    {
    //        if (_services.TryGetValue(Type.GetType(entityType), out var service))
    //        {
    //            var method = service.GetType().GetMethod("Update");
    //            method.Invoke(service, new object[] { id, updatedEntity });
    //            return NoContent();
    //        }

    //        return NotFound();
    //    }

    //    [HttpPost("{entityType}")]
    //    public ActionResult Add(string entityType, [FromBody] object entity)
    //    {
    //        if (_services.TryGetValue(Type.GetType(entityType), out var service))
    //        {
    //            var method = service.GetType().GetMethod("Add");
    //            method.Invoke(service, new object[] { entity });
    //            return Ok(entity);
    //        }

    //        return NotFound();
    //    }

    //    [HttpDelete("{entityType}/{id}")]
    //    public ActionResult Delete(string entityType, int id)
    //    {
    //        if (_services.TryGetValue(Type.GetType(entityType), out var service))
    //        {
    //            var method = service.GetType().GetMethod("Delete");
    //            method.Invoke(service, new object[] { id });
    //            return NoContent();
    //        }

    //        return NotFound();
    //    }
    //}
}