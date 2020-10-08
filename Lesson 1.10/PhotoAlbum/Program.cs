using System;
using System.Linq;

namespace PhotoAlbum
{
    class Program
    {
        static void Main(string[] args)
        {
            var album = new Album();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Yo, Photo album");
                Console.WriteLine("Choose from these operations");
                Console.WriteLine("Add - for adding photo to you album");
                Console.WriteLine("Remove - for removing photo from your album");
                Console.WriteLine("List - for list of all photos in your album");
                Console.WriteLine("Show - for opening the photo");
                Console.ForegroundColor = ConsoleColor.Cyan;
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    continue;

                if (!Enum.TryParse(input.ToCamelCase(), out Choice choice))
                    continue;
                Console.ForegroundColor = ConsoleColor.Magenta;
                switch (choice)
                {
                    case Choice.Add:
                        Console.Write("Name: ", Console.ForegroundColor);
                        var name = Console.ReadLine();
                        Console.Write("Path: ");
                        var path = Console.ReadLine();
                        Console.WriteLine(album.Add(PhotoFactory.CreatePhoto(name, path)).Message);
                        break;
                    case Choice.Remove:
                        Console.Write("Id: ");
                        Console.WriteLine(int.TryParse(Console.ReadLine(), out int id)
                            ? album.Remove(id).Message
                            : "Invalid number");
                        break;
                    case Choice.List:
                        var all = album.GetAllPhotos();
                        all.ForEach(x => Console.WriteLine(x.ToString()));
                        break;
                    case Choice.Show:
                        Console.Write("Id: ");
                        Console.WriteLine(int.TryParse(Console.ReadLine(), out int idNum)
                            ? album.Show(idNum).Message
                            : "Invalid number");
                        break;
                }
            }
        }
    }
}
