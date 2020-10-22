namespace Market.Data.Access
{
    public interface IContext
    {
        /// <summary>
        /// Simulates connection to storage, i.e. sql connection string or path to data file (json/xml)
        /// </summary>
        /// <param name="connectionString"></param>
        void Connect(string connectionString);
    }
}