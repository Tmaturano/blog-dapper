using Blog.ConsoleApp.Models;
using Microsoft.Data.SqlClient;

namespace Blog.ConsoleApp.Repositories
{
    public class RoleRepository : Repository<Role>
    {
        public RoleRepository(SqlConnection connection) : base(connection) { }      
    }
}
