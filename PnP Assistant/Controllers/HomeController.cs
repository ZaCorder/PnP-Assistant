using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();

        }

        public ActionResult DiceRoller()
        {
            ViewBag.Message = "Dice Roller";

            return View();
        }

        public ActionResult Characters()
        {
            ViewBag.Message = "Characters";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact";

            return View();
        }
        public ActionResult CharacterSheetViewMockUp()
        {
            ViewBag.Message = "Character Sheet";

            return View();
        }
        public ActionResult LogIn()
        {
            ViewBag.Message = "Log In";

            return View();
        }
        public ActionResult Register()
        {
            ViewBag.Message = "Register";

            return View();
        }
    }
}