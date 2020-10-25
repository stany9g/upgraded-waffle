using System.Security.Permissions;

namespace PhotoAlbum
{
    public class Result
    {
        public string Message { get; }

        public Result(string message)
        {
            Message = message;
        }
    }
}