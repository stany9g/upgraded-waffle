using System.Collections.Generic;
using System.Data;

namespace PhotoAlbum
{
    public interface IAlbum
    {
        /// <summary>
        /// Add <param name="photo"/> into the album
        /// </summary>
        /// <param name="id">id of the photo in the album, must be unique</param>
        Result Add(int id, Photo photo);

        /// <summary>
        /// Remove photo from the album by ID
        /// </summary>
        /// <param name="id"></param>
        Result Remove(int id);

        /// <summary>
        /// List all the photos in the album with its properties
        /// </summary>
        List<Photo> GetAllPhotos();
    }
}