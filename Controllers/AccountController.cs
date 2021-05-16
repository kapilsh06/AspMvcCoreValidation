using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Validation_WithMVC.Models;

namespace Validation_WithMVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignUp()
        {
            FillOnLoad();
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(UserModel model)
        {

            //****---------- Explicit Model Validation -----------****//
            //if (string.IsNullOrEmpty(model.name))
            //{
            //    ModelState.AddModelError("Name", "Enter Name");
            //}
            //if (string.IsNullOrEmpty(model.password))
            //{
            //    ModelState.AddModelError("password", "Enter Password");
            //}
            //if (string.IsNullOrEmpty(model.confirmpassword))
            //{
            //    ModelState.AddModelError("confirmpassword", "Enter Confirm Password");
            //}
            //if (string.IsNullOrEmpty(model.address))
            //{
            //    ModelState.AddModelError("address", "Enter Address");
            //}
            //if (string.IsNullOrEmpty(model.contactno))
            //{
            //    ModelState.AddModelError("contactno", "Enter Contact No");
            //}
            //if (model.terms == false)
            //{
            //    ModelState.AddModelError("terms", "Please Checked terms");
            //}
            if (ModelState.IsValid)
            {
                return RedirectToAction("Message");
            }
            return View();
        }


        public IActionResult Message()
        {
            return View();
        }

        public void fillCountry()
        {
            var list = new List<SelectListItem>
                {
                    new SelectListItem{ Text="India", Value = "1",Selected = true },
                    new SelectListItem{ Text="China", Value = "2" },
                    new SelectListItem{ Text="America", Value = "3" },
                    new SelectListItem{ Text="Pakistan", Value = "4" },
                };
            ViewData["Country"] = list;

        }

        public void fillCity()
        {
            var list = new List<SelectListItem>
                {
                    new SelectListItem{ Text="Jaipur", Value = "1",Selected = true },
                    new SelectListItem{ Text="Ajmer", Value = "2" },
                    new SelectListItem{ Text="Delhi", Value = "3" },
                    new SelectListItem{ Text="Noida", Value = "4" },
                    new SelectListItem{ Text="Aligad", Value = "2" },
                    new SelectListItem{ Text="Raj Nagar", Value = "3" },
                    new SelectListItem{ Text="Rampur", Value = "4" },

                };
            ViewData["City"] = list;
        }

        public void FillOnLoad()
        {
            fillCountry();
            ViewData["Gender"] = new List<string>() { "Male", "Female" };
        }

    }
}
