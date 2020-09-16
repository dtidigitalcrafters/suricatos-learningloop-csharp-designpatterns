using PokeVenture.Golpes;
using PokeVenture.Golpes.ListaGolpes;
using PokeVenture.Tipos;
using System;
using System.Collections.Generic;

namespace PokeVenture
{
    class Program
    {
        static void Main(string[] args)
        {

            IGolpe megaPunch = new MegaPunch();
            IGolpe flameThrower = new FlameThrower();
            IGolpe bubbleBeam = new BubbleBeam();
            IGolpe scratch = new Scratch();
            IGolpe leechSeed = new LeechSeed();

            Pokemon charmander = new TipoFogo("Charmander", 5);
            Pokemon bulbasaur = new TipoPlanta("Bulbasaur", 5);
            Pokemon squirtle = new TipoAgua("Squirtle", 5);
            Pokemon pikachu = new TipoEletrico("Pikachu", 5);
            Pokemon meowth = new TipoNormal("Meowth", 5);


            List <Pokemon> especies = new List<Pokemon>() { charmander, bulbasaur, squirtle, pikachu, meowth };
            List<IGolpe> golpes = new List<IGolpe>() { megaPunch, flameThrower, bubbleBeam, scratch, leechSeed };

            foreach (Pokemon pokemon in especies)
            {
                foreach (IGolpe golpe in golpes)
                {
                    pokemon._golpe = golpe;
                    Console.WriteLine("{0} no nível {1} utilizando {2} causa dano de {3}HP",
                        pokemon._especie, pokemon._nivel, pokemon._golpe._nomeGolpe, pokemon.Ataque());

                }
            }
             }
    }
}
