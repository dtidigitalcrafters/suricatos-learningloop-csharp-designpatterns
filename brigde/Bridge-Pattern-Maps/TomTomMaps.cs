
class TomTomMaps : IMaps
{
	const string SOURCE_NAME = "TomTom Maps";

	string IMaps.GetDirections()
	{
		return string.Format("Siga em frente por 40 min. Comando enviado por: {0}", SOURCE_NAME);
	}

	string IMaps.GetTimeToFinish()
	{
		return string.Format("Você chegará ao seu destino em 42 min. Comando enviado por: {0}", SOURCE_NAME);
	}
}