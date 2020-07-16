using System;

namespace AbstractFactory.Business.SqlFormatter
{
    public class SqlHeaderFormatter : IFormatter
    {
        public string Format(object value)
        {
            if (value is string)
                return ((string) value).ToLower().Replace(" ", "_");
            
            throw new ArgumentException($"Tipo não suportado ({value})");
        }
    }
}