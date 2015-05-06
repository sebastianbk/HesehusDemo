using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebApplication12.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication12.Controllers
{
    public class HomeController : Controller
    {
        private IBlogRepo _repo;

        public HomeController(IBlogRepo repo)
        {
            _repo = repo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var post = _repo.GetPost();
               
            return View(post);
        }
    }
}
