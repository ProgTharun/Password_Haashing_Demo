using Microsoft.EntityFrameworkCore;
using Password_Haashing_Demo.Model;

namespace Password_Haashing_Demo.Data
{
    public class Context:DbContext
    {
        public DbSet<User>Users { get; set; }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
    }
}
