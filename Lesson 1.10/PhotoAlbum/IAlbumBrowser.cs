namespace PhotoAlbum
{
    public interface IAlbumBrowser
    {
        /// <summary>
        /// Open specific photo by the id in the album
        /// </summary>
        /// <param name="id"></param>
        void Show(int id);
    }
}