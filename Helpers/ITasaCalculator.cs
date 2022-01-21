using System;
using TarjetasApp.Models;

namespace TarjetasApp.Helpers
{
    public interface ITasaCalculator
    {
        public double CalcularTasaPorcentual(Marca marca, DateTime date);
        public double CalcularTasaNominal(Marca marca, DateTime date, double importe);
    }
}