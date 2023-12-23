using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CV_Project.Models
{
    public class Education
    {
        public int Id { get; set; }
        [Required,StringLength(20)]
        public string Title { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        [Required, StringLength(300)]
        public string Description { get; set; }
        [Required]
        public int StartYear { get; set; }
      
        public int FinishYear { get; set; }

        public Info Info { get; set; }
        public int InfoId { get; set; }
    }
}