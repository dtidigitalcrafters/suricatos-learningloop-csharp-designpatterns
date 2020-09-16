using System;

class MainClass {
  public static void Main (string[] args) {
    Navigator myNav = new Navigator();
					
		Console.WriteLine("Selecione o Seu Navegador Padrão");
		Console.WriteLine("1. AppleMaps\n2. GoogleMaps\n3. TomTomMaps");

		ConsoleKeyInfo input = Console.ReadKey();

		switch (input.KeyChar)
		{
			case '1':
				myNav.MapsSource = new AppleMaps();
				break;

			case '2':
				myNav.MapsSource = new GoogleMaps();
				break;

			case '3':
				myNav.MapsSource = new TomTomMaps();
				break;                
		}

		Console.WriteLine(); 
		myNav.GetDirections();
		myNav.GetTimeToFinish();
		Console.WriteLine(); 
  }
}