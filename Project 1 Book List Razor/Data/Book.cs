using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_1_Book_List_Razor.Data
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Book Name")]
        public string Name { get; set; }

        public string ISBN { get; set; }

        public string Author { get; set; }

        public DateTime PublishingDate { get; set; }
    }
}
