using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DogWalkingAppAuth.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Explore our About Section.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "To contact me for hire, or for any web page suggestions, please feel free to use any of the options below.";

            return View();
        }

        public ActionResult ObesityFacts()
        {
            ViewBag.Message = "Sad Obesity Dog Facts";

            return View();
        }

        public ActionResult PhotoAlbum()
        {
            ViewBag.Message = "Here you can upload and view the wonderful walks shared with you Dog.";

            return View();
        }
    }
}