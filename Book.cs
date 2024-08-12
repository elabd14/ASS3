using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS3ADVANCED
{
    public class Book
    {
        public Book(string iSBN, string title, string[] authors, DateTime publicationDate, decimal price)
        {
            ISBN = iSBN;
  
            PublicationDate = publicationDate;
            Price = price;  
            Authors = authors;
        }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; } 
      
      

        public override string ToString() => ($" ISBN: {ISBN} ,Title {Title} , Author {Authors} , PublicationDate {PublicationDate} , Price {Price} ");
    }
}
