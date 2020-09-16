using System;

class Navigator
{
	IMaps currentMapsSource = null;

	public IMaps MapsSource
	{
		get
		{
			return currentMapsSource;
		}
		set
		{
			currentMapsSource = value;
		}
	}

	public void GetDirections()
	{
		if (currentMapsSource != null)
		{
			Console.WriteLine(currentMapsSource.GetDirections());
		}
		else
		{
			Console.WriteLine("Please select a Map Source");
		}
	}

	public void GetTimeToFinish()
	{
		if (currentMapsSource != null)
		{
			Console.WriteLine(currentMapsSource.GetTimeToFinish());
		}
		else
		{
			Console.WriteLine("Please select a Map Source");
		}
	}
}
