using PokeVenture.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeVenture.Golpes.ListaGolpes
{
    class Scratch : GolpeFisico, IGolpe
    {
        public Scratch()
        {
            _forcaBase = 15;
            _tipoGolpe = Constants.NORMAL;
            _nomeGolpe = "Scratch";
        }
    }
}
