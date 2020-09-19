using Microsoft.EntityFrameworkCore;
using Primer_Registro.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Registro.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> Personas { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data\Personas.db");
        }
    }

}
