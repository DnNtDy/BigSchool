using BigSchool.Models;
using BigSchool.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigSchool.Controllers
{
    public class CoursesControllerController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CoursesControllerController() 
        {
            _dbContext = new ApplicationDbContext();        
        }
        // GET: CoursesController
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}