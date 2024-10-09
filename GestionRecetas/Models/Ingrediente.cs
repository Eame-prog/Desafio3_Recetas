using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionRecetas.Models
{
    public class Ingrediente
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 50 caracteres")]
        [Display(Name = "Nombre del ingrediente")]
        public string NombreIngrediente { get; set; } = string.Empty;

        public string Cantidad { get; set; } = string.Empty;

        [Display(Name = "Unidad de medida (gramos, litros, etc.)")]
        public string Unidad { get; set; } = string.Empty;

        //Propiedad para la llave foranea
        [ForeignKey("Receta")]
        public int? RecetaId { get; set; }
        public Receta Receta { get; set; }
    }
}
