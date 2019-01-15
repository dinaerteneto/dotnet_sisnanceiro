using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using src.Models;

namespace src.Models
{
    public partial class MyContext : DbContext
    {

        public string connectionString = "Data Source=db.sqlite";

        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");
        }
    }
}
