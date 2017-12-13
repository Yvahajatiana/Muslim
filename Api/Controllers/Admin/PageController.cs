using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Admin
{
    [Produces("application/json")]
    [Route("api/Page")]
    public class PageController : Controller
    {
        public PageController()
        {

        }
    }
}