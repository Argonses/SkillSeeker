using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSeeker.Shared
{
    public class Course
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty; 
        public string Location { get; set; } = string.Empty;
        public DateTime StartDate { get; set; } 
        public DateTime EndDate { get; set; } 
        public int Capacity { get; set; } 
        public decimal Price { get; set; }
        public string Instructor { get; set; } = string.Empty;
    }

}
