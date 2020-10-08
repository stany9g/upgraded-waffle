using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace PhotoAlbum
{
    public class Album : IAlbum
    {
        private readonly List<Photo> _storage = new List<Photo>();

        public Result Add(Photo photo)
        {
            if(photo == null)
                return new Result("You can't add empty photo");
            _storage.Add(photo);
            return new Result("Added successfully");
        }

        public Result Remove(int id)
        {
            try
            {
                var photo = _storage.FirstOrDefault(x => x.Id == id);
                if(_storage.Remove(photo))
                    return new Result("Removed successfully");
                return new Result("Remove failed");
            }
            catch (ArgumentOutOfRangeException e)
            {
                return new Result(e.Message);
            }
        }

        public List<Photo> GetAllPhotos()
        {
            return _storage;
        }

        public Result Show(int id)
        {
            var photo = _storage.FirstOrDefault(x => x.Id == id);
            if (photo != null)
            {
                try
                {
                    if (Path.IsPathFullyQualified(photo.Path) && File.Exists(photo.Path))
                    {
                        var p = new Process
                        {
                            StartInfo = new ProcessStartInfo(photo.Path)
                            {
                                UseShellExecute = true
                            }
                        };
                        p.Start();
                    }

                }
                catch (Exception e)
                {
                    return new Result(e.Message);
                }
            }
            return new Result($"Photo with this Id: {id}, does not exists");
        }
    }
}
