using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ElMiradorOOP.DAL.Entities
{
    public class Entity
    {
        [Key]//establece que el Id es una clave primaria (se pone encima del que se desea establecer)
        [Required] //establece que el campo es requerido (NOT NULL)
        public Guid Id { get; set; } //GUI = codigo encriptacion id

        [Display(Name = "Fecha de creación")]
        public DateTime? CreatedDate { get; set; } //fecha creacion en la base de datos, el ? quiere decir que estos campos pueden ser nulos 

        [Display(Name = "Fecha de modificación")]
        public DateTime? ModifiedDate { get; set; } //fecha modificacion en la base de datos
    }
}
