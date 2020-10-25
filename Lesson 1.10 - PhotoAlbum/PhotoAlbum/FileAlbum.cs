using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace PhotoAlbum
{
    public class FileAlbum : IAlbum
    {
        private string _directoryPath = "cesta";
        public FileAlbum()
        {
            Directory.CreateDirectory(_directoryPath);
        }
        public Result Add(Photo photo)
        {
            var finalPath = Path.Combine(_directoryPath, photo.Path);
            File.Create(finalPath);
            return new Result("test");
        }

        public List<Photo> GetAllPhotos()
        {
            throw new System.NotImplementedException();
        }

        public Result Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public Result Show(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}