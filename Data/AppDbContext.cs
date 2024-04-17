using LTW_Buoi1.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace LTW_Buoi1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book_Author>()
              .HasKey(bc => new { bc.BooksID, bc.AuthorsID });
            modelBuilder.Entity<Book_Author>()
                .HasOne(bc => bc.Books)
                .WithMany(b => b.book_Author)
                .HasForeignKey(bc => bc.BooksID);
            modelBuilder.Entity<Book_Author>()
                .HasOne(bc => bc.Authors)
                .WithMany(a => a.Book_Authors)
                .HasForeignKey(bc => bc.AuthorsID);
        }
        public DbSet<Publishers> publishers { get; set; }
        public DbSet<Books> books { get; set; }
        public DbSet<Authors> authors { get; set; }
        public DbSet<Book_Author> book_Authors { get; set; }
    }

}
