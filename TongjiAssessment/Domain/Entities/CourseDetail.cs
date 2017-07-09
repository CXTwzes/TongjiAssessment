using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TongjiAssessment.Domain.Entities
{
    public class CourseDetail
    {
        public string CourseName { get; set; }
        public string Category { get; set; }
        public string Semester { get; set; }
        public string Year { get; set; }
        public string SecId { get; set; }
        public string Difficult { get; set; }
        public string Homework { get; set; }
        public string Score { get; set; }
        public string Rate { get; set; }
    }
}