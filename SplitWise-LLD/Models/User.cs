using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitWise_LLD.Models
{
    public class User
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; }

        public User(string name)
        {
            Name = name;
        }
    }
}
