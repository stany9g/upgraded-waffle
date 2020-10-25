using System;
using System.Diagnostics;

namespace BigO
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();
            //Call
            sw.Stop();
            Console.WriteLine($"Elapsed: {sw.Elapsed}");
        }

        public void PrintFirstItem(int[] items)
        {
            Console.WriteLine(items[0]);
        }

        public void PrintAllItems(int[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintAllPossibleOrderedPairs(int[] items)
        {
            foreach (var firstItem in items)
            {
                foreach (var secondItem in items)
                {
                    Console.WriteLine($"{firstItem}, {secondItem}");
                }
            }
        }

        public void SayHiNTimes(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("hi");
            }
        }

        public void PrintAllItemsTwice(int[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            // Once more, with feeling
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintFirstItemThenFirstHalfThenSayHi100Times(int[] items)
        {
            Console.WriteLine(items[0]);

            int middleIndex = items.Length / 2;
            int index = 0;

            while (index < middleIndex)
            {
                Console.WriteLine(items[index]);
                index++;
            }

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("hi");
            }
        }

        public void PrintAllNumbersThenAllPairSums(int[] numbers)
        {
            Console.WriteLine("these are the numbers:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("and these are their sums:");
            foreach (var firstNumber in numbers)
            {
                foreach (var secondNumber in numbers)
                {
                    Console.WriteLine(firstNumber + secondNumber);
                }
            }
        }

        public bool Contains(int[] haystack, int needle)
        {
            // Does the haystack contain the needle?
            foreach (var n in haystack)
            {
                if (n == needle)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
