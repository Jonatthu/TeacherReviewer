using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TR.Web.ModelViews;

namespace TR.Web.Controllers
{
    public class UniversityController : Controller
    {
        // GET: University
        public ActionResult Index(string Id)
        {
            //Id is the name of the university
            //Method for search in the BD the university
            var SearchUniversity = new UniversityViewModel {
                Idd = Id
            };
            return View(SearchUniversity);
        }
    }
}