using CodingWiki_model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_model
{
    public class Fluent_Book
    {
      //  [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        //[MaxLength(20)]
        //[Required]
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        //[NotMapped]
        public string PriceRange { get; set; }

        public Fluent_BookDetails BookDetail { get; set; }

        public int Publisher_Id { get; set; }

        public Fluent_Publisher fluentpublisher { get; set; }

      //  public List<Fluent_Author> Fluent_Authors { get; set; }

        public List<Fluent_BookAuthorMap> BookAuthorMap { get; set; }

        //[ForeignKey("BookDetailsTable")]
        //public int BoookDetails_id { get; set; }

        //public BookDetails BookDetailsTable { get; set; }
        //[ForeignKey("Publisher")]
        //public int Publisher_Id { get; set; }


        //public Publisher Publisher { get; set; }
        //public List<BookAuthorMap> BookAuthorMap { get; set; }
    }
}
