
class GoogleMaps : IMaps
{
	const string SOURCE_NAME = "Google Maps";

	string IMaps.GetDirections()
	{
		return string.Format("Vire a Direita. Comando enviado por: {0}", SOURCE_NAME);
	}

	string IMaps.GetTimeToFinish()
	{
		return string.Format("Você chegará ao seu destino em 20 min. Comando enviado por: {0}", SOURCE_NAME);
	}
}