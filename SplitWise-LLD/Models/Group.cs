using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitWise_LLD.Models
{
    public class Group
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; }
        public List<User> Members { get; } = new();

        public Group(string name)
        {
            Name = name;
        }

        public void AddMember(User user)
        {
            Members.Add(user);
        }
    }
}
