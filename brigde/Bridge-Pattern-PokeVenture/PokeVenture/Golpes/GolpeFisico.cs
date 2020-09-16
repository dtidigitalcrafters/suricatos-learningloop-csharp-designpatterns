using System;
using System.Collections.Generic;
using System.Text;

namespace PokeVenture.Golpes
{
    class GolpeFisico : Golpe, IGolpe
    {
        public double Atacar(string tipoPokemon, int nivelPokemon)
        {
            double forcaGolpe = (nivelPokemon/2) * _forcaBase;
            if (tipoPokemon == _tipoGolpe) return 1.2 * forcaGolpe;

            return forcaGolpe;
        }
    }
}