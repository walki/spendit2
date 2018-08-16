using Microsoft.AspNetCore.Mvc;
using SpendIt.Services;
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
        private readonly IExpenseService expenseService;
        private readonly IDateService dateService;

        public AppController(IExpenseService expenseService, IDateService dateService)
        {
            this.expenseService = expenseService;
            this.dateService = dateService;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("expense")]
        public IActionResult Expense()
        {
            ViewBag.Title = "Add Expense";
            ViewBag.DefaultDate = $"{dateService.GetToday():yyyy-MM-dd}";
            return View();
        }

        [HttpPost("expense")]
        public IActionResult Expense(ExpenseViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Add the Expense
                expenseService.AddExpense(model.From, model.What, model.Amount, model.Date, model.Comment);
                ViewBag.UserMessage = "Expense added.";
                ModelState.Clear();
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
