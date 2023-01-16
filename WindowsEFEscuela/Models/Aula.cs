using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Aula")]
    public class Aula
    {
        public int Id { get; set; }
        [Required]
        public int Capacidad { get; set; }
        [Column(TypeName = "char")] //tipo de datos en SQL server
        [StringLength(1)] //cantidad de caracteres de la cadena
        [Required] //es obligatorio, no acepta nulos
        public string Codigo { get; set; }
    }
}
