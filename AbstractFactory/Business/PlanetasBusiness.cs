using System.Collections.Generic;
using AbstractFactory.Business.PtBrFormatter;
using AbstractFactory.Business.SqlFormatter;
using AbstractFactory.Repository;

namespace AbstractFactory.Business
{
    public class PlanetaBusiness
    {
        private PlanetaRepository _repositorio = new PlanetaRepository();
        
        public string GetCsv(string tipo)
        {
            var planetas = _repositorio.GetSistemaSolar();

            IFormatterFactory formatterFactory;
            if (tipo == "sql")
                formatterFactory = new SqlFormatterFactory();
            else
                formatterFactory = new PtBrFormatterFactory();

            return BuildCsv(new CsvBuilder(formatterFactory), planetas);
        }

        private string BuildCsv(CsvBuilder builder, IList<PlanetaEntity> planetas)
        {
            builder.AddHeader("Nome", "Descoberta", "Número de Luas", "Período Orbital");
            foreach (var p in planetas)
            {
                builder.AddLinha(p.Nome, p.Descoberta, p.NumLuas, p.PeriodoOrbital);
            }
            
            return builder.ToString();
        }
    }
}

