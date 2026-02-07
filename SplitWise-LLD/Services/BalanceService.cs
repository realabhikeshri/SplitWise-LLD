using SplitWise_LLD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitWise_LLD.Services
{
    public class BalanceService
    {
        public Dictionary<(User From, User To), decimal> CalculateBalances(List<Expense> expenses)
        {
            var balances = new Dictionary<(User, User), decimal>();

            foreach (var expense in expenses)
            {
                foreach (var split in expense.Splits)
                {
                    if (split.User.Id == expense.PaidBy.Id)
                        continue;

                    var key = (split.User, expense.PaidBy);

                    balances[key] = balances.GetValueOrDefault(key) + split.Amount;
                }
            }

            return balances;
        }
    }
}
