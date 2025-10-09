using DAL;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace EF_Books
{
    internal class Program
    {
        static  async Task Main(string[] args)
        {
            using var context = new ApplicationDBContext();

            // create
            await AddBookAsync(context);

            // read
            await GetAllBooksAsync(context);

            // update
            await UpdateBookAsync(context, 1, "Updated Title");

            // delete
            await DeleteBookAsync(context, 1);
        }

        private static async Task DeleteBookAsync(ApplicationDBContext context, int id)
        {
           var book=await context.Books.FindAsync(id);
            if (book == null)
            {
                Console.WriteLine(" Book not found!");
                return;
            }
            context.Books.Remove(book);
            await context.SaveChangesAsync();
            Console.WriteLine("Book Deleted Successfully!");
        }

        private static async Task UpdateBookAsync(ApplicationDBContext context, int Id, string newTitle)
        {
            var book = await context.Books.FindAsync(Id);
            if (book == null)
            {
                Console.WriteLine(" Book not found!");
                return;
            }

            book.Title = newTitle;
            await context.SaveChangesAsync();
            Console.WriteLine("Book Updated Successfully!");
        }

        private static async Task GetAllBooksAsync(ApplicationDBContext context)
        {
            var books = await context.Books.ToListAsync();

            Console.WriteLine("\nAll Books:");
            foreach (var b in books)
            {
                Console.WriteLine($"{b.BooksId}: {b.Title} - {b.Publisher}");
            }
        }

        private static async Task AddBookAsync(ApplicationDBContext context)
        {
            var book = new Books
            {
                Title = "Entity FramWork",
                Description = "EF EF EF ",
                PublishedOn = DateTime.Now,
                Publisher = "Maysoon",
                Price = 250.0,
                ImageUrl = "https://example.com/cleancode.jpg"
            };

            await context.Books.AddAsync(book);
            await context.SaveChangesAsync();
            Console.WriteLine("Book Added Successfully!"); ;
        }
    }
}
