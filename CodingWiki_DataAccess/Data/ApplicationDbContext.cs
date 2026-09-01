using CodingWiki_model;
using CodingWiki_model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Console
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CodingWiki_model.Book> Books { get; set; }
        public DbSet<CodingWiki_model.Genre> Genres { get; set; }

        public DbSet<CodingWiki_model.Models.Publisher> Publishers { get; set; }
        public DbSet<CodingWiki_model.Models.SubCategory> SubCategories { get; set; }   
        public DbSet<CodingWiki_model.Models.Author> Authors { get; set; }

        public DbSet<CodingWiki_model.Models.BookDetails> BookDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-DI45IJF\\SQLEXPRESS;Database=CodingWikiDB;TrustServerCertificate=True;Trusted_Connection=True;");
            options.UseSqlServer("Server=DESKTOP-DI45IJF\\SQLEXPRESS;Database=CodingWikiDB;TrustServerCertificate=True;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { 
            modelBuilder.Entity<CodingWiki_model.Book>().Property(b => b.Price).HasPrecision(10, 5);
            modelBuilder.Entity<BookAuthorMap>().HasKey(u => new { u.BookId, u.Author_id });
            modelBuilder.Entity<CodingWiki_model.Book>().HasData(
                new CodingWiki_model.Book { BookId = 1, Title = "Book 1", ISBN = "1234567890", Price = 19.99m , Publisher_Id =1},
                new CodingWiki_model.Book { BookId = 2, Title = "Book 2", ISBN = "0987654321", Price = 29.99m , Publisher_Id =2},
                new CodingWiki_model.Book { BookId = 3, Title = "Book 3", ISBN = "1111111111", Price = 39.99m , Publisher_Id =3 }
                );

            var booklist = new Book[]
                {
                    new Book { BookId = 4, Title = "Book 4", ISBN = "1234567893", Price = 16.99m,Publisher_Id=1 },
                    new Book { BookId = 5, Title = "Book 5", ISBN = "0987654322", Price = 25.99m,Publisher_Id=2 }

                };
            modelBuilder.Entity<CodingWiki_model.Book>().HasData(booklist);

            var publisherlist = new CodingWiki_model.Models.Publisher[]
                {
                    new CodingWiki_model.Models.Publisher { Publisher_Id = 1, Name = "Publisher 1",Location="Chicago"},
                    new CodingWiki_model.Models.Publisher { Publisher_Id = 2, Name = "Publisher 2",Location="NewYork" },
                     new CodingWiki_model.Models.Publisher { Publisher_Id = 3, Name = "Publisher 3",Location="Hawaii" },
                };
            modelBuilder.Entity<CodingWiki_model.Models.Publisher>().HasData(publisherlist);
        }
    }
}
