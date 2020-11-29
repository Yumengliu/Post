using System;
using Microsoft.EntityFrameworkCore;
using Post.Models;

namespace Post.Repository
{
    public class PostRepository : DbContext
    {
        public DbSet<PostResult> Posts { get; set; }
        public PostRepository()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost,1433;database=postDb;user id=sa;password=YourStrong@Passw0rd");
        }
    }
}
