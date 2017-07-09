using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TongjiAssessment.Domain.Entities;

namespace TongjiAssessment.Domain.Abstract
{
    public interface ICourseRepository
    {
        IEnumerable<Course> Courses { get; }
    }
}
