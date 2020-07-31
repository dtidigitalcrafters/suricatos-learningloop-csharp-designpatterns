using System;

public class MainClass
{
	public static void Main()
	{
		ITarget ITarget = new LibraryAdapter();
		Library Library = new Library(ITarget);

		Library.ShowBooks();
	}


}
