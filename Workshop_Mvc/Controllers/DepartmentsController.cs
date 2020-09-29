using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Workshop_Mvc.Models;

namespace Workshop_Mvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List < Department > list = new List <Department>();
            list.Add(new Department { id = 1, nome = "Computador" });
            list.Add(new Department { id = 2, nome = "ssd m2" });
            return View(list);
        }
    }
}