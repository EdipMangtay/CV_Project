using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CV_Project.Models
{
    public class ViewModelEducation
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int StartYear { get; set; }

        public int FinishYear { get; set; }
    }
}