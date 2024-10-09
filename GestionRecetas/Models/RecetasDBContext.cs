using Microsoft.EntityFrameworkCore;

namespace GestionRecetas.Models
{
    public class RecetasDBContext : DbContext
    {
        public RecetasDBContext(DbContextOptions<RecetasDBContext> options)
            : base(options) 
        {
        }

        public DbSet<Receta> Recetas { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<PasosPreparacion> PasosPreparaciones { get; set; }
    }
}
