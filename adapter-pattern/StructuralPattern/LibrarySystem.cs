using System;

public class LibrarySystem
{
    public string[] GetBooks()
    {
        string[] bookArray = new string[5];
        bookArray[0] = "Clean Code (2008)";
        bookArray[1] = "The Art Of Computer Programming (1968)";
        bookArray[2] = "Design Patterns Elements of Reusable Object-Oriented Software (1994)";

        return bookArray;
    }
}
