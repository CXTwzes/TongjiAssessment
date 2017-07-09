using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TongjiAssessment.Domain.Abstract;
using TongjiAssessment.Models;

namespace TongjiAssessment.Controllers
{
    
    public class InstructorController : Controller
    {
        private IInstructorRepository repository;
        public int PageSize = 8;
        public InstructorController(IInstructorRepository repository)
        {
            this.repository = repository;
        }
        // GET: Instructor
       
        public ViewResult List(int page = 1)
        {
            InstructorListViewModel model = new InstructorListViewModel
            {
                Instructors = repository.Instructors
                .OrderBy(p => p.Ins_id)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Instructors.Count()
                }
            };
            return View(model);
        }
    }
}