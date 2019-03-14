using System;
using Microsoft.EntityFrameworkCore;

namespace BooksAndAuthors.Models
{
    public class Context : DbContext
    {
       public Context(DbContextOptions options) : base(options) {  }

       public DbSet<Author> Authors {get; set;}
    }
}