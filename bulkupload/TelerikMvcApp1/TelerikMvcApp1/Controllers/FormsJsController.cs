using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelerikMvcApp1.Models;

namespace TelerikMvcApp1.Controllers
{
    public class FormsJsController : Controller
    {
        // GET: FormsJs
        public ActionResult Index()
        {
            return View(GetAll());
        }

        public IList<Form3A> GetAll()
        {
            var result = new List<Form3A>();
            return result;
        }
    }
}