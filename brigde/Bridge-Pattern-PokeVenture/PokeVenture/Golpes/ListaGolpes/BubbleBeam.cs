using PokeVenture.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeVenture.Golpes.ListaGolpes
{
    class BubbleBeam : GolpeEspecial, IGolpe
    {
        public BubbleBeam()
        {
            _forcaBase = 23;
            _tipoGolpe = Constants.AGUA;
            _nomeGolpe = "Bubble Beam";
        }
    }
}
