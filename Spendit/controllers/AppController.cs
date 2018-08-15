using Microsoft.AspNetCore.Mvc;
using SpendIt.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpendIt.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("expense")]
        public IActionResult Expense()
        {
            ViewBag.Title = "Add Expense";

            return View();
        }

        [HttpPost("expense")]
        public IActionResult Expense(ExpenseViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Add the Expense
            }
            else
            {
                // Show Errors
            }

            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";

            return View();
        }
    }
}
