using Blog.ConsoleApp.Models;
using Blog.ConsoleApp.Repositories;
using System;

namespace Blog.ConsoleApp.Screens.TagScreens
{
    public static class CreateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("New Tag");
            Console.WriteLine("---------------");
            Console.Write("Name: ");
            var name = Console.ReadLine();
            
            Console.Write("Slug: ");
            var slug = Console.ReadLine();
            
            Create(name, slug);
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        private static void Create(string name, string slug)
        {
            var tag = new Tag
            {
                Name = name,
                Slug = slug
            };

            try
            {
                var repository = new TagRepository(Database.Connection);
                repository.Create(tag);
                Console.WriteLine("Tag created successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error when creating a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
