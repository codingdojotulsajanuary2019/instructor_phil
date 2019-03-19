using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BooksAndAuthors.Models
{
    public class Book
    {
        [Key]
        public int BookId {get; set;}

        [Required(ErrorMessage = "Book Title is required!")]
        [Display(Name="Title:")]
        public string Title {get; set;}

        [Required(ErrorMessage = "Book must have an Author!")]
        [Display(Name="Author:")]
        public int? AuthorId {get; set;}
        public Author Author {get; set;}

        public List<Publication> Publications {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
    }
}