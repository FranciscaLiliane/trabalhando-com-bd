using Microsoft.EntityFrameworkCore;
using ArticleApp.API.Models;

namespace ArticleApp.API.Date
{
    public class DateContext : DbContext 
    {
      public DateContext (DbContextOptions<DateContext> options) : base (options)
      {}
      public DbSet<Article> Articles { get; set; } 

    }

}