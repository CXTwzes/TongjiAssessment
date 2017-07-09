using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TongjiAssessment.Domain.Entities
{
    public class Comment
    {
        public string Comment_id { get; set; }
        public int Com_score { get; set; }
        public int Quality { get; set; }
        public int Work_amount { get; set; }
        public int Harvest { get; set; }
        public DateTime Date { get; set; }
        public string Com_content { get; set; }
        public string Course_id { get; set; }
        public string Ins_id { get; set; }
        public string Ins_name { get; set; }
        public string Username { get; set; }
        public string Category { get; set; }

        public int Support { get; set; }
        public Tongji_user Tongji_user { get; set; }
    }
}