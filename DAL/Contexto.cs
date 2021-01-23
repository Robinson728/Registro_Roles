using Microsoft.EntityFrameworkCore;
using Registro_Roles.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Registro_Roles.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Roles> Roles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = GestionRoles.Db");
        }
    }
}
