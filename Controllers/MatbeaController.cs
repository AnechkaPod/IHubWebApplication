﻿using IHubWebApplication.BLL;
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
    public class MatbeaController : ControllerBase

    //https://www.youtube.com/watch?v=CouLqTfr9Y8&ab_channel=ManojKumar
    {
        private readonly CRUDService<HgdrMatbea> _service;

        private readonly IConfiguration _configuration;
        public MatbeaController(CRUDService<HgdrMatbea> service)
        {
            _service = service;
        }

        [HttpGet]
        //[Route("GetAll")]
        [EnableCors("AllowSpecificOrigin")]
        public ActionResult GetAllHgdrMatbeas()
        {
            List<HgdrMatbea> list = _service.GetAll();
            return Ok(list);
  
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult UpdateMatbea(int id, [FromBody] HgdrMatbea updatedMatbea)
        {
            _service.Update(updatedMatbea);
            return NoContent();
        }

        [HttpPost]
        //[Route("AddMatbea")]
        public ActionResult AddMatbea([FromBody] HgdrMatbea matbea)
        {
            _service.Add(matbea);
            return Ok(matbea);
        }



        [HttpDelete]
        [Route("{id}")]
        public ActionResult DeleteMatbea(int id)
        {
            _service.Delete<int>(id);
            return NoContent();
        }
    }
}
