using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CV_Project.Models
{
    public class Info
    {
        public int Id { get; set; }

        [Required,StringLength(25)]
        public string Name { get; set; }
        
        [Required, StringLength(25)]
        public string Surname { get; set; }

        [Required,StringLength(600)]
        public string Coverletter { get; set; }

        [Required, Range(1,100)]
        public int Age { get; set; }
        
        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public List<SocialMedia> SocialMedias { get; set; }   
        
        public List<Education> Educations { get; set; } 
        
        public List<Experience> Experiences { get; set; }  
        
        public List<Skill> Skills { get; set; }    

        public List<Portfolio> Portfolios { get; set; }    
        
        
    }

   
}