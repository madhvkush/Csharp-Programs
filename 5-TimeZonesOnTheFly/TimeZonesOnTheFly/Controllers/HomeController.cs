using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TimeZonesOnTheFly.Controllers
{
    public class HomeController : Controller
    {
        //  Time Zone Conversion
        //https://www.c-sharpcorner.com/blogs/simple-timezone-for-all-countries-using-c-sharp-code
        public ActionResult Index()
        {
            TimeZoneInfo IndiaZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            ViewBag.IndianDate = TimeZoneInfo.ConvertTime(DateTime.Now, IndiaZone);

            TimeZoneInfo CentralAmericaZone = TimeZoneInfo.FindSystemTimeZoneById("Central America Standard Time");
            ViewBag.CentralAmericaDate = TimeZoneInfo.ConvertTime(DateTime.Now, CentralAmericaZone);

            TimeZoneInfo PacificZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            ViewBag.PacificDate = TimeZoneInfo.ConvertTime(DateTime.Now, PacificZone);
            return View();
        }
    }
}