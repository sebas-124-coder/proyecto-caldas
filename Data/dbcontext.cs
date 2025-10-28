using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proyecto_caldas.Models;

namespace proyecto_caldas.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }   
        public DbSet<usuariomodel> usuarios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<usuariomodel>().HasKey(u => u.Userid);
            modelBuilder.Entity<usuariomodel>().Property(u =>u.Userid).ValueGeneratedOnAdd();
        }
    }
}