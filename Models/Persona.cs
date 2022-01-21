using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TarjetasApp.Models
{
    public class Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPersona { get; set; }
        [MaxLength(50)]
        [Required]
        public string Nombre { get; set; }
        [MaxLength(50)]
        [Required]
        public string Apellido { get; set; }
        [MaxLength(200)]
        [Required]
        public string Direccion { get; set; }
        public virtual ICollection<Tarjeta> Tarjetas { get; set; }

        [MaxLength(50)]
        [Required]
        public string DNI { get; set; }
    }
}
