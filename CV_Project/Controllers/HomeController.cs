using CV_Project.Context;
using CV_Project.Entities;
using CV_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV_Project.Controllers
{
    public class HomeController : Controller
    {
        ProjectContext db = new ProjectContext();
        // GET: Home
        public ActionResult Index()
        {
            var user = db.Infos.Include("SocialMedias").Include("Educations").Include("Experiences").Include("Skills").Include("Portfolios").FirstOrDefault(i => i.Id == 1);
            return View(user);
        }   
        
        public PartialViewResult Detail(int id)
        {
            var model = db.Portfolios.Where(i => i.Id == id).FirstOrDefault();

            return PartialView("_PartialDetail", model);
        }
        public ActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {

            var user = db.User.FirstOrDefault(i => i.Username == username && i.Password == password);
            if (user != null)
            {
               
                CurrentSession.Set<User>("login", user);
                return RedirectToAction("About","Admin");
            }
            else
            {
                ViewBag.login = "Giriş bilgileriniz Hatalı!!";
                return View();

            }
        }
    }
}