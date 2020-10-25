using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractise
{
    public class Transaction
    {
        public Trader Trader { get; private set; }
        public int Year { get; private set; }
        public int Value { get; private set; }

        public Transaction(Trader trader, int year, int value)
        {
            Trader = trader;
            Year = year;
            Value = value;
        }

        public override string ToString()
        {
            return $"[{Trader}, year: {Year}, value: {Value}]";
        }
    }
}
