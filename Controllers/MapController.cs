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
    public class MapController : ControllerBase

        //https://www.youtube.com/watch?v=CouLqTfr9Y8&ab_channel=ManojKumar
    {
        private readonly CRUDService<Map> _service;

        private readonly IConfiguration _configuration;
        public MapController(CRUDService<Map> service)
        {
            _service = service;
        }

        [HttpGet]
        //[Route("GetAll")]
        [EnableCors("AllowSpecificOrigin")]
        public Response GetAllMaps([FromQuery] string filter)
        {
            List<Map> list = _service.GetAll().Where(x=>x.TableName == filter).ToList();

            Response response = new Response();
            if (list != null)
            {
                if (list.Count > 0)
                {
                    response.StatusCode = 200;
                    response.StatusMessage = "OK";
                    response.ObjectsList = list.ToList<object>();
                }
                else
                {
                    response.StatusCode = 100;
                    response.StatusMessage = "No Data Found";
                    response.ObjectsList = null;
                }
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "No Data Found";
                response.ObjectsList = null;
            }

            return response;
        }

    }
}
