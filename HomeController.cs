using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestASS2.Models;

namespace TestASS2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        JoinedTables db = new JoinedTables();
        public ActionResult Index()

        {
           
            List<coutbl> c = db.coutbls.ToList();
            return View(c);
        }
        public ActionResult studentinfo(int id)
        {
            List<Stutable> stu = db.Stutables.Where(s => s.course_id == id).ToList();
            return View(stu);

        }
    }
}