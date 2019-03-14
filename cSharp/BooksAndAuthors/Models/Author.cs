using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BooksAndAuthors.Models
{
    public class Author
    {
        [Key]
        public long AuthorId {get; set;}

        [Required(ErrorMessage = "Name is required")]
        [Display(Name="Name:")]
        public string Name {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
    }
}