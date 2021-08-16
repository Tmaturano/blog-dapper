using Blog.ConsoleApp.Models;
using Microsoft.Data.SqlClient;

namespace Blog.ConsoleApp.Repositories
{
    public class TagRepository : Repository<Tag>
    {
        public TagRepository(SqlConnection connection) : base(connection)
        {
        }
    }
}
