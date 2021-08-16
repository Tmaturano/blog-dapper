using Blog.ConsoleApp.Repositories;
using System;

namespace Blog.ConsoleApp.Screens.TagScreens
{
    public static class DeleteTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Delete a Tag");
            Console.WriteLine("---------------");

            Console.Write("Id: ");
            int.TryParse(Console.ReadLine(), out var id); 

            Delete(id);
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new TagRepository(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Tag deleted successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error when deleting a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
