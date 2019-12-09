using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeGuide.EF.DomainModels
{
    public class BlogContext : DbContext
    {
        public BlogContext()
        {

        }

        public BlogContext(DbContextOptions<BlogContext> options)
            : base(options)
        {
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-I5O0JTM\\SQLEXPRESS;Database=TecBlogDB;Trusted_Connection=True;");
        }

        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Category> GetCategories { get; set; }
    }
}
