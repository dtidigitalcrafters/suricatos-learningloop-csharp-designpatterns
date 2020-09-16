using System;
using System.Collections.Generic;
using System.Text;

namespace PokeVenture.Golpes
{
    class GolpeEspecial : Golpe, IGolpe
    {
        public double Atacar(string tipoPokemon, int nivelPokemon)
        {
            double forcaGolpe = (nivelPokemon / 3) * _forcaBase;
            if (tipoPokemon == _tipoGolpe) return 2 * forcaGolpe;

            return forcaGolpe;
        }
    }
}
