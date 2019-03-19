using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BooksAndAuthors.Models
{
    public class Author
    {
        [Key]
        public int AuthorId {get; set;}

        [Required(ErrorMessage = "Name is required")]
        [Display(Name="Name:")]
        public string Name {get; set;}

        public List<Book> Wrote {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;


        // public override string ToString()
        // {
        //     Console.WriteLine("------------------------------------------------------------------------------");
        //     return $"Author: \n\tName: {Name}\n\tHas written {Wrote.Count} books";
        // }
    }
}