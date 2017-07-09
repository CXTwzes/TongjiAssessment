using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TongjiAssessment.Domain.Entities
{
    public class Course
    {
        public string Course_id { get; set; }
        public string Cour_name{ get; set; }
        public string Cour_book { get; set; }
        public string Cour_credits { get; set; }
        public string Dept_name { get; set; }
        public string Category { get; set; }

        //每一门课
        public string Semester { get; set; }
        public string Year { get; set; }
        public string SecId { get; set; }

        //平均
        public int Com_score { get; set; } 
        public int Quality { get; set; }
        public int Work_amount { get; set; }
        public int Harvest { get; set; }
        //老师
        public string Ins_id { get; set; }
        public string Ins_name { get; set; }

    }
}