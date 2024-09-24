using BookManagementSystem.Data;
using BookManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BookManagementSystem.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
                
        }
        public DbSet<Book> Books { get; set; }  // DbSet for Book entity

        // Override OnModelCreating for additional configurations if needed
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // You can configure model properties here
            base.OnModelCreating(modelBuilder);
        }

    }
}
