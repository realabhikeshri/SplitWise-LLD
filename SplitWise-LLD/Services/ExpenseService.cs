using SplitWise_LLD.Enums;
using SplitWise_LLD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitWise_LLD.Services
{
    public class ExpenseService
    {
        private readonly List<Expense> _expenses = new();

        public Expense AddExpense(string description, decimal amount,
                                  User paidBy, SplitType splitType,
                                  List<User> participants,
                                  List<decimal>? values = null)
        {
            var splits = new List<Split>();

            switch (splitType)
            {
                case SplitType.Equal:
                    var equalShare = amount / participants.Count;
                    participants.ForEach(u => splits.Add(new Split(u, equalShare)));
                    break;

                case SplitType.Exact:
                    for (int i = 0; i < participants.Count; i++)
                        splits.Add(new Split(participants[i], values![i]));
                    break;

                case SplitType.Percentage:
                    for (int i = 0; i < participants.Count; i++)
                        splits.Add(new Split(participants[i], amount * values![i] / 100));
                    break;
            }

            var expense = new Expense(description, amount, paidBy, splitType, splits);
            _expenses.Add(expense);
            return expense;
        }

        public List<Expense> GetAllExpenses() => _expenses;
    }
}
