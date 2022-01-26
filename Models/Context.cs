using Microsoft.EntityFrameworkCore;

namespace crud_filmes_api_aspnetcore.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
    }
}