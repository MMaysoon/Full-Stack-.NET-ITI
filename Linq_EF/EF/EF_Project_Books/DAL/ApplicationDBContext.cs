using Azure;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace DAL
{
    public class ApplicationDBContext:DbContext
    {
        //1.====Tables====
        public DbSet<Books> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<PriceOffers> PriceOffers { get; set; }

        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<BookTag> BookTags { get; set; }

        //=====2.Conncection String=====
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost\\sqlexpress;database=EF_Bookd; trusted_connection=true;TrustServerCertificate=True");
        }

      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          //====3.Fluent Api=====
            //1.Book:Author (Many To Many)
            modelBuilder.Entity<BookAuthor>()
               .HasKey(ba => new { ba.BookId, ba.AuthorId });

            modelBuilder.Entity<BookAuthor>()
                .HasOne(ba => ba.Book)
                .WithMany(b => b.BookAuthors)
                .HasForeignKey(ba=>ba.BookId);

            modelBuilder.Entity<BookAuthor>()
               .HasOne(ba => ba.Author)
               .WithMany(b => b.BookAuthor)
               .HasForeignKey(ba => ba.AuthorId);

            //2.Book:Tag (Many to Many)
            modelBuilder.Entity<BookTag>()
               .HasKey(bt => new { bt.BookId, bt.TagId });

            modelBuilder.Entity<BookTag>()
                .HasOne(bt => bt.Book)
                .WithMany(b => b.BookTags)
                .HasForeignKey(bt => bt.BookId);

            modelBuilder.Entity<BookTag>()
                .HasOne(bt => bt.Tag)
                .WithMany(t => t.BookTags)
                .HasForeignKey(bt => bt.TagId);


            //3.Book:PriceOffer (one to One)
            modelBuilder.Entity<Books>()
                .HasOne(b => b.PriceOffer)
                .WithOne(b => b.Book)
                .HasForeignKey<PriceOffers>(po => po.BookId);

            //4.Book:Review (One to Many)
            modelBuilder.Entity<Books>()
                .HasMany(b => b.Reviews)
                .WithOne(r => r.Book)
                .HasForeignKey(r => r.BookId);

            //====4.Data seeding=====
            modelBuilder.Entity<Author>().HasData(
               new Author { AuthorId = 1, Name = "Maysoon" },
               new Author { AuthorId = 2, Name = "Menah" }
           );

            modelBuilder.Entity<Books>().HasData(
                new Books
                {
                    BooksId = 1,
                    Title = "Clean Code",
                    Description = "Clean Code Clean Code Clean Code",
                    PublishedOn = new DateTime(2008, 8, 1),
                    Publisher = "Maysoon",
                    Price = 39.99,
                    ImageUrl = "cleancode.jpg"
                },
                new Books
                {
                    BooksId = 2,
                    Title = "Refactoring",
                    Description = "Improving the Design of Existing Code",
                    PublishedOn = new DateTime(2018, 11, 19),
                    Publisher = "Menah",
                    Price = 45.00,
                    ImageUrl = "refactoring.jpg"
                }
            );

            modelBuilder.Entity<BookAuthor>().HasData(
                new BookAuthor { BookId = 1, AuthorId = 1, Order = 1 },
                new BookAuthor { BookId = 2, AuthorId = 2, Order = 1 }
            );

            modelBuilder.Entity<Tags>().HasData(
                new Tags { TagsId = 1, Name = "C#" },
                new Tags { TagsId = 2, Name = "OOP" },
                new Tags { TagsId = 3, Name = "Refactoring" }
            );

        }
    }
}
