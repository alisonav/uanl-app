using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace UANL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Title = "Login";

            return View();
        }

        public ActionResult NewUser()
        {
            ViewBag.Title = "New User";

            return View();
        }

        public ActionResult UserProfile()
        {
            ViewBag.Title = "My Profile";

            return View();
        }

        public ActionResult ChangePassword()
        {
            ViewBag.Title = "Change Password";

            return View();
        }

        [System.Web.Services.WebMethod]
        public string AuthenticateUser(string userName, string pass)
        {
            DataTable dtResult = new DataTable();
            dtResult = new Models.DAO.Users().GetUserByUsernameAndPassword(userName, pass);

            if (dtResult.Rows.Count > 0)
                return "OK";
            else
                return "Invalid User";
        }
    }
}