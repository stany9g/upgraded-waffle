using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractise
{
    public class Trader
    {
        public string Name { get; private set; }
        public string City { get; private set; }

        public bool IsVegetarian { get; private set; }

        public Trader(string n, string c, bool isVegetarian)
        {
            Name = n;
            City = c;
            IsVegetarian = isVegetarian;
        }

        public override string ToString()
        {
            return $"Trader {Name} in {City} is {IsVegetarian} vegetarian";
        }
    }
}
