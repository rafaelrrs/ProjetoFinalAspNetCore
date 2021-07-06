using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App2.Models;
using Microsoft.EntityFrameworkCore;

namespace App2.Data
{
    public class BancoDeDados : DbContext
    {
        public BancoDeDados(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Amigo> Amigos {get; set;}
    }
}
