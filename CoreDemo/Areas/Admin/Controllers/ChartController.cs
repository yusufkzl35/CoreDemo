using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();

            list.Add(new CategoryClass
            {
                categoryname = "teknoloji",
                categorycount = 6
            });


            list.Add(new CategoryClass { categoryname = "yazılım", categorycount = 3 });
            list.Add(new CategoryClass { categoryname = "spor", categorycount = 5 });

            return Json(new { jsonlist = list });
        }


    }

    
}
