using System;
using Xunit;

namespace ReverseEverything
{
    public class ReverseTest
    {
        [Fact]
        public void EmptyStringTest()
        {
            var expected = "".ToCharArray();
            var actual = "".ToCharArray();
            Reverse.ReverseChars(actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SingleCharacterStringTest()
        {
            var expected = "A".ToCharArray();
            var actual = "A".ToCharArray();
            Reverse.ReverseChars(actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LongerStringTest()
        {
            var expected = "EDCBA".ToCharArray();
            var actual = "ABCDE".ToCharArray();
            Reverse.ReverseChars(actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void OneWordTest()
        {
            var expected = "vault".ToCharArray();
            var actual = "vault".ToCharArray();
            Reverse.ReverseWords(actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TwoWordsTest()
        {
            var expected = "cake thief".ToCharArray();
            var actual = "thief cake".ToCharArray();
            Reverse.ReverseWords(actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ThreeWordsTest()
        {
            var expected = "get another one".ToCharArray();
            var actual = "one another get".ToCharArray();
            Reverse.ReverseWords(actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MultipleWordsSameLengthTest()
        {
            var expected = "the cat ate the rat".ToCharArray();
            var actual = "rat the ate cat the".ToCharArray();
            Reverse.ReverseWords(actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MultipleWordsDifferentLengthsTest()
        {
            var expected = "chocolate bundt cake is yummy".ToCharArray();
            var actual = "yummy is cake bundt chocolate".ToCharArray();
            Reverse.ReverseWords(actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EmptyStringWordTest()
        {
            var expected = "".ToCharArray();
            var actual = "".ToCharArray();
            Reverse.ReverseWords(actual);
            Assert.Equal(expected, actual);
        }
    }
}
