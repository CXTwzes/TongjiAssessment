using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TongjiAssessment.Domain.Entities
{
    public static class Tongji
    {
        public static IEnumerable<string> getCategories()
        {
            return Dao.getCategoryList();

        }
    }
}