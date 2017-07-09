using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongjiAssessment.Domain.Abstract;
using TongjiAssessment.Domain.Entities;

namespace TongjiAssessment.Domain.Concrete
{
    public class DAOCourseDetailRepository : ICourseDetailRepository
    {
        
        public IEnumerable<CourseDetail> Comments(string course_id, string inst_id)
        {
            yield return Dao.getCourseDetail(course_id, inst_id);
        }
    }
}