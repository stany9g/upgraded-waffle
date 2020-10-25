using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LinqTwo.DataSources;

namespace LinqTwo
{
    public class Task
    {
        // Restriction operators

        /// <summary>
        /// Returns numbers which are less than
        /// </summary>
        public IEnumerable<int> NumberLessThan(int than, int[] numbers)
        {
            return from number in numbers
                   where number < than
                   select number;

            //return numbers.Where(x => x < than);
        }

        /// <summary>
        /// Return digits whose name is shorter than their value, use LINQ!
        /// HINT: Lambda can have multiple input params - read what
        /// </summary>
        public IEnumerable<string> DigitsShorterThanValue(string[] digits)
        {
            return new List<string>();
        }


        /// <summary>
        /// In <see cref="indexes"/> number represents and index, by this index return strings from <see cref="strings"/>
        /// </summary>
        public IEnumerable<string> SelectStringByIndexInNumbers(int[] indexes, string[] strings)
        {
            return new List<string>();
        }


        /// <summary>
        /// Filter customers from <see cref="region"/> and their orders greater than <see cref="date"/> and return list of strings in format
        /// "Customer: {order.CustomerID}, Order: {order.OrderID}"
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> MultipleConditions(List<Customer> customers, DateTime date, string region)
        {
            return new List<string>();
        }


        /// <summary>
        /// Use Take function
        /// </summary>
        public IEnumerable<int> TakeElements(int[] numbers, int take)
        {
            return new List<int>();
        }

        /// <summary>
        /// Use Skip function
        /// </summary>
        public IEnumerable<int> SkipElements(int[] numbers, int skip)
        {
            return new List<int>();
        }

        /// <summary>
        /// Return elements starting from the beginning of the array until a number is hit that is less than its position in the array
        /// </summary>
        public IEnumerable<int> TakeWhileElements(int[] numbers)
        {
            return new List<int>();
        }

        /// <summary>
        /// Get the elements of the array starting from the first element less than its position
        /// </summary>
        public IEnumerable<int> SkipWhileElements(int[] numbers)
        {
            return new List<int>();
        }
    }
}