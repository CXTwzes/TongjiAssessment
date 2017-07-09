using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongjiAssessment.Domain.Abstract;
using TongjiAssessment.Domain.Entities;

namespace TongjiAssessment.Domain.Concrete
{
    public class DAOCourseRepository : ICourseRepository
    {
        public IEnumerable<Course> Courses
        {
            get
            {
                return Dao.getCourseList();
                
            }
        }

    }
    
}
