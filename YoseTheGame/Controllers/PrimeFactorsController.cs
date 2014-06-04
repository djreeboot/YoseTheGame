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
            string[] numbers = null;

            try
            {
                numbers = Request.QueryString["number"].Split(',');
            }
            catch
            {
            }
            
            if (numbers == null || numbers.Length == 1)
            {
                PrimeFactorsModel model = new PrimeFactorsModel();
                Response response = model.Decompose(number);
                return Json(response, JsonRequestBehavior.AllowGet);
            }
            else
            {
                PrimeFactorsModel model = new PrimeFactorsModel();
                List<Response> responses = model.Decompose(numbers);
                return Json(responses, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
