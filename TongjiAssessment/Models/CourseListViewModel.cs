using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongjiAssessment.Domain.Entities;

namespace TongjiAssessment.Models
{
    public class CourseListViewModel
    {
        public IEnumerable<Course> Courses { get; set; }

        public PagingInfo PagingInfo { get; set; }
    }
}