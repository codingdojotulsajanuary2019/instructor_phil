using System;
using System.ComponentModel.DataAnnotations;

namespace IntroToDotnetCore.Models
{
    public class Author
    {
        [Required(ErrorMessage = "Name is required!")]
        [MinLength(2, ErrorMessage ="Name must be at least 2 characters long!")]
        public string Name {get; set;}

        public Author() {}
        public Author(string name)
        {
            Name = name;
        }
    }
}