using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Menu.Models;

namespace Menu.Controllers
{
    public class MenuController : Controller
    {
        private barcodedbContext db;
        public MenuController(barcodedbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            
            ViewBag.listfun = db.UserFunctions.Where(n => n.UfLnuCode == 1).ToList();

            //int x=db.UserFunctions.Where(n => n.UfLnuCode == 1).Select(n=>n.UfFuncCode).FirstOrDefault();
            //ViewBag.list = db.SysFunctions.Where(n => n.SysFuncCode == x).ToList();

            return View();
        }
    }
}
