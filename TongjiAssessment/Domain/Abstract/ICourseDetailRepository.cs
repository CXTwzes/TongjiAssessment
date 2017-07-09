using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TongjiAssessment.Domain.Entities;

namespace TongjiAssessment.Domain.Abstract
{
    interface ICourseDetailRepository
    {
        IEnumerable<CourseDetail> Comments(string course_id, string inst_id);
    }
}
