using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TongjiAssessment.Domain.Entities
{
    public class Floor
    {
        public string Flo_id { get; set; }
        public string Post_id { get; set; }
        public string Username { get; set; }
        public DateTime Flo_time { get; set; }
        public string Flo_content { get; set; }
        public string Flo_count { get; set; }
    }

}