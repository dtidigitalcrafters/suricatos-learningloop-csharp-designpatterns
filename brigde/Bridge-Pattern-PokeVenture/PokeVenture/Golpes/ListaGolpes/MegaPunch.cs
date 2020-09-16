using PokeVenture.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeVenture.Golpes.ListaGolpes
{
    class MegaPunch : GolpeFisico, IGolpe
    {
        public MegaPunch()
        {
            _forcaBase = 20;
            _tipoGolpe = Constants.LUTADOR;
            _nomeGolpe = "Mega Punch";
        }
    }
}
