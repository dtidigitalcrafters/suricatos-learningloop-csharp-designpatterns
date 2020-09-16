using PokeVenture.Golpes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeVenture
{
    public abstract class Pokemon
    {
        public string _especie { get; set; }
        public int _nivel { get; set; }
        public IGolpe _golpe { get; set; }

        public abstract double Ataque();
    }
}
