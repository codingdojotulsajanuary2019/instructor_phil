using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BooksAndAuthors.Models
{
    public class Publisher
    {
        [Key]
        public int PublisherId {get; set;}

        [Required(ErrorMessage = "Publisher must have a name")]
        [Display(Name="Name:")]
        public string Name {get; set;}

        public List<Publication> Publications {get; set;}

        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
    }
}