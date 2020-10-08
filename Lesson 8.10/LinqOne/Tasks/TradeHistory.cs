using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractise
{
    public class TradeHistory
    {
        private readonly List<Transaction> _transactions;

        public TradeHistory(List<Transaction> transactions)
        {
            _transactions = transactions;
        }

        /// <summary>
        /// Find all transactions in 2011 and order it by value
        /// </summary>
        /// <returns></returns>
        public List<Transaction> FindAllTransactionsIn2011AndSortByValueAsc()
        {
            return new List<Transaction>();
        }

        /// <summary>
        /// List unique cities
        /// </summary>
        /// <returns></returns>
        public List<string> GetUniqueCitiesSortedAsc()
        {
            return new List<string>();
        }

        /// <summary>
        /// Get single string of traders in format “Traders: name1 name2 … ”
        /// String shall start with "Traders:" and use space as separator. E.g.: "Traders: Bob George"
        /// </summary>
        /// <returns></returns>
        public string GetSingleStringFromUniqueTradersNamesSortByNameAsc()
        {
            return string.Empty;
        }

        /// <summary>
        /// Does trader exists for specified <see cref="cityName"/>
        /// </summary>
        /// <param name="cityName"></param>
        /// <returns></returns>
        public bool IsSomeTraderFromCity(string cityName)
        {
            return false;
        }

        /// <summary>
        /// Get traders grouped by city
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, List<Trader>> GetTradersByTown()
        {
           return new Dictionary<string, List<Trader>>();
        }

        /// <summary>
        /// Get number of traders grouped by city
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, long> GetTradersCountsByTown()
        {
            return new Dictionary<string, long>();
        }

    }
}
