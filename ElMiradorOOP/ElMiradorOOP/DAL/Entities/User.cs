using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ElMiradorOOP.DAL.Entities
{
    public class User : Entity
    {
        [Display(Name = "Documento")] //le muestra al usuario en pantalla 
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]//es el valor de la propiedad y el 1 es el valor de la condicion o parametro
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Document { get; set; }

        [Display(Name = "Nombres")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string FirstName { get; set; }

        [Display(Name = "Apellidos")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string LastName { get; set; }

        [Display(Name = "Correo")]
        [MaxLength(200, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Email { get; set; }
             
    }
}
