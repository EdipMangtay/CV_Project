using CV_Project.Entities;
using CV_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CV_Project.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext():base("Server=MANGTAY\\SQLDERS;Database=CVDB;Integrated Security=true")
        {
            Database.SetInitializer(new MyInitializer());
        }
        public DbSet<Info> Infos { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<User> User { get; set; }

    }
}