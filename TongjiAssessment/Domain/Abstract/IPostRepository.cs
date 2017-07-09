using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongjiAssessment.Domain.Entities;

namespace TongjiAssessment.Domain.Abstract
{
    public interface IPostRepository
    {
        IEnumerable<Post> Posts { get; }
    }
}