using CV_Project.Context;
using CV_Project.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Razor.Generator;

namespace CV_Project.Controllers
{
    [Auth]

    public class AdminController : Controller
    {
        ProjectContext db = new ProjectContext();

        // GET: Admin
        public ActionResult About()
        {
            var user = db.Infos.Include("SocialMedias").Where(i => i.Id == 1).FirstOrDefault();
            ViewModelAbout model = new ViewModelAbout();
            model.Age = user.Age;
            model.SocialMedias = user.SocialMedias;
            model.Surname = user.Surname;
            model.Name = user.Name;
            model.Email = user.Email;
            model.Coverletter = user.Coverletter;
            return View(model);
        }

        [HttpPost]
        public ActionResult About(ViewModelAbout model)
        {
            var user = db.Infos.FirstOrDefault(i => i.Email == model.Email);

            user.Coverletter = model.Coverletter;
            user.Name = model.Name;
            user.Age = model.Age;
            user.Email = model.Email;
            user.Surname = model.Surname;

            db.SaveChanges();

            return RedirectToAction("About");
        }

        public ActionResult Education()
        {
            var edus = db.Educations.Where(i => i.InfoId == 1).ToList();

            List<ViewModelEducation> models = new List<ViewModelEducation>();
            foreach (Education edu in edus)
            {
                ViewModelEducation model = new ViewModelEducation();
                model.Id = edu.Id;
                model.Title = edu.Title;
                model.FinishYear = edu.FinishYear;
                model.StartYear = edu.StartYear;
                model.Name = edu.Name;
                model.Description = edu.Description;

                models.Add(model);
            }

            return View(models);
        }

        [HttpPost]
        public ActionResult Education(ViewModelEducation model)
        {

            var education = db.Educations.FirstOrDefault(i => i.Id == model.Id);

            education.StartYear = model.StartYear;
            education.FinishYear = model.FinishYear;
            education.Description = model.Description;
            education.Name = model.Name;
            education.Title = model.Title;

            db.SaveChanges();

            return RedirectToAction("Education");
        }

        public ActionResult Experience()
        {
            var edus = db.Experiences.Where(i => i.InfoId == 1).ToList();

            List<ViewModelEducation> models = new List<ViewModelEducation>();
            foreach (Experience edu in edus)
            {
                ViewModelEducation model = new ViewModelEducation();
                model.Id = edu.Id;
                model.Title = edu.Title;
                model.FinishYear = edu.FinishYear;
                model.StartYear = edu.StartYear;
                model.Name = edu.Name;
                model.Description = edu.Description;

                models.Add(model);
            }

            return View(models);
        }

        [HttpPost]
        public ActionResult Experience(ViewModelEducation model)
        {

            var experience = db.Experiences.FirstOrDefault(i => i.Id == model.Id);

            experience.StartYear = model.StartYear;
            experience.FinishYear = model.FinishYear;
            experience.Description = model.Description;
            experience.Name = model.Name;
            experience.Title = model.Title;

            db.SaveChanges();

            return RedirectToAction("Experience");
        }

        public ActionResult Skill()
        {
            var skills = db.Skills.Where(i => i.InfoId == 1).ToList();

            return View(skills);
        }

        [HttpPost]
        public ActionResult Skill(Skill model)
        {

            var skl = db.Skills.FirstOrDefault(i => i.Id == model.Id);

            skl.Name = model.Name;
            skl.Range = model.Range;

            db.SaveChanges();

            return RedirectToAction("Skill");
        }
        public ActionResult Portfolio()
        {
            var ports = db.Portfolios.Where(i => i.InfoId == 1).ToList();

            return View(ports);
        }

        [HttpPost]
        public ActionResult Portfolio(Portfolio model, HttpPostedFileBase image)
        {

            var prt = db.Portfolios.FirstOrDefault(i => i.Id == model.Id);

            prt.Title = model.Title;
            prt.Solution = model.Solution;
            prt.Description = model.Description;
            prt.Client = model.Client;
            prt.TimeTaken = model.TimeTaken;
            prt.Challenge = model.Challenge;

            if (image != null)
            {
               

                string Filename = image.FileName.Split('.')[0] +".jpg";

                image.SaveAs(Server.MapPath($"~/Content/img/portfolio/{Filename}"));
                prt.ImageUrl = Filename;

            }

            if (model.Date != DateTime.MinValue)
                    prt.Date = model.Date;


                    db.SaveChanges();



                return RedirectToAction("Portfolio");
            
        }
    }
}