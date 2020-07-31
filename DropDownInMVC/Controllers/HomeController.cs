using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropDownInMVC.Controllers
{
    public class HomeController : Controller
    {

        List<SelectListItem> myPrograms = new List<SelectListItem> {
            new SelectListItem{
                Text = "BSCS",
                Value= "1"
            },

            new SelectListItem{
                Text = "BSIT",
                Value= "2"
            },

            new SelectListItem{
                Text = "BSSE",
                Value= "3"
            },

            new SelectListItem{
                Text = "BS Chemistry",
                Value= "4"
            },

            new SelectListItem{
                Text = "BBA",
                Value= "5"
            }};
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult DropdownListHardcoded()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DropdownListHardcoded(string SelectedProgram)
        {
            return View();
        }


        public ActionResult UsingViewBag()
        {
            ViewBag.MyPrograms = myPrograms; 
            return View();
        }

        [HttpPost]
        public ActionResult UsingViewBag(string SelectedProgram)
        {
            ViewBag.MyPrograms = myPrograms;
            return View();
        }

    }
}