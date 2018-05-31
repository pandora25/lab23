using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab_21_21.Models;

namespace lab_21_21.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CoffeShopDBEntities ORM = new CoffeShopDBEntities();
            ViewBag.ItemList = ORM.Items.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AddUser()
        {
            return View();
        }

        public ActionResult Register(User NewUser)
        {
            CoffeShopDBEntities ORM = new CoffeShopDBEntities();

            if (ModelState.IsValid)
            {
                ORM.Users.Add(NewUser);
                ORM.SaveChanges();
                ViewBag.UserList = ORM.Users.ToList();

                //return RedirectToAction("AddUser");

                ViewBag.Message =$"Hello {NewUser.FirstName} and Thank you for Registering with US! ";
                return View("Result");
            }
            else
            {
                ViewBag.Address = Request.UserHostAddress;
                return View("Error");
            }
        }

    }
}