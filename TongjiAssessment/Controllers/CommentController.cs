using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TongjiAssessment.Domain.Abstract;
using TongjiAssessment.Domain.Entities;
using TongjiAssessment.Models;

namespace TongjiAssessment.Controllers
{
    public class CommentController : Controller
    {
        private ICommentRepository repository;
        public int PageSize = 5;
        public CommentController(ICommentRepository repository)
        {
            this.repository = repository;
        }
        
       
        public ViewResult List(string category, int page = 1)
        {
            ViewBag.SeletedCategory = category;
            CommentListViewModel model = new CommentListViewModel
            {
                Comments = repository.Comments
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.Date)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),

                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ? repository.Comments.Count() :
                    repository.Comments.Where(e => e.Category == category).Count()
                },

                CurrentCategory = category,

                Categories = Tongji.getCategories()
            };
            return View(model);
        }
    }
}