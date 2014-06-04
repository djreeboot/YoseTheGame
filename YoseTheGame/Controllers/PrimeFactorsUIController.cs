using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YoseTheGame.Controllers
{
    public class PrimeFactorsUIController : Controller
    {
        //
        // GET: /PrimeFactorsUI/

        public ActionResult Index()
        {
            return View("PrimeFactorsUI");
        }

    }
}
