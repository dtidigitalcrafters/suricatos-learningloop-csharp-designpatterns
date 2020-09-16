using PokeVenture.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeVenture.Golpes.ListaGolpes
{
    class LeechSeed : GolpeEspecial, IGolpe
    {
        public LeechSeed()
        {
            _forcaBase = 17;
            _tipoGolpe = Constants.PLANTA;
            _nomeGolpe = "Leech Seed";
        }
    }
}
