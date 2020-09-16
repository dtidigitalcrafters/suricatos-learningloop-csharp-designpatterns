namespace PokeVenture.Golpes
{
    public interface IGolpe
    {

        public int _forcaBase { get; set; }
        public string _tipoGolpe { get; set; }
        public string _nomeGolpe { get; set; }
        double Atacar(string tipoPokemon, int nivelPokemn);
    }
}