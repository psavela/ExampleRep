using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyASPNetApp.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
/*        public string Index()
        {
            return "This is a <strong>DEFAULT INDEX </strong> Index View";
        }
*/
        /*
                public string Welcome()
                {
                    return "This is a Welcome View";
                }

            */

        public ActionResult Index()
        {
            return View();
        }
        /*
                public string Welcome(string name, int ID = 1)
                {
                    return HttpUtility.HtmlEncode("Hello " + name + ", ID is: " + ID);
                }
        */

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello" + name;
            ViewBag.numTimes = numTimes;
            return View();
        }

        public ActionResult MyTestView()
        {
            return View();
        }
    }
}