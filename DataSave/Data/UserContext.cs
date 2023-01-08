using DataSave.Models;
using Microsoft.EntityFrameworkCore;

namespace DataSave.Data
{
    public class UserContext:DbContext
    { 
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
