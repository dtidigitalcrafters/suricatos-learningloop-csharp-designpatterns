using System;
using System.Collections.Generic;
using AbstractFactory.Business.PtBrFormatter;

namespace AbstractFactory.Business
{
    public class CsvBuilder
    {
        private string _csv;
        private PtBrFormatterFactory _formatterFactory;

        public CsvBuilder(PtBrFormatterFactory formatterFactory)
        {
            _formatterFactory = formatterFactory;
        }

        public void AddHeader(params object[] valores)
        {
            var headerFormatter = _formatterFactory.GetHeaderFormatter();

            foreach (var val in valores)
            {
                _csv += headerFormatter.Format(val);
                _csv += ";   ";
            }

            _csv += '\n';
        }
        
        public void AddLinha(params object[] valores)
        {
            var bodyFormatter = _formatterFactory.GetBodyFormatter();

            foreach (var val in valores)
            {
                _csv += bodyFormatter.Format(val);
                _csv += ";   ";
            }

            _csv += '\n';
        }

        public string ToString()
        {
            return _csv + '\n';
        }
    }
}