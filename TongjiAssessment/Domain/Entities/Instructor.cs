using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TongjiAssessment.Domain.Entities
{
    public class Instructor
    {
        public string Ins_id { get; set; }
        public string Ins_name { get; set; }
        public string Dept_name { get; set; }
        public string Email { get; set; }
        public string Introduction { get; set; }
        public string Homepage { get; set; }
        public string Icon_path { get; set; }
        public string Profession { get; set; }
        //老师上的课程
        public List<Course> Courses { get; set; }
    }
}