using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GestionRecetas.Models.Seed;

namespace GestionRecetas.Models
{
    public class RecetasDBContext : IdentityDbContext<Usuario>
    {
        public RecetasDBContext(DbContextOptions<RecetasDBContext> options)
            : base(options) 
        {
        }

        public DbSet<Receta> Recetas { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<PasosPreparacion> PasosPreparaciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.SeedUsuario_Roles();
            modelbuilder.ApplyConfiguration(new RecetasSeed());
            modelbuilder.ApplyConfiguration(new IngredientesSeed());
            modelbuilder.ApplyConfiguration(new PasosPreparacionSeed());
            base.OnModelCreating(modelbuilder);
        }
    }
}
