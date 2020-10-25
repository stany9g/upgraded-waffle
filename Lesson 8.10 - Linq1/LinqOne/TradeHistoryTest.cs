using System;
using System.Collections.Generic;
using System.Linq;
using LinqPractise;
using Xunit;

namespace LinqOne
{
    public class TradeHistoryTest
    {
        private TradeHistory _tradeHistory;

        public TradeHistoryTest()
        {
            var raoul = new Trader("Raoul", "Cambridge", false);
            var mario = new Trader("Mario", "Milano", true);
            var alan = new Trader("Alan", "Cambridge", false);
            var brian = new Trader("Brian", "Cambridge", false);
            var bohous = new Trader("Bohous", "Kladno", false);
            var jarous = new Trader("Jarous", "Kladno", true);

            var transactions = new List<Transaction>
            {
                new Transaction(brian, 2011, 300),
                new Transaction(raoul, 2012, 1000),
                new Transaction(raoul, 2011, 400),
                new Transaction(mario, 2012, 20),
                new Transaction(mario, 2012, 10),
                new Transaction(alan, 2012, 950),
                new Transaction(bohous, 2012, 1000),
                new Transaction(bohous, 2011, 1100),
                new Transaction(bohous, 2012, 800),
                new Transaction(jarous, 2011, 10),
                new Transaction(jarous, 2011, 30)
            };

            _tradeHistory = new TradeHistory(transactions);
        }

        [Theory]
        [InlineData(0,10)]
        [InlineData(1,30)]
        [InlineData(2,300)]
        [InlineData(3,400)]
        public void FindAllTransactionsIn2011AndSortByValueAscTest(int index, int expectedValue)
        {
            // Act
            var actual = _tradeHistory.FindAllTransactionsIn2011AndSortByValueAsc();

            // Assert
            Assert.Equal(actual[index].Value, expectedValue);
        }

        [Fact]
        public void GetUniqueCitiesSortedAscTest()
        {
            //Arrange
            var expected = new[] {"Cambridge", "Kladno", "Milano"};

            //Act
            var actual = _tradeHistory.GetUniqueCitiesSortedAsc();

            //Assert
            Assert.Equal(expected, actual.ToArray());
        }

        [Fact]
        public void GetSinglestringFromUniqueTradersNamesSortByNameAscTest()
        {
            //Arrange
            var expected = "Traders: Alan Bohous Brian Jarous Mario Raoul";

            //Act
            var actual = _tradeHistory.GetSingleStringFromUniqueTradersNamesSortByNameAsc();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsSomeTraderFromCityTest()
        {
            //Arrange
            var test1 = "Kladno";
            var test2 = "Brno";

            //act & assert
            Assert.True(_tradeHistory.IsSomeTraderFromCity(test1));
            Assert.False(_tradeHistory.IsSomeTraderFromCity(test2));
        }

        [Fact]
        public void GetTraderNamesByTownTest()
        {
            //arrange
            var kladnoTradersLabel = new[] {"Bohous", "Jarous"};
            var cambridgeTradersLabel = new[] {"Alan", "Brian", "Raoul"};
            var milanoTradersLabel = new[] {"Mario"};

            //act
            var traders = _tradeHistory.GetTradersByTown();


            var kladnoTradersTest = traders["Kladno"].Select(x => x.Name).OrderBy(x => x).ToList();
            var cambridgeTradersTest = traders["Cambridge"].Select(x => x.Name).OrderBy(x => x).ToList();
            var milanoTradersTest = traders["Milano"].Select(x => x.Name).OrderBy(x => x).ToList();

            //assert
            Assert.Equal(kladnoTradersLabel, kladnoTradersTest.ToArray());
            Assert.Equal(cambridgeTradersLabel, cambridgeTradersTest.ToArray());
            Assert.Equal(milanoTradersLabel, milanoTradersTest.ToArray());
        }

        [Fact]
        public void GetTradersCountsByTownTest()
        {
            //act
            var traders = _tradeHistory.GetTradersCountsByTown();

            //assert
            Assert.Equal(2, traders["Kladno"]);
            Assert.Equal(3, traders["Cambridge"]);
            Assert.Equal(1, traders["Milano"]);
        }

    }
}
