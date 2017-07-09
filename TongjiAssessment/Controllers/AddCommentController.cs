using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TongjiAssessment.Controllers
{
    [Authorize]
    public class AddCommentController : Controller
    {
        // GET: AddAssessment
        public ActionResult Add()
        {
            return View();
        }
    }
}