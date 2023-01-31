using System.Collections.Immutable;
using bookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace bookstore.Context;

public class Data : DbContext
{
    public Data(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Book> Book { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .HasKey(b => b.Name);

        modelBuilder.Entity<Book>().HasData(
            new Book { Name = "Book 1", Author = "Author 1", Category = "Category 1", Capacity = 10, Price = 20 },
            new Book { Name = "Book 2", Author = "Author 2", Category = "Category 2", Capacity = 20, Price = 30 },
            new Book { Name = "Book 3", Author = "Author 3", Category = "Category 3", Capacity = 30, Price = 40 },
            new Book { Name = "Book 4", Author = "Author 4", Category = "Category 4", Capacity = 40, Price = 50 },
            new Book { Name = "Book 5", Author = "Author 5", Category = "Category 5", Capacity = 50, Price = 60 }
        );
    }
}