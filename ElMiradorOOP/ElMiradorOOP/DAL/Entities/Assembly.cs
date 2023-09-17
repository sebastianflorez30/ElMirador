using System.ComponentModel.DataAnnotations;

namespace ElMiradorOOP.DAL.Entities
{
    public class Assembly:Entity
    {
        [Display(Name = "Fecha Asamblea")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public DateOnly CreatedDate { get; set; }

        [Display(Name = "Hora Asamblea")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public TimeOnly CreatedTime { get; set; }

        [Display(Name = "Lugar Asamblea")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Place { get; set; }

        [Display(Name = "Agenda Asamblea")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Diary { get; set; }
    }
}
