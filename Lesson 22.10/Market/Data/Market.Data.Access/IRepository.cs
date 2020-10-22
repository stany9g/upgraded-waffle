namespace Market.Data.Access
{
    public interface IRepository<TModel> where TModel : class
    {
        /// <summary>
        /// Insert model into storage
        /// </summary>
        /// <param name="model"></param>
        void Create(TModel[] model);

        /// <summary>
        /// Load model from storage
        /// </summary>
        /// <returns></returns>
        TModel Read();

        /// <summary>
        /// Update model in storage
        /// </summary>
        /// <param name="model"></param>
        void Update(TModel model);

        /// <summary>
        /// Delete model from storage
        /// </summary>
        /// <param name="model"></param>
        void Delete(TModel model);
    }
}