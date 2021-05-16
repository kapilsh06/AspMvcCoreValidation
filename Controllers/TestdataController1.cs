using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Validation_WithMVC.Controllers
{
    public class TestdataController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Reg()
        {
            return View();
        }
    }
}
