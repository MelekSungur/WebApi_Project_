

using Microsoft.EntityFrameworkCore;
using WebApi_Project_.DAL.Entities;

namespace WebApi_Project_.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MELEK;initial catalog=WebApiConsume;integrated security=True");
        }
        public DbSet <Category> Categories { get; set; }
    }
}
