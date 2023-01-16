using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Docente")]
    public class Profesor
    {
        [Column("Id")]
        [Key]
        public int ProfesorId { get; set; }
        [Column(TypeName = "varchar")] //tipo de datos en SQL server
        [StringLength(50)] //cantidad de caracteres de la cadena
        [Required] //es obligatorio, no acepta nulos
        public string Apellido { get; set; }
        [Column(TypeName = "varchar")] //tipo de datos en SQL server
        [StringLength(50)] //cantidad de caracteres de la cadena
        [Required] //es obligatorio, no acepta nulos
        public string Nombre { get; set; }

        [Column(TypeName = "varchar")] //tipo de datos en SQL server
        [StringLength(50)] //cantidad de caracteres de la cadena
        [Required] //es obligatorio, no acepta nulos
        public string Titulo { get; set; }


    }
}
