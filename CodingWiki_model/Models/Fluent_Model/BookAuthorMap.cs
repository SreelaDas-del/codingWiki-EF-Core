using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_model.Models
{
    public class Fluent_BookAuthorMap
    {
        //[ForeignKey("books")]
        //[Key]
        //public int BookId { get; set; }
        //[ForeignKey("authors")]
        //[Key]
        //public int Author_id { get; set; }
        //public Book books { get; set; }
        //public Author authors { get; set; }

        public int BookId { get; set; }

        public int Author_id { get; set; }

        public Fluent_Author author { get; set; }
        public Fluent_Book book { get; set; }
    }
}
