using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace amakerMVC.Controllers
{
    public class demoController : Controller
    {
        //
        // GET: /demo/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Upload()
        {
            return View();
        }

        public ActionResult Save(FormCollection values)
        {
           
            string a = values["a"];
            return Content("<img src=" + a + ">");
        }

        public ActionResult Save2(FormCollection values)
        {
            Jsondata j = new Jsondata();
            j.Status =  values["base64"];
            return Json(j,JsonRequestBehavior.AllowGet);
        }
    }
}
public class Jsondata{
    public string Status { get; set; }

}

