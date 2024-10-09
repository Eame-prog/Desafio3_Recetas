using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionRecetas.Models
{
    public class Receta
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres")]
        [Display(Name = "Nombre de producto")]
        public string NombreReceta { get; set; } = string.Empty;

        [Display(Name = "Descripción de Receta")]
        public string DescripcionReceta { get; set; } = string.Empty;

        [Display(Name = "Tiempo estimado de preparación")]
        public string TiempoReceta { get; set; } = string.Empty;

    }
}
