using AbstractFactory.Business.PtBrFormatter;
using AbstractFactory.Repository;

namespace AbstractFactory.Business
{
    public class PlanetaBusiness
    {
        private PlanetaRepository _repositorio = new PlanetaRepository();
        
        public string GetCsv()
        {
            var planetas = _repositorio.GetSistemaSolar();
            var builder = new CsvBuilder(new PtBrFormatterFactory());
            
            builder.AddLinha("Nome", "Descoberta", "Número de Luas", "Período Orbital");
            foreach (var p in planetas)
            {
                builder.AddLinha(p.Nome, p.Descoberta, p.NumLuas, p.PeriodoOrbital);
            }
            
            return builder.ToString();
        }
    }
}

