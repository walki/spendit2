using System;

namespace SpendIt.Services
{
    public interface IExpenseService
    {
        void AddExpense(string from, string what, decimal amount, DateTime when, string comment);
    }
}