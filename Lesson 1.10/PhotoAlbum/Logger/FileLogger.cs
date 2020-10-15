using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PhotoAlbum.Logger
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            var path = "path";
            File.Create(path);
            File.WriteAllText(path, message);
        }
    }
}
