using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class DashboardController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            Context c = new Context();

            var username = User.Identity.Name;
          
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();

            var writerid=c.Writers.Where(x=>x.WriterMail==usermail).Select(y=>y.WriterID).FirstOrDefault();//yazarın ıd ye göre mail i çekiyor
            ViewBag.v1 = c.Blogs.Count().ToString();
            ViewBag.vpm = c.Blogs.Where(x => x.WriterID == writerid).Count();//sisteme kim otantike olmuşşsa ona ait veriler gelsin
            
            ViewBag.v3 = c.Categories.Count().ToString();
            return View();
        }
    }
}
