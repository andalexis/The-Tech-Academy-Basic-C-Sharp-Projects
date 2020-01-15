using MVC_Drill.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Drill.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (ClientInfosEntities1 db = new ClientInfosEntities1())
            {
                var clientinfos = db.ClientInfos.Where(x => x.Removed == null).ToList();
                var clientinfoVMs = new List<ClientInfoVM>();
                foreach (var clientinfo in clientinfos)
                {
                    var clientinfoVM = new ClientInfoVM();
                    clientinfoVM.Id = clientinfo.Id;
                    clientinfoVM.FirstName = clientinfo.FirstName;
                    clientinfoVM.LastName = clientinfo.LastName;
                    clientinfoVM.EmailAddress = clientinfo.EmailAddress;

                    decimal? x = clientinfo.QuoteTotal;
                    double quotePrice = (double)x;

                    clientinfoVM.QuoteTotal = quotePrice;
                    clientinfoVMs.Add(clientinfoVM);
                }
                return View(clientinfoVMs);
            }
        }

        public ActionResult Delete(int Id)
        {
            using (ClientInfosEntities1 db = new ClientInfosEntities1())
            {
                var clientinfo = db.ClientInfos.Find(Id);
                clientinfo.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}