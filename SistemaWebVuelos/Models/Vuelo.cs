using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SistemaWebVuelos.Validations;

namespace SistemaWebVuelos.Models
{
    [Table("Vuelos")]
    public class Vuelo
    {
        [Required]
        public int Id { get; set; }

        /* Validaciones:
         * Campo Obligatorio
         * Fecha posterior a la actual
         * Formato de fecha latam (dd/MM/yyyy)
         */
        [Required]
        [Column(TypeName = "date")]
        [FechaMayorAFechaActual]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Destino { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Origen { get; set; }

        [Required]
        [Column(TypeName = "varchar(16)")]
        public string Matricula { get; set; }
    }
}
