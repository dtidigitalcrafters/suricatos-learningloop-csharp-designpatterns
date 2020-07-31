using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Reflection;

public class Library
{
	private ITarget BookSource;

	public Library(ITarget BookSource)
    {
        this.BookSource = BookSource;
    }

    public void ShowBooks()
    {
        List<string> bookList = BookSource.GetBookList();
        Console.WriteLine("Book List: \n");
        foreach (string book in bookList)
        {
            Console.WriteLine(book + "\n");
        }
    }
}
