using BikeStoreWeb.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace BikeStoreWeb.Api.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> dbContext):base(dbContext)
        {

        }

        public DbSet<Command> Commands { get; set; }

    }
}
