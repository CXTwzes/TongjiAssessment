using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TongjiAssessment.Domain.Entities
{
    public class Post
    {
        public string Post_id { get; set; }
        public string Username { get; set; }
        public string Post_time { get; set; }
        public string Title { get; set; }
        public string Post_content { get; set; }
        public int Page_view { get; set; }

        public int Supports { get; set; }
    }
}