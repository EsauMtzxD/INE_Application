using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class LoginController : Controller
    {

        private INEContext dbCtx = new INEContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult checkLoginForKeyElector(string KeyElector)
        {

            Citizen citizen = dbCtx.Citizens.Find(KeyElector);



            return View();

        }

    }
}