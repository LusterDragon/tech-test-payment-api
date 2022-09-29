using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentAPI.Repository.Mapping;
using PaymentAPI.Models.Entity; 

namespace PaymentAPI.Repository
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> context) : base(context)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VendaMapping());
            modelBuilder.ApplyConfiguration(new ProdutoMapping());
            base.OnModelCreating(modelBuilder);
        }
        DbSet<Venda> Vendas { get; set; }
        DbSet<Produto> Produtos { get; set; }
        DbSet<Vendedor> Vendedores { get; set; }
    }
}
