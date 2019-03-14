using System.Collections.Generic;

namespace BooksAndAuthors.Models
{
    public class IndexView
    {
        public Author Author {get; set;}
        public List<Author> Authors {get; set;}
    }
}