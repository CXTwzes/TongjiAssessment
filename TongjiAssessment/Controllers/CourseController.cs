using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TongjiAssessment.Domain.Abstract;
using TongjiAssessment.Models;

namespace TongjiAssessment.Controllers
{
    public class CourseController : Controller
    {
        private ICourseRepository repository;
        public int PageSize = 8;
        public CourseController(ICourseRepository repository)
        {
            this.repository = repository;
        }
        // GET: Course
       
        public ViewResult List(int page = 1)
        {
            CourseListViewModel model = new CourseListViewModel
            {
                Courses = repository.Courses
                .OrderBy(p => p.Course_id)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Courses.Count()
                }
            };
            return View(model);
        }
    }
}