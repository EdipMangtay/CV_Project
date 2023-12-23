using CV_Project.Entities;
using CV_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CV_Project.Context
{
    public class MyInitializer:CreateDatabaseIfNotExists<ProjectContext>
    {
        protected override void Seed(ProjectContext context)
        {
            Info user = new Info();
            user.Surname = "Demirci";
            user.Name = "Altan Emre";
            user.Coverletter = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.";
            user.Age = 34;
            user.Email = "altanemre@gmail.com";
            user.SocialMedias = new List<SocialMedia>()
            {
                new SocialMedia(){ Name="Instagram", Icon="fa-instagram", Link="https://www.instagram.com"},
                new SocialMedia(){ Name="Linkedin", Icon="fa-linkedin", Link="https://www.linkedin.com"},
                new SocialMedia(){ Name="Github", Icon="fa-github", Link="https://www.github.com"},
                new SocialMedia(){ Name="Twitter", Icon="fa-x-twitter", Link="https://www.twitter.com"}
            };

            user.Skills = new List<Skill>()
            {
                new Skill(){Name="C#",Range=90},
                new Skill(){Name="MSSQL",Range=90},
                new Skill(){Name="ASP.NET",Range=80},
                new Skill(){Name="HTML,CSS,JavaScript",Range=70},
                new Skill(){Name="PYTHON",Range=90},
                new Skill(){Name="ENTITY FRAMEWORK CORE",Range=90}
            };
            user.Experiences = new List<Experience>()
            {
                new Experience(){Title="Software Trainer",Name="Üçüncü Binyıl Akademi",Description="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",StartYear=2020},
                new Experience(){Title="Senior Developer",Name="Huawei Türkiye",Description="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",StartYear=2019,FinishYear=2020},
                new Experience(){Title="Middle Developer",Name="Opthema Teknoloji",Description="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",StartYear=2018,FinishYear=2019}
            };

            user.Educations = new List<Education>()
            {
                new Education(){Title="Lisans",Name="Gazi Üniversitesi",Description="Bilgisayar Sistemleri Öğretmenliği",StartYear=2008,FinishYear=2012},
               new Education(){Title="Lise",Name="İstanbul Lisesi",Description="Bilgisayar Bölümü",StartYear=2003,FinishYear=2007},
               new Education(){Title="Ortaokul",Name="Kemalhasoğlu İ.Ö.O.",Description="Orta öğrenim 3 yıl",StartYear=2000,FinishYear=2003}
            };

            user.Portfolios = new List<Portfolio>()
            {
                new Portfolio(){Title="Project1",ImageUrl="portfolio1.jpg",Client="Üçüncü Binyıl Akademi",Date=DateTime.Now.Date,TimeTaken="3 hafta",Description="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",Challenge="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",Solution="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout."},
                new Portfolio(){Title="Project2",ImageUrl="portfolio2.jpg",Client="Üçüncü Binyıl Akademi",Date=DateTime.Now.Date,TimeTaken="3 hafta",Description="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",Challenge="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",Solution="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout."},
                new Portfolio(){Title="Project3",ImageUrl="portfolio3.jpg",Client="Üçüncü Binyıl Akademi",Date=DateTime.Now.Date,TimeTaken="3 hafta",Description="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",Challenge="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",Solution="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout."},
                new Portfolio(){Title="Project4",ImageUrl="portfolio4.jpg",Client="Üçüncü Binyıl Akademi",Date=DateTime.Now.Date,TimeTaken="3 hafta",Description="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",Challenge="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",Solution="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout."}
            };


            context.Infos.Add(user);

            User admin = new User();
            admin.Username = "admin";
            admin.Password = "1";

            context.User.Add(admin);


            context.SaveChanges();
        }
    }
}