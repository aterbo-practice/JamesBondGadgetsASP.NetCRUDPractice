using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BondGadgetPracticeCRUD.Controllers
{
    public class GadgetsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}