using System;

namespace AbstractFactory.Business.SqlFormatter
{
    public class SqlBodyFormatter : IFormatter
    {
        public string Format(object value)
        {
            if (value is null)
                return "NULL";
            if (value is string)
                return '"' + (string) value + '"';
            if (value is int)
                return value.ToString();
            if (value is double)
                return ((double) value).ToString("0.00").Replace(",", ".");
            if (value is DateTime)
            {
                if ((DateTime) value == default)
                    return "NULL";
                return ((DateTime) value).ToString("yyyy-MM-dd");                
            }

            throw new ArgumentException($"Tipo não suportado ({value})");
        }
    }
}