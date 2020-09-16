using PokeVenture.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeVenture.Golpes.ListaGolpes
{
    class FlameThrower : GolpeEspecial, IGolpe
    {
        public FlameThrower()
        {
            _forcaBase = 25;
            _tipoGolpe = Constants.FOGO;
            _nomeGolpe = "Flame Thrower";
        }
    }
}
