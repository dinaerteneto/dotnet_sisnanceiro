using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using src.Models;

namespace src.Context
{
    public partial class PessoaContext : DbContext
    {

        public DbSet <Pessoa> Pessoa {get; set;}
        public DbSet <Endereco> Endereco { get; set; }
        public DbSet <Contato> Contato { get; set; }
        public DbSet <ContatoTipo> ContatoTipo { get; set; }

        public PessoaContext()
        {
        }

        public PessoaContext(DbContextOptions<PessoaContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=db.sqlite");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<ContatoTipo>().HasData(
                new {Id = 1, Nome = "E-Mail"},
                new {Id = 2, Nome = "Telefone Residencial"},
                new {Id = 3, Nome = "Telefone Celular"},
                new {Id = 4, Nome = "Telefone Comercial"},
                new {Id = 5, Nome = "WhatsApp"},
                new {Id = 6, Nome = "Skype"}
            );

            modelBuilder.Entity<Pessoa>().HasData(
                new { Id = 1, CpfCnpj = "34713094000168", isTenant = true, Nome = "Márcio", Sobrenome = "Paro", DataNascimento = "2019-01-21"},
                new { Id = 2, CpfCnpj = "78832039000162", isTenant = true, Nome = "Márcio", Sobrenome = "Paro", DataNascimento = "2019-01-21"},
                new { Id = 3, CpfCnpj = "87169379023", isTenant = false, Nome = "Dinaerte", Sobrenome = "Neto", DataNascimento = "1985-07-15", PessoaId = 2}
            );

            modelBuilder.Entity<Contato>().HasData(
                new { Id = 1, Descricao = "11993762930", ContatoTipoId = 3, PessoaId = 2},
                new { Id = 2, Descricao = "1135141684", ContatoTipoId = 2, PessoaId = 2},
                new { Id = 3, Descricao = "dinaerteneto@gmail.com", ContatoTipoId = 1, PessoaId = 2}
            );

            modelBuilder.Entity<Endereco>().HasData(
                new { Id = 1, Nome = "Casa", Cep = "06366900", Numero = "773", Complemento = "Ap 02", Logradouro = "Avenida Inocêncio Seráfico 6300", Bairro = "Vila Dirce", Cidade = "Carapicuíba", Uf = "SP", PessoaId = 3 }
            );
        
           
        }
    }
}
