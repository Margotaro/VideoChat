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
        Account acc1 = new Account();
        Account acc2 = new Account();

        public ActionResult Index()
        {
            return View();
        }
        
    }
}