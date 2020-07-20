using System;

namespace AbstractFactory.Repository
{
    public class PlanetaEntity
    {
        public string Nome { get; set; }
        public int NumLuas { get; set; }
        public double PeriodoOrbital { get; set; }
        public DateTime? Descoberta { get; set; }
    }
}