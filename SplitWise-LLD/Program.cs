using SplitWise_LLD.Enums;
using SplitWise_LLD.Models;
using SplitWise_LLD.Services;

var u1 = new User("Abhishek");
var u2 = new User("Rahul");
var u3 = new User("Neha");

var expenseService = new ExpenseService();
var balanceService = new BalanceService();

expenseService.AddExpense(
    "Dinner",
    900,
    u1,
    SplitType.Equal,
    new List<User> { u1, u2, u3 }
);

var balances = balanceService.CalculateBalances(expenseService.GetAllExpenses());

foreach (var balance in balances)
{
    Console.WriteLine($"{balance.Key.From.Name} owes {balance.Key.To.Name} ₹{balance.Value}");
}
