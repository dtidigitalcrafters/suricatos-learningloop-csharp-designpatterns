﻿using PokeVenture.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeVenture.Tipos
{
    class TipoAgua : Pokemon
    {
        public TipoAgua(string especie, int nivel)
        {
            _especie = especie;
            _nivel = nivel;
        }

        public string _tipo { get { return Constants.AGUA; } }
        public override double Ataque()
        {
            return _golpe.Atacar(_tipo, _nivel);
        }
    }
}
