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
    public class MetafelController : CRUDController<HgdrMetafel>
    {
        public MetafelController(CRUDService<HgdrMetafel> service) : base(service)
        {
        }
    }
}
