class AppleMaps : IMaps
{
	const string SOURCE_NAME = "Apple Maps";

	string IMaps.GetDirections()
	{
		return string.Format("Vire a Esquerda. Comando enviado por: {0}", SOURCE_NAME);
	}

	string IMaps.GetTimeToFinish()
	{
		return string.Format("Você chegará ao seu destino em 10 min. Comando enviado por: {0}", SOURCE_NAME);
	}
}