using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoChat.Models;

namespace VideoChat.Controllers
{
    public class HomeController : Controller
    {
        private AccountDbContext db = new AccountDbContext("Accounts");
        
        public ActionResult Index()
        {
            var s = db.accounts.ToList();
            db.accounts.Add(new Account("1234", "firstEverUser", "looser@mail.ru", 1));
            db.SaveChanges();
            return View(db.accounts);
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
    }
}