using Blog.ConsoleApp.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace Blog.ConsoleApp.Repositories
{
    public class UserRepository : Repository<User>
    {
        private readonly SqlConnection _connection;

        public UserRepository(SqlConnection connection) : base(connection) => _connection = connection;

        public List<User> GetWithRoles()
        {
            var query = @"SELECT [User].*,
                               [Role].*
                        FROM [User]       
                        LEFT JOIN [UserRole] ON [UserRole].[UserId] = [User].[Id]
                        LEFT JOIN [Role] ON [UserRole].[RoleId] = [Role].[Id]";

            var users = new List<User>();

            var items = _connection.Query<User, Role, User>(
                query,
                (user, role) =>
                {
                    var usr = users.FirstOrDefault(x => x.Id == user.Id);
                    if (usr is null)
                    {
                        usr = user;
                        
                        if (role is not null)
                            usr.Roles.Add(role);

                        users.Add(usr);
                    }
                    else
                    {
                        usr.Roles.Add(role);
                    }

                    return usr;
                }, splitOn: "Id"); // split is used to identify in the query, what is an user and what is a role in every row.
            
            
            return users;
        }
    }
}
