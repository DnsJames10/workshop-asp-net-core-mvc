using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class SallersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
