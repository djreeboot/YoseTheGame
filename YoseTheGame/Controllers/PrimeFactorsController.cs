using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YoseTheGame.Models;

namespace YoseTheGame.Controllers
{
    public class PrimeFactorsController : Controller
    {
        //
        // GET: /PrimeFactors/

        public ActionResult Index(string number)
        {
            PrimeFactorsModel model = new PrimeFactorsModel();
            model.number = int.Parse(number);
            model.Decompose();
            return Json(model, JsonRequestBehavior.AllowGet);
        }

    }
}
