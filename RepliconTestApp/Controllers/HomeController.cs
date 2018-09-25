using RepliconTestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RepliconTestApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult One()
        {
            return View();
        }

        [HttpPost]
        public JsonResult DispenseAmount(string amount)
        {
            int result = 0;
            vmNotes onjNotes = new vmNotes();
            onjNotes = onjNotes.SplitAmount(Convert.ToInt32(Convert.ToDouble(amount)));
            if (onjNotes.errorMsg != null)
            {
                result = 1;
            }
            else
            {
                result = 0;
            }
            return Json(new { data = onjNotes, code = result });
        }

        [HttpGet]
        public ActionResult Two()
        {
            return View();
        }

        [HttpPost]
        public JsonResult FactorialNumber(string Fnumber)
        {
            vmFactorial objFactorial = new vmFactorial();
            var str = string.Empty;
            int result = 0;
            try
            {
                int number = Convert.ToInt32(Convert.ToDouble(Fnumber));
                if (number > 0)
                {
                    for (int i = 0; i < number; i++)
                    {
                        if (i == (number - 1))
                        {
                            str += string.Format("{0}", (number - i));
                        }
                        else
                        {
                            str += string.Format("{0}*", (number - i));
                        }
                    }
                    objFactorial.IterationStr = string.Format("Factorial is ({0}) so output {1}", str, objFactorial.Iterationfactorial(number));
                    objFactorial.recursionStr = string.Format("Factorial is ({0}) so output {1}", str, objFactorial.recursionFactorial(number));
                    result = 0;
                }
                else
                {
                    objFactorial = new vmFactorial();
                    objFactorial.errorMsg = "Number Should be greater than Zero";
                    result = 1;
                }

            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                result = 1;
            }
            return Json(new { data = objFactorial, code = result });
        }
    }
}