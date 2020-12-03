using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Midterm.Models
{
    public class Courses
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string TutorName { get; set; }
        public int CourseRating { get; set; }
    }
}