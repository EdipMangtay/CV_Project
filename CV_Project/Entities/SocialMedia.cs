using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CV_Project.Models
{
    public class SocialMedia
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Icon { get; set; }

        [Required]
        public string Link { get; set; }

        //Mapping

        public Info Info { get; set; }
        public int InfoId { get; set; }
    }
}