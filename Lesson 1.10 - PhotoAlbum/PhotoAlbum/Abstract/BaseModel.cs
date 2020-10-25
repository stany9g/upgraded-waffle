namespace PhotoAlbum.Abstract
{
    public abstract class BaseModel
    {
        public int Id { get; set; }

        public abstract void Do();

        protected virtual void SetUp(int id)
        {
            Id = id;
        }
    }
}