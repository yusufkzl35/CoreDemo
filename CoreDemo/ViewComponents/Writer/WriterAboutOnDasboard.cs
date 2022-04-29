using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterAboutOnDasboard:ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

       // private readonly UserManager<AppUser> _userManager;
        Context c = new Context();

        //public WriterAboutOnDasboard(UserManager<AppUser> userManager)
        //{
        //    _userManager = userManager;
        //}

        public  IViewComponentResult Invoke()

        {
          //  var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var username = User.Identity.Name;
            ViewBag.veri = username;
           
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            ViewBag.mail1 = usermail;

            var userimage= c.Users.Where(x => x.UserName == username).Select(y => y.ImageUrl).FirstOrDefault();
            ViewBag.Image1 = userimage;

            //var userabout=c.Users.Where(x => x.UserName == username).Select(y => y.Writer_about).FirstOrDefault();
            //ViewBag.about1 = userabout;


            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = wm.GetWriterById(writerID);//SİSTEME OTANTİKE OLAN KULLANICIYI GETİRİR
        
            return View(values);
        }
    }
}
