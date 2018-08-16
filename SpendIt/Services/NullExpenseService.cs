using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpendIt.Services
{
    public class NullExpenseService : IExpenseService
    {
        private readonly ILogger<NullExpenseService> logger;

        public NullExpenseService(ILogger<NullExpenseService> logger)
        {
            this.logger = logger;
        }

        public void AddExpense(string from, string what, decimal amount, DateTime when, string comment)
        {
            // Log the expense
            logger.LogInformation($"From: {from} What: {what} Amount: {amount} When: {when}");
        }
    }
}
