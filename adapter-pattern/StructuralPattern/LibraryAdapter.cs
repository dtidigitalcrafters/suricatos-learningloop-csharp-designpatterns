using System;
using System.Collections.Generic;

public class LibraryAdapter : LibrarySystem, ITarget
{
	public List<string> GetBookList()
	{
		List<string> bookList = new List<string>();
		string[] bookArray = GetBooks();
		foreach(string book in bookArray)
        {
			bookList.Add(book);
        }

		return bookList;
	}
}
