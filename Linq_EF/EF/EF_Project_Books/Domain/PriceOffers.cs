using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public  class PriceOffers
    {
        public int PriceOffersId { get; set; }
        public double NewPrice { get; set; }

        public string PromotionalText { get; set; }

        // one to one with books
        
        public int BookId { get; set; }  //fk

        public Books Book;
    }
}
