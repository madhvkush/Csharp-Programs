using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_XML_1_.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var Keylist = new Models.KeyWordOps().GetKeywords();
            return View(Keylist);
        }
        public ActionResult AddKey()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddKey(string key)
        {
            ViewBag.Flag = new Models.KeyWordOps().AddKeyword(key);
            return View();
        }

        public ActionResult RemoveKey()
        {

            var Keylist = new Models.KeyWordOps().GetKeywords();
            return View(Keylist);
        }
        [HttpPost]
        public ActionResult RemoveKey(string key)
        {
            ViewBag.Flag = new Models.KeyWordOps().Delete(key);
            return View();
        }
    }
}
