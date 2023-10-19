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
    public class MutzarController : CRUDController<HgdrMutzar>
    {
        public MutzarController(CRUDService<HgdrMutzar> service) : base(service)
        {
        }

        // [HttpGet]
        //[Route("GetAll")]
        //[EnableCors("AllowSpecificOrigin")]
        //public IActionResult GetAll()
        //{

        //    try
        //    {
        //        // Retrieve your data from a repository or service
        //        List<HgdrMutzar> list = _service.GetAll().ToList();

        //        // Return the data as a JSON array
        //        return Ok(list);
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle exceptions if needed
        //        return BadRequest("An error occurred: " + ex.Message);
        //    }

        //}
    }
}