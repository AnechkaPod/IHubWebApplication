﻿using IHubWebApplication.BLL;
using IHubWebApplication.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Net.WebRequestMethods;

namespace IHubWebApplication.Controllers
{
    public class SugCheshbonController : CRUDController<HgdrSugCheshbon>
    {
        public SugCheshbonController(CRUDService<HgdrSugCheshbon> service, ILogger<CRUDController<HgdrSugCheshbon>> logger) : base(service, logger)
        {
        }
    }
}
