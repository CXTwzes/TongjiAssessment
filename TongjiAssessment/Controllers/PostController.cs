using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TongjiAssessment.Domain.Abstract;
using TongjiAssessment.Models;

namespace TongjiAssessment.Controllers
{
    public class PostController : Controller
    {
        private IPostRepository repository;
        public int PageSize = 4;
        public PostController(IPostRepository repository)
        {
            this.repository = repository;
        }
        // GET: Course
        public ViewResult List(int page = 1)
        {
            PostListViewModel model = new PostListViewModel
            {
                Posts = repository.Posts
                .OrderBy(p => p.Post_id)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Posts.Count()
                }
            };
            return View(model);
        }
    }
}