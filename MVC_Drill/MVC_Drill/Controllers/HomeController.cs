using MVC_Drill.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Drill.Controllers
{
    public class HomeController : Controller
    {
        public int baseline = 50;
        public decimal? quoteTotal { get; set; }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ClientInfo(string firstName, string lastName, string emailAddress, DateTime dateofbirth,
                                        int carYear, string carMake, string carModel, string checkDUI, int speedTickets, string checkCoverage)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");

            }
            else
            {

                using (ClientInfosEntities1 db = new ClientInfosEntities1())
                {
                    var clientinfo = new ClientInfo();
                    clientinfo.FirstName = firstName;
                    clientinfo.LastName = lastName;
                    clientinfo.EmailAddress = emailAddress;
                    clientinfo.CarYear = carYear;
                    clientinfo.CarMake = carMake;
                    clientinfo.CarModel = carModel;
                    if (checkDUI == null)
                    {
                        clientinfo.CheckDUI = "no";
                    }
                    else
                    {
                        clientinfo.CheckDUI = "yes";
                    }
                    clientinfo.SpeedTickets = speedTickets;
                    if (checkCoverage == null)
                    {
                        clientinfo.CheckCoverage = "no";
                    }
                    else
                    {
                        clientinfo.CheckCoverage = "yes";
                    }

                    CalculateQuote(dateofbirth, carYear, carMake, carModel, checkDUI, speedTickets, checkCoverage);

                    decimal? x = quoteTotal;
                    double quotePrice = (double)x;

                    clientinfo.QuoteTotal = x;
                    db.ClientInfos.Add(clientinfo);
                    db.SaveChanges();
                }
            }
            Display();
            return View("ViewQuote");
        }

        public ActionResult CalculateQuote(DateTime birthday, int carYear, string carMake, string carModel, string checkDUI, int speedTickets, string checkCoverage)
        {
            int years = DateTime.Now.Year - birthday.Year;

            if ((birthday.Month > DateTime.Now.Month) || (birthday.Month == DateTime.Now.Month && birthday.Day > DateTime.Now.Day))
            {
                years--;
                if (years < 18)
                {
                    quoteTotal = baseline + 100;
                }
                if (years < 25 && years > 18 || years > 100)
                {
                    quoteTotal = baseline + 25;
                }
                else { quoteTotal = baseline; }
            }

            if  (carYear < 2000 || carYear > 2015) 
            { 
                quoteTotal += 25; 
            }
            else { quoteTotal += 0; }

            if (carMake.ToLower() == "porsche")
            {
                if (carModel == "911 Carrera")
                {
                    quoteTotal += 50;
                }
                else { quoteTotal += 25; }
            }
            else { quoteTotal += 0; }

            if (checkDUI == "yes")
            {
                quoteTotal = ((1/4) * quoteTotal) + quoteTotal;
            }
            else { quoteTotal += 0; }

            if (checkCoverage == "yes")
            {
                quoteTotal = ((1/4) * quoteTotal) + quoteTotal;
            }
            else { quoteTotal += 0; }

            quoteTotal = (10 * speedTickets);
            return View();
        }

        public ActionResult Display()
        {
            using (ClientInfosEntities1 db = new ClientInfosEntities1())
            {
                var clientinfo = db.ClientInfos.OrderByDescending(x => x.Id).FirstOrDefault();
                var clientquoteVMs = new List<ClientQuoteVM>();
                {
                    var clientquoteVM = new ClientQuoteVM();
                    // casting
                    decimal? x = clientinfo.QuoteTotal;
                    double quotePrice = (double)x;

                    clientquoteVM.QuoteTotal = quotePrice;
                    clientquoteVMs.Add(clientquoteVM);
                }
                return View(clientquoteVMs);
            }
        }
        

    }
}