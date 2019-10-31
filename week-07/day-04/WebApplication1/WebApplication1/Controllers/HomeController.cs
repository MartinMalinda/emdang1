using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("useful")]
    public class UsefulController : Controller
    {
        private UtilityService us;

        public UsefulController(UtilityService us)
        {
            this.us = us;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("colored")]
        public IActionResult Colored()
        {
            return View("colored", us.RandomColor());
            // return View((object)us.RandomColor());
        }

        [HttpGet]
        [Route("email")]
        public IActionResult EmailValidator(string email)
        {
            return View((object)us.ValidateEmail(email));
        }

    }
}