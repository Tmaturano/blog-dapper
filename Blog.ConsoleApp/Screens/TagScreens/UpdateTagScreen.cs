using Blog.ConsoleApp.Models;
using Blog.ConsoleApp.Repositories;
using System;

namespace Blog.ConsoleApp.Screens.TagScreens
{
    public static class UpdateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Updating a Tag");
            Console.WriteLine("---------------");
            
            Console.Write("Id: ");
            int.TryParse(Console.ReadLine(), out var id);

            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Update(id, name, slug);
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Update(int id, string name, string slug)
        {
            var tag = new Tag
            {
                Id = id,
                Name = name,
                Slug = slug
            };

            try
            {
                var repository = new TagRepository(Database.Connection);                                
                repository.Update(tag);
                Console.WriteLine("Tag updated successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error when updating a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
