using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaTec.EntidadesDeNegocio;
using Microsoft.EntityFrameworkCore;

namespace PruebaTec.AccesoADatos
{
    public class BDContexto : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=MONICA;Initial Catalog=Prueba1;Integrated Security=True");
            
        }
    }
}
