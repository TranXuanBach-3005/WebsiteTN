using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteTN.Models;

namespace WebsiteTN.Controllers
{
    public class BlogsController : Controller
    {
        private readonly DataDbContext _context;

        public BlogsController(DataDbContext context)
        {
            _context = context;
        }
        [Route("blogs.html", Name =("Blog"))]
        public IActionResult Index(int? page)
        {
            var postFocuses = _context.Posts.AsNoTracking().Where(x => x.IsNewfeed == true && x.Published == true).FirstOrDefault();
            if(postFocuses != null)
            {
                ViewBag.PostFocuses = postFocuses;
            }
            else
            {
                ViewBag.PostFocuses = _context.Posts.AsNoTracking().Where(x => x.Published == true).OrderBy(x => x.CreatedDate).FirstOrDefault();
            }
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 10;
            var posts = _context.Posts.AsNoTracking()
                                      .Where(x => x.Published == true)
                                      .OrderBy(x => x.PostId);
            PagedList<Post> models = new PagedList<Post>(posts, pageNumber, pageSize);
            ViewBag.CurrentPage = pageNumber;
            return View(models);
        }
        [Route("/tin-tuc/{Alias}-{id}.html", Name ="PostDetail")]
        public IActionResult Details(int id)
        {
            var post = _context.Posts.Find(id);
            if(post == null)
            {
                return RedirectToAction("Index");
            }
            if (post != null)
            {
                _context.Posts.Attach(post);
                post.Views = post.Views + 1;
                _context.Entry(post).Property(x => x.Views).IsModified = true;
                _context.SaveChanges();
            }
            var postFocusesDetail = _context.Posts.AsNoTracking()
                                            .Where(x => x.Published == true && x.IsHot == true).FirstOrDefault();
            var postRelated = _context.Posts.AsNoTracking()
                                            .Where(x => x.Published == true && x.PostId != id)
                                            .Take(6)
                                            .OrderByDescending(x => x.CreatedDate).ToList();
            ViewBag.PostFocusesDetail = postFocusesDetail;
            ViewBag.PostRelated = postRelated;
            return View(post);
        }
    }
}
