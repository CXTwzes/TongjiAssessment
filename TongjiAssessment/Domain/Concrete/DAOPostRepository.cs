using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongjiAssessment.Domain.Abstract;
using TongjiAssessment.Domain.Entities;
using TongjiAssessment.Models;

namespace TongjiAssessment.Domain.Concrete
{
    public class DAOPostRepository : IPostRepository
    {
        public IEnumerable<Post> Posts
        {
            get
            {
                return Dao.getPostList();
            }
        }
    }
}