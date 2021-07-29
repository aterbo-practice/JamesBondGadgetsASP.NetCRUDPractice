using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BondGadgetPracticeCRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace BondGadgetPracticeCRUD.Controllers
{
    public class GadgetsController : Controller
    {
        public IActionResult Index()
        {

            //generate fake data for testing view
            List<GadgetModel> gadgets = new List<GadgetModel>();
            gadgets.Add(new GadgetModel(0, "Gun", "Secret gun", "Moonraker", "Actor Name"));

            gadgets.Add(new GadgetModel(1, "Spear", "Secret spear", "Fun Movie title", "Actor Name"));

            gadgets.Add(new GadgetModel(2, "Poison", "Special poison", "Moonraker", "Brosnen"));

            gadgets.Add(new GadgetModel(3, "Cell Phone", "Secret cell phone", "Moonraker", "Actor Name"));

            gadgets.Add(new GadgetModel(4, "Trampoline Shoes", "Boing Boing Boing", "Casino Royale", "Craig"));

            return View("Index", gadgets);
        }
    }
}