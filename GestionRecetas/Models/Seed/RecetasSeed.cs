using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestionRecetas.Models.Seed
{
    public class RecetasSeed : IEntityTypeConfiguration<Receta>
    {
        public void Configure(EntityTypeBuilder<Receta> builder) {

            builder.HasData(

                    new Receta 
                    { 
                        ID = 1, 
                        NombreReceta = "Ensalada César",
                        DescripcionReceta = "Ensalada clásica con pollo, lechuga y aderezo César",
                        TiempoReceta = "20 minutos"
                    },
                    new Receta
                    {
                        ID = 2,
                        NombreReceta = "Pasta Carbonara",
                        DescripcionReceta = "Pasta con salsa de crema, huevo y queso parmesano",
                        TiempoReceta = "30 minutos"
                    },
                    new Receta
                    {
                        ID = 1,
                        NombreReceta = "Sopa de Tomate",
                        DescripcionReceta = "Sopa ligera de tomate con albahaca",
                        TiempoReceta = "40 minutos"
                    }
                );
        }
    }
}
