using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestionRecetas.Models.Seed
{
    public class PasosPreparacionSeed : IEntityTypeConfiguration<PasosPreparacion>
    {
        public void Configure(EntityTypeBuilder<PasosPreparacion> builder)
        {

            builder.HasData(

                    //Pasos receta 1
                    new PasosPreparacion
                    {
                        ID = 1,
                        Descripcion = "Lavar la lechuga romana y cortarla en trozos",
                        Orden = 1,
                        RecetaId = 1
                    },
                    new PasosPreparacion
                    {
                        ID = 2,
                        Descripcion = "Asar el pollo a la parrilla y cortarlo en tiras",
                        Orden = 2,
                        RecetaId = 1
                    },
                    new PasosPreparacion
                    {
                        ID = 3,
                        Descripcion = "Mezclar la lechuga, el pollo y el aderezo césar",
                        Orden = 3,
                        RecetaId = 1
                    },
                    //Pasos receta 2
                    new PasosPreparacion
                    {
                        ID = 4,
                        Descripcion = "Cocinar la pasta en agua hirvindo con sal",
                        Orden = 1,
                        RecetaId = 2
                    },
                    new PasosPreparacion
                    {
                        ID = 5,
                        Descripcion = "Mezclar el huevo, la crema y el queso parmesano",
                        Orden = 2,
                        RecetaId = 2
                    },
                    new PasosPreparacion
                    {
                        ID = 6,
                        Descripcion = "Añadir la mezcla a la pasta caliente",
                        Orden = 3,
                        RecetaId = 2
                    },
                    //Pasos receta 3
                    new PasosPreparacion
                    {
                        ID = 7,
                        Descripcion = "Cortar los tomates y hervirlos hasta que se ablanden",
                        Orden = 1,
                        RecetaId = 3
                    },
                    new PasosPreparacion
                    {
                        ID = 8,
                        Descripcion = "Licuar los tomates y agregar la albahaca",
                        Orden = 2,
                        RecetaId = 3
                    },
                    new PasosPreparacion
                    {
                        ID = 9,
                        Descripcion = "Cocinar por 10 minutos más y servir caliente",
                        Orden = 3,
                        RecetaId = 3
                    }
                );
        }
    }
}
