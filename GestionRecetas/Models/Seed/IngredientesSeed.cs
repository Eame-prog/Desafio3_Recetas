using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GestionRecetas.Models.Seed
{
    public class IngredientesSeed : IEntityTypeConfiguration<Ingrediente>
    {
        public void Configure(EntityTypeBuilder<Ingrediente> builder)
        {
            builder.HasData(

                    //Ingredientes de receta 1
                    new Ingrediente
                    {
                        ID = 1,
                        NombreIngrediente = "Lechuga romana",
                        Cantidad = "1",
                        Unidad = "Unidad",
                        RecetaId = 1
                    },
                    new Ingrediente
                    {
                        ID = 2,
                        NombreIngrediente = "Pollo a la parrilla",
                        Cantidad = "200",
                        Unidad = "Gramos",
                        RecetaId = 1
                    },
                    new Ingrediente
                    {
                        ID = 3,
                        NombreIngrediente = "Aderezo César",
                        Cantidad = "50",
                        Unidad = "Mililitros",
                        RecetaId = 1
                    },
                    //Ingredientes de receta 2
                    new Ingrediente
                    {
                        ID = 4,
                        NombreIngrediente = "Pasta espagheti",
                        Cantidad = "250",
                        Unidad = "Gramos",
                        RecetaId = 2
                    },
                    new Ingrediente
                    {
                        ID = 5,
                        NombreIngrediente = "Crema de leche",
                        Cantidad = "100",
                        Unidad = "Mililitros",
                        RecetaId = 2
                    },
                    new Ingrediente
                    {
                        ID = 6,
                        NombreIngrediente = "Huevo",
                        Cantidad = "1",
                        Unidad = "Unidad",
                        RecetaId = 2
                    },
                    new Ingrediente
                    {
                        ID = 7,
                        NombreIngrediente = "Queso parmesano",
                        Cantidad = "50",
                        Unidad = "Gramos",
                        RecetaId = 2
                    },
                    //Ingredientes de receta 3
                    new Ingrediente
                    {
                        ID = 8,
                        NombreIngrediente = "Tomates frescos",
                        Cantidad = "500",
                        Unidad = "Gramos",
                        RecetaId = 3
                    },
                    new Ingrediente
                    {
                        ID = 9,
                        NombreIngrediente = "Albahaca",
                        Cantidad = "5",
                        Unidad = "Hojas",
                        RecetaId = 3
                    }
                );
        }


    }
}
