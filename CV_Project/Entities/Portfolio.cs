using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CV_Project.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string Client { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string TimeTaken { get; set; }
        [Required]
        public string Description { get; set; }
        [Required] 
        public string Challenge { get; set; }
        [Required] 
        public string Solution { get; set; }

        public int InfoId { get; set; }
        public Info Info { get; set; }
    }
}