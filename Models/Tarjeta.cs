using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TarjetasApp.Models
{
    public class Tarjeta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTarjeta { get; set; }
        [MaxLength(50)]
        [Required]
        public string Nombre { get; set; }
        [MaxLength(50)]
        [Required]
        public string Numero { get; set; }
        [MaxLength(50)]
        [Required]
        public string Titular { get; set; }
        [ForeignKey("Persona")]
        public int IdPersona { get; set; }
        [ForeignKey("IdPersona")]
        public virtual Persona Persona { get; set; }
        [Required]
        public long Limite { get; set; }
        [Required]
        public double Tasa { get; set; }
        [Required]
        public DateTime Vencimiento { get; set; }
        [Required]
        public Marca Marca { get; set; }

    }

    //existen tres marcas de tarjeta de crédito, a saber: “SQUA”, “SCO”, “PERE”
    public enum Marca
    {
        SQUA,
        SCO,
        PERE
    }
}
