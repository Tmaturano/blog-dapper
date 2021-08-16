using Blog.ConsoleApp.Screens.TagScreens;
using Microsoft.Data.SqlClient;
using System;

namespace Blog.ConsoleApp
{
    class Program
    {
        private const string CONNECTION_STRING = "Server=localhost,1433;Database=Blog;User ID=sa;Password=Abcd1234!";
        static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();

            Load();

            Console.ReadKey();
            Database.Connection.Close();
        }

        private static void Load()
        {
            Console.Clear();
            Console.WriteLine("My Blog");
            Console.WriteLine("-------------------");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine();
            Console.WriteLine("1 - User Management");
            Console.WriteLine("2 - Profile Management");
            Console.WriteLine("3 - Category Management");
            Console.WriteLine("4 - Tag Management");
            Console.WriteLine("5 - Link Profile/User");
            Console.WriteLine("6 - Link Post/Tag");
            Console.WriteLine("7 - Reports");
            Console.WriteLine();
            Console.WriteLine();

            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    //TODO
                    break;
                case 2:
                    //TODO
                    break;
                case 3:
                    //TODO
                    break;
                case 4:
                    MenuTagScreen.Load();
                    break;
                case 5:
                    //TODO
                    break;
                case 6:
                    //TODO
                    break;
                case 7:
                    //TODO
                    break;
                default:
                    Load();
                    break;
            }
        }

        //    public static void ReadUsersWithRoles(SqlConnection connection)
        //    {
        //        var repository = new UserRepository(connection);
        //        var users = repository.GetWithRoles();

        //        foreach (var user in users)
        //        {
        //            Console.WriteLine(user.Name);

        //            foreach (var role in user.Roles)
        //            {
        //                Console.WriteLine($" - {role.Name}");
        //            }
        //        }

        //    }

        //    public static void ReadUser(SqlConnection connection)
        //    {
        //        var repository = new UserRepository(connection);
        //        var user = repository.Get(1);

        //        Console.WriteLine(user.Name);
        //    }

        //    public static void CreateUser(SqlConnection connection)
        //    {
        //        var user = new User()
        //        {
        //            Bio = "Team 1",
        //            Email = "Test@test.com",
        //            Image = "https://",
        //            Name = "Team Thiago",
        //            PasswordHash = "Hash",
        //            Slug = "team-thiago"
        //        };

        //        var userRepository = new UserRepository(connection);
        //        userRepository.Create(user);
        //    }

        //    public static void UpdateUser()
        //    {
        //        var user = new User()
        //        {
        //            Id = 2,
        //            Bio = "Team 1 updated",
        //            Email = "Test@test.com",
        //            Image = "https://",
        //            Name = "Team Thiago",
        //            PasswordHash = "Hash",
        //            Slug = "team-thiago"
        //        };

        //        using (var connection = new SqlConnection(CONNECTION_STRING))
        //        {
        //            var updated = connection.Update(user);
        //            Console.WriteLine($"Updated: {updated}");
        //        }
        //    }

        //    public static void DeleteUser()
        //    {
        //        using (var connection = new SqlConnection(CONNECTION_STRING))
        //        {
        //            var user = connection.Get<User>(2);
        //            var deleted = connection.Delete(user);
        //            Console.WriteLine($"Deleted: {deleted}");
        //        }
        //    }

        //    public static void ReadRoles(SqlConnection connection)
        //    {
        //        var repository = new RoleRepository(connection);
        //        var roles = repository.Get();

        //        foreach (var role in roles)
        //            Console.WriteLine(role.Name);
        //    }

        //    public static void ReadTags(SqlConnection connection)
        //    {
        //        var repository = new TagRepository(connection);
        //        var tags = repository.Get();

        //        foreach (var tag in tags)
        //            Console.WriteLine(tag.Name);
        //    }
        //}
    }
}
