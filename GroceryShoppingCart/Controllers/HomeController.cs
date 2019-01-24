using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroceryShoppingCart.Models;
using Microsoft.AspNetCore.Http;
using GroceryShoppingCart.Services;
using GroceryShoppingCart.ViewModels;
using Microsoft.Extensions.Options;

namespace GroceryShoppingCart.Controllers
{
    public class HomeController : Controller
    {

        private GroceryCartContext db;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private EmailSettings _emailSettings;

        const string SOME_SESSION_DATA = "Session Information";
        const string MORE_SESSION_DATA = "Session Date";


        // Initialize context when controller is created.
        public HomeController(GroceryCartContext db, IHttpContextAccessor httpContextAccessor, IOptions<EmailSettings> _emailSettings)
        {
            this.db = db;
            Seeder seeder = new Seeder(db);
            this._httpContextAccessor = httpContextAccessor;
            this._emailSettings = _emailSettings.Value;
        }


        [HttpGet]
        public IActionResult Index()
        {
            CookieHelper cookieHelper = new CookieHelper(_httpContextAccessor, Request,
                                                         Response);
            string firstName = cookieHelper.Get("firstName");
            if (firstName != null)
            {
                ViewBag.UserName = firstName;
            }


            // Create session data at start up or whenever the session has expired.
            if (HttpContext.Session.GetString(SOME_SESSION_DATA) == null)
            {
                // Store soome data using first key-value pair.
                string someData = "Green";
                ViewBag.Color = someData;
                HttpContext.Session.SetString(SOME_SESSION_DATA, someData);

                // Store more data using second key-value pair.
                DateTime now = DateTime.Now;
                ViewBag.SessionStart = now.ToString();
                HttpContext.Session.SetString(MORE_SESSION_DATA, now.ToString());
            }
            // Session data exists so show it.
            else
            {
                ViewBag.Color = HttpContext.Session.GetString(SOME_SESSION_DATA);
                ViewBag.SessionStart = HttpContext.Session.GetString(MORE_SESSION_DATA);
            }

            return View();
        }

        [HttpPost]
        public ActionResult Index(UserVM siteUser)
        {
            CookieHelper cookieHelper = new CookieHelper(_httpContextAccessor, Request,
                                                         Response);
            cookieHelper.Set("firstName", siteUser.firstName, 1);
            // Redirect GET method so cookie is read.
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ClearCookie(string key)
        {
            CookieHelper cookieHelper = new CookieHelper(_httpContextAccessor, Request,
                                                         Response);
            cookieHelper.Remove(key);
            return RedirectToAction("Index", "Home");
        }


        public IActionResult About()
        {
            ViewData["Message"] = "About Our Company";
            HttpContext.Session.Clear();

            return View();
        }

        public IActionResult Contact()
        {
            if (new EmailHelper(_emailSettings).SendMail("", "Test Mail from SendGrid", "esauder@shaw.ca"))
                return RedirectToAction("Index");
            return RedirectToAction("Error");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
