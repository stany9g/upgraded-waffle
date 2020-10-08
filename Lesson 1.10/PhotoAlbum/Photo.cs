namespace PhotoAlbum
{
    public class Photo
    {
        public int Id { get; }
        public string Name { get; }
        public string Path { get; }

        public Photo(int id, string name, string path)
        {
            Id = id;
            Name = name;
            Path = path;
        }

        public override string ToString()
        {
            return $"Id: {Id} Name: {Name} Path: {Path}";
        }
    }
}