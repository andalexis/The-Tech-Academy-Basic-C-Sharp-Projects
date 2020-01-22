using MVC_Drill.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Drill.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            using (ClientInfosEntities1 db = new ClientInfosEntities1())
            {
                //var clientinfos = db.ClientInfos.Where(Id => Max(Id)).ToList();
                var clientinfo = db.ClientInfos.OrderByDescending(x => x.Id).FirstOrDefault();
                var clientquoteVMs = new List<ClientQuoteVM>();
                //foreach (var clientinfo in clientinfos)
                {
                    var clientquoteVM = new ClientQuoteVM();

                    decimal? x = clientinfo.QuoteTotal;
                    double quotePrice = (double)x;

                    clientquoteVM.QuoteTotal = quotePrice;
                    clientquoteVMs.Add(clientquoteVM);
                }
                return View(clientquoteVMs);
            }
        }

        //    public ActionResult Display(int Id)
        //    {
        //        using (ClientInfosEntities1 db = new ClientInfosEntities1())
        //        {
        //            var clientinfo = db.ClientInfos.Find(Id);
        //            clientinfo.Removed = DateTime.Now;
        //            db.SaveChanges();
        //        }
        //        return RedirectToAction("Index");
        //    }
        //}
    }
}