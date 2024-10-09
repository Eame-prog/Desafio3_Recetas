using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionRecetas.Models
{
    public class PasosPreparacion
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(125, MinimumLength = 10, ErrorMessage = "La descripción debe tener minimo 10 caracteres")]
        [Display(Name = "Descripción del paso")]
        public string Descripcion { get; set; } = string.Empty;

        [Display(Name = "Orden del paso (1,2,3,...)")]
        public int Orden { get; set; }

        //Propiedad para la llave foranea
        [ForeignKey("Receta")]
        public int? RecetaId { get; set; }
        public Receta Receta { get; set; }
    }
}
