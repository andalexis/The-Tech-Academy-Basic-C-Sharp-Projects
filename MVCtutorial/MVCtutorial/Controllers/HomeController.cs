using MVCtutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCtutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            User user = new User();
            user.ID = 1;
            user.FirstName = "Milo";
            user.LastName = "dd";
            user.Age = 3;
            return View(user); // view method finds the right file to return to the browser

            // logs when someone views index
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\Student\Documents\GitHub\Logging\MVCtutorial.txt", text);
            //// prints random number
            //Random rnd = new Random(10);
            //int num = rnd.Next();

            //// ViewBag.RandomNumber = num; // prints random num
            //if (num > 2000)
            //{
            //    return View("About"); // returns a different view
            //}


        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //throw new Exception("Invalid Page!");

            return View();
        }

        public ActionResult Contact(int id=0)
        {
            // ViewBag.Message = "Your contact page.";
            ViewBag.Message = id;

            return View();
        }
    }
}