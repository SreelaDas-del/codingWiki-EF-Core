using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_model.Models
{
    public class SubCategory
    {
        [Key]
        public int SubCategory_id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
