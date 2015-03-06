
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BBLB2C.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/Admin/

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
    }
}
