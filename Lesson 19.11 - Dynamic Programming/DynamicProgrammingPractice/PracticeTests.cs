using System;
using System.Collections.Generic;
using Xunit;
using static DynamicProgrammingPractice.Practice;

namespace DynamicProgrammingPractice
{
    public class PracticeTests
    {
        [Fact]
        public void EmptyStringTest()
        {
            var expected = new HashSet<string>() { "" };
            var actual = GetPermutations("");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void OneCharacterStringTest()
        {
            var expected = new HashSet<string>() { "a" };
            var actual = GetPermutations("a");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TwoCharacterStringTest()
        {
            var expected = new HashSet<string>() { "ab", "ba" };
            var actual = GetPermutations("ab");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ThreeCharacterStringTest()
        {
            var expected = new HashSet<string>() { "abc", "acb", "bac", "bca", "cab", "cba" };
            var actual = GetPermutations("abc");
            Assert.Equal(expected, actual);
        }
    }
}
