using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitWise_LLD.Models
{
    public class Split
    {
        public User User { get; }
        public decimal Amount { get; }

        public Split(User user, decimal amount)
        {
            User = user;
            Amount = amount;
        }
    }
}
