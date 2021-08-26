using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebVuelos.Validations
{
    public class FechaMayorAFechaActual : ValidationAttribute
    {
        public FechaMayorAFechaActual()
        {
            ErrorMessage = "La fecha debe ser posterior a la fecha actual.";
        }

        public override bool IsValid(object value)
        {
            DateTime fechaActual = DateTime.Now;

            return ((DateTime)value > fechaActual) ? true : false;
        }
    }
}
