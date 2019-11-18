using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Week_V___MVCIntro.Models;

namespace Week_V___MVCIntro.Controllers
{
    public class ListController : Controller
    {
        public IActionResult Index()
        {
            DatabaseContext context = new DatabaseContext();

            return View(context.TodoLists.OrderBy(x=>x.Deadline).ToList());
        }

        public IActionResult Hello()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            DatabaseContext context = new DatabaseContext();

            var item = from list in context.TodoLists
                       where list.Id == id
                       select list;

            return View(item.FirstOrDefault());
        }
    }
}