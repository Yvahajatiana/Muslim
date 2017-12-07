using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebClient.Models;
using WebClient.Data;

namespace WebClient.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IContentService contentService;

        public HomeController(IContentService ContentService)
        {
            contentService = ContentService;
        }
        public IActionResult Index()
        {
            var HomeContent = contentService.GetHomeContent();
            return View(HomeContent);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
