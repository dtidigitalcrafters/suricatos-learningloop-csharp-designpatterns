using System;

namespace AbstractFactory.Business.PtBrFormatter
{
    public class PtBrFormatter : IFormatter
    {
        public string Format(object valor)
        {
            if (valor is string)
                return ((string) valor);
            if (valor is int)
                return valor.ToString();
            if (valor is double)
                return ((double) valor).ToString("0.00");
            if (valor is DateTime)
                return ((DateTime) valor).ToString("MM/dd/yyyy");
            if (valor is null)
                return "  -  ";

            throw new ArgumentException($"Tipo não suportado ({valor})");
        }
    }
}