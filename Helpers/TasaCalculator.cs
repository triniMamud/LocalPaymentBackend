using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using TarjetasApp.Models;

namespace TarjetasApp.Helpers
{
    public class TasaCalculator : ITasaCalculator
    {
        //Cada marca tiene un modo de calcular una tasa por el servicio
        public double CalcularTasaPorcentual(Marca marca, DateTime date)
        {
            switch (marca)
            {
                case Marca.SQUA:
                    return (double)date.Year / (double)date.Month;
                case Marca.SCO:
                    return (double)date.Month * 0.5;
                case Marca.PERE:
                    return (double) date.Month * 0.1;
            }
            throw new InvalidEnumArgumentException();
        }

        //Obtener por medio de un método la tasa de una operación informando marca e importe
        public double CalcularTasaNominal(Marca marca, DateTime date, double importe)
        {
            return CalcularTasaPorcentual(marca, date) * importe;
        }
    }
}
