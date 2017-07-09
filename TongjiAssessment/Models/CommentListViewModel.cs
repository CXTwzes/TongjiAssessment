using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongjiAssessment.Domain.Entities;

namespace TongjiAssessment.Models
{
    public class CommentListViewModel
    {
        public IEnumerable<Comment> Comments { get; set; }
        public IEnumerable<string> Categories { get; set; }

        public PagingInfo PagingInfo { get; set; }

        public string CurrentCategory { get; set; }

        public IEnumerable<Comment> HotCommnents { get; set; }
    }
}