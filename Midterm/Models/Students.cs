using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Midterm.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CoursesId { get; set; }
        public DateTime CourseEnrolledDate { get; set; }
        public int CourseStatus { get; set; }
        public string Grade { get; set; }

        public CoursesAvailable CoursesAvailable { get; set; }

    }
}