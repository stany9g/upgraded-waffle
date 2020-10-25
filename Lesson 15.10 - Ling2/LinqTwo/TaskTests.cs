using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using LinqTwo.DataSources;
using Xunit;

namespace LinqTwo
{
    public class TaskTests
    {
        private Task _task = new Task();

        [Fact]
        public void NumberLessThanTest()
        {
            // Arrange
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int than = 5;
            int[] expectedNumbers = { 4, 1, 3, 2, 0 };

            // Act
            var actualNumbers = _task.NumberLessThan(than, numbers);

            // Assert
            Assert.Equal(expectedNumbers, actualNumbers);
        }

        [Fact]
        public void DigitsShorterThanTheirValueTest()
        {
            // Arrange
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            string[] expectedStrings = { "five", "six", "seven", "eight", "nine" };

            // Act
            var actualDigits = _task.DigitsShorterThanValue(digits);

            // Assert
            Assert.Equal(expectedStrings, actualDigits);
        }

        [Fact]
        public void SelectStringByIndexInNumbersTest()
        {
            // Arrange
            int[] indexes = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            string[] expectedStrings = { "five", "four", "one", "three", "nine", "eight", "six", "seven", "two", "zero" };

            // Act
            var actualStrings = _task.SelectStringByIndexInNumbers(indexes, strings);

            // Assert
            Assert.Equal(expectedStrings, actualStrings);
        }

        [Fact]
        public void MultipleConditionsTest()
        {
            // Arrange
            var customers = Customers.CustomerList;
            var date = new DateTime(1997, 1, 1);
            var region = "WA";
            var expectedStrings = new List<string>
            {
                "Customer: LAZYK, Order: 10482",
                "Customer: LAZYK, Order: 10545",
                "Customer: TRAIH, Order: 10574",
                "Customer: TRAIH, Order: 10577",
                "Customer: TRAIH, Order: 10822",
                "Customer: WHITC, Order: 10469",
                "Customer: WHITC, Order: 10483",
                "Customer: WHITC, Order: 10504",
                "Customer: WHITC, Order: 10596",
                "Customer: WHITC, Order: 10693",
                "Customer: WHITC, Order: 10696",
                "Customer: WHITC, Order: 10723",
                "Customer: WHITC, Order: 10740",
                "Customer: WHITC, Order: 10861",
                "Customer: WHITC, Order: 10904",
                "Customer: WHITC, Order: 11032",
                "Customer: WHITC, Order: 11066",
            };

            // Act
            var actualStrings = _task.MultipleConditions(customers, date, region);

            // Assert
            Assert.Equal(expectedStrings, actualStrings);
        }


        [Fact]
        public void TakeElementsTest()
        {
            // Arrange
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int take = 4;
            int[] expectedNumbers = { 5, 4, 1, 3 };

            // Act
            var actualNumbers = _task.TakeElements(numbers, take);

            // Assert
            Assert.Equal(expectedNumbers, actualNumbers);
        }

        [Fact]
        public void SkipElementsTest()
        {
            // Arrange
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int skip = 7;
            int[] expectedNumbers = { 7, 2, 0 };

            // Act
            var actualNumbers = _task.SkipElements(numbers, skip);

            // Assert
            Assert.Equal(expectedNumbers, actualNumbers);
        }

        [Fact]
        public void TakeWhileElementsTest()
        {
            // Arrange
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int[] expectedNumbers = { 5, 4};

            // Act
            var actualNumbers = _task.TakeWhileElements(numbers);

            // Assert
            Assert.Equal(expectedNumbers, actualNumbers);
        }

        [Fact]
        public void SkipWhileElementsTest()
        {
            // Arrange
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int[] expectedNumbers = { 1, 3, 9, 8, 6, 7, 2, 0 };

            // Act
            var actualNumbers = _task.SkipWhileElements(numbers);

            // Assert
            Assert.Equal(expectedNumbers, actualNumbers);
        }
    }
}
