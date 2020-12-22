using CrudEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEntityFramework.Data
{
    public class AplicationDbContext : DbContext
    // la parte : DbContext hace la herencia, tambien se instaló un paquete "MicrosoftEntityFramework"
    {
        // se crea el constructor de la clase
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
        }

        //Nota: se hace la importacion del modelo en DbSet seleccionando "usingCrudEntityFramework"
        public DbSet<Usuario> Usuario { get; set; }
    }
}
