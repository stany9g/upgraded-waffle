using PhotoAlbum.Logger;

namespace PhotoAlbum.Abstract
{
    public class Person : BaseModel
    {
        public string Name { get; set; }

        public override void Do()
        {
            //Kill
        }

        protected override void SetUp(int id)
        {
            // something more
        }
    }
}