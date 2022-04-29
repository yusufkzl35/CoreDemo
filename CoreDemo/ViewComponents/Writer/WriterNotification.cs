using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterNotification:ViewComponent
    {
       NotificationManager bm = new NotificationManager(new EfNotificationRepository());
        public IViewComponentResult Invoke()
        {
             var values = bm.GetList();
            return View(values);
        }
    }
}
