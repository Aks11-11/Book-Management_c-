using Microsoft.EntityFrameworkCore;
using BookManagementSystem.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace BookManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
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
