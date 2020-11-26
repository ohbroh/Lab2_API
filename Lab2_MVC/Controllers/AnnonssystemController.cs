using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab2_MVC.Controllers
{
    public class AnnonssystemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
