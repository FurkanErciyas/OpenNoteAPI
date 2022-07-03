using Microsoft.EntityFrameworkCore;

namespace OpenNoteAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>().HasData(
                new Note() { Id = 1, Title = "Sample Note 1", Content = "Lorem ipsum dolor sit amet" },
                new Note() { Id = 2, Title = "Sample Note 2", Content = "Amet lorem ipsum dolor sit" },
                new Note() { Id = 3, Title = "Sample Note 3", Content = "Sit amet lorem ipsum dolor" },
                new Note() { Id = 4, Title = "Sample Note 4", Content = "dolor sit amet lorem ipsum" }
                );
        }
    }
}
