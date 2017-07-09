using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongjiAssessment.Domain.Entities;

namespace TongjiAssessment.Models
{
    public class PostListViewModel
    {
        public IEnumerable<Post> Posts { get; set; }

        public PagingInfo PagingInfo { get; set; }
    }
}