namespace Domain
{
    public class Books
    {
        public int BooksId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishedOn { get; set; }

        public string Publisher { get; set; }

        public double Price { get; set; }

        public string ImageUrl { get; set; }


        // Many to Many with Authors
        public ICollection<BookAuthor> BookAuthors { get; set; }

        // Many to Many with tags 
        public  ICollection<BookTag> BookTags { get; set; }

        // One to One with PriceOffer
        public PriceOffers PriceOffer {  get; set; }

        // One to Many with Reviews
        public ICollection<Review> Reviews { get; set; }
          
    }
}
