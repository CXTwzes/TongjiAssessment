using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TongjiAssessment.Domain.Abstract;
using TongjiAssessment.Domain.Entities;

namespace TongjiAssessment.Domain.Concrete
{
    public class DAOInstructorRepository : IInstructorRepository
    {
        public IEnumerable<Instructor> Instructors
        {
            get
            {
                return Dao.getInstructorList();

            }
        }
    }
}