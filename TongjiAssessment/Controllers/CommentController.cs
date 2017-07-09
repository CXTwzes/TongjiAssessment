using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TongjiAssessment.Domain.Abstract;
using TongjiAssessment.Models;

namespace TongjiAssessment.Controllers
{
    public class CommentController : Controller
    {
        private ICommentRepository repository;
        public int PageSize = 8;
        public CommentController(ICommentRepository repository)
        {
            this.repository = repository;
        }
        
        public ViewResult List(int page = 1)
        {
            CommentListViewModel model = new CommentListViewModel
            {
                Comments = repository.Comments
                .OrderBy(p => p.Date)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Comments.Count()
                }
            };
            return View(model);
        }
    }
}