using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BooksAndAuthors.Models
{
    public class Publication
    {
        [Key]
        public int PublicationId {get; set;}

        [Display(Name="Book:")]
        public int BookId {get; set;}
        public Book Book {get; set;}

        [Display(Name="Publisher:")]
        public int PublisherId {get; set;}
        public Publisher Publisher {get; set;}

        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
    }
}