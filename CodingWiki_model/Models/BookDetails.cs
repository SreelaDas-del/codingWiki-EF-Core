using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_model.Models
{
    public class BookDetails
    {
        [Key]
        public int BookDetail_Id { get; set; }
        [Required]
        public int NumberOfChapters { get; set; }
        public int NumberofPages { get; set; }
        public string Weight { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Book1")]
        public int BookId { get; set; }

        public Book Book1 { get; set; }
    }
}
