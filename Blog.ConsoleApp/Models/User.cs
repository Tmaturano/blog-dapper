using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace Blog.ConsoleApp.Models
{
    [Table("[User]")]
    public class User
    {
        public User()
        {
            Roles = new List<Role>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }

        [Write(false)] //to not write when inserting a new using with the Insert method
        public List<Role> Roles { get; set; }
    }
}
