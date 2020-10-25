namespace PhotoAlbum
{
    public static class PhotoFactory
    {
        private static int _id = 0;
        public static Photo CreatePhoto(string name, string path)
        {
            return new Photo(++_id, name, path);
        }
    }
}