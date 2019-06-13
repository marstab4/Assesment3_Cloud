using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assessment3_Graded.Controllers
{
    public class HomeController : Controller
    {
        // Displays Home Index page where users can login in
        /// <summary>
        /// Displays Home Index page where users can login
        /// </summary>
        /// <returns>
        /// A web page for users to be able to login and view about us and contact page
        /// </returns>
        public ActionResult Index()
        {
            return View();
        }

        // Displays About page
        /// <summary>
        /// Displays the About page for authorized members only
        /// </summary>
        /// <returns>
        /// An about us page for authorized members , for non authorized a login
        /// </returns>
        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        // Displays Contact
        /// <summary>
        /// Displays the Contact page on the web.
        /// </summary>
        /// <returns>
        /// A web page showing contact details.
        /// </returns>
        [Authorize]
        public ActionResult Contact()
        {
            String strSomeMessage = "Your Contact Page";
            ViewBag.Message = strSomeMessage;

            return View();
        }

        // Displays Members page
        /// <summary>
        /// Displays the Members page for authorized members only
        /// </summary>
        /// <returns>
        /// A Members page for authorized members , for non authorized a login
        /// </returns>

        [Authorize]
        public ActionResult Members()
        {
            return RedirectToAction("Index", "Members");
        }

    }
}