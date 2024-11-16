using Microsoft.EntityFrameworkCore;
using WebAssignment_Quiz_.Data.Model;

namespace WebAssignment_Quiz_.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>().HasKey(x => new { x.AuthorsId, x.BookId });
            modelBuilder.Entity<BookAuthor>().HasOne(x=> x.books).WithMany(x=> x.BooksAuthors).HasForeignKey(x=>x.BookId);
            modelBuilder.Entity<BookAuthor>().HasOne(x => x.authors).WithMany(x => x.BooksAuthors).HasForeignKey(x => x.AuthorsId);

            modelBuilder.Entity<BookGenre>().HasKey(x => new { x.GenreId, x.BookId });
            modelBuilder.Entity<BookGenre>().HasOne(x => x.books).WithMany(x => x.BooksGenre).HasForeignKey(x => x.BookId);
            modelBuilder.Entity<BookGenre>().HasOne(x => x.genre).WithMany(x => x.bookGenres).HasForeignKey(x => x.GenreId);
        }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books {  get; set; }
        public DbSet<Genre> Genres { get; set;}
        public DbSet<BookGenre> BookGenres { get; set; }
    }
}
