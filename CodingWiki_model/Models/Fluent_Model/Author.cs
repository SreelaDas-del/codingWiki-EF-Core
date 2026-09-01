using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_model.Models
{
    public class Fluent_Author
    {
        //[Key]
        public int Author_id { get; set; }
       // [Required]
       // [MaxLength(50)]
        public string FirstName { get; set; }
        //[Required]
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string Location { get; set; }
       // [NotMapped]
        public string FullName { get { 
                return $"{FirstName} {LastName}";
            } }

        //public List<Book> Books { get; set; }

     //   public List<Fluent_Book> Books { get; set; }

        public List<Fluent_BookAuthorMap> BookAuthorMap { get; set; }

        }

    }
