namespace PhotoAlbum.Logger
{
    public interface ILogger
    {
        /// <summary>
        /// Logs the message
        /// </summary>
        /// <param name="message"></param>
        void Log(string message);
    }
}