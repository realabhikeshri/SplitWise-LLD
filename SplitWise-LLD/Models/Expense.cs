using SplitWise_LLD.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitWise_LLD.Models
{
    public class Expense
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Description { get; }
        public User PaidBy { get; }
        public decimal Amount { get; }
        public SplitType SplitType { get; }
        public List<Split> Splits { get; }

        public Expense(string description, decimal amount, User paidBy,
                       SplitType splitType, List<Split> splits)
        {
            Description = description;
            Amount = amount;
            PaidBy = paidBy;
            SplitType = splitType;
            Splits = splits;
        }
    }
}
