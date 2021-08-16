using Blog.ConsoleApp.Repositories;
using System;

namespace Blog.ConsoleApp.Screens.TagScreens
{
    public static class ListTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Tags:");
            Console.WriteLine("---------------");
            List();
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        private static void List()
        {
            var repository = new TagRepository(Database.Connection);
            var tags = repository.Get();
            foreach (var item in tags)            
                Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");            
        }
    }
}
