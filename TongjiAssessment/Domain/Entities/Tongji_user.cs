using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TongjiAssessment.Domain.Entities
{
    public class Tongji_user
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Blog_home_page { get; set; }
        public string Icon_path { get; set; }
        public string Info { get; set; }

        public List<Course> Follow_courses { get; set; }
        public List<Instructor> Follow_instructors { get; set; }
        public List<Post> Submit_posts { get; set; }
        public List<Comment> Submit_comment { get; set; }
    }
}