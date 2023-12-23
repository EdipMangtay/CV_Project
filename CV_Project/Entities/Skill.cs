using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CV_Project.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Range { get; set; }

        public Info Info { get; set; }
        public int InfoId { get; set; }
    }
}