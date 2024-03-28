using System;
public class Book
{
    public string title;
    public string isbn;
    public double price;
    public Book()
    {
        title = "";
        isbn = "";
        price = 0.0;
    }
    public Book(string t, string i, double p)
    {
        title = t;
        isbn = i;
        price = p;
    }
    public static void Display(Book b)
    { Console.WriteLine($"Title: {b.title}, ISBN: {b.isbn}, Price: {b.price}"); }
}

public class Program
{
    public static void Main(string[] args)
    {
        Book book1 = new Book("book 1", "121", 10.99);
        Book book2 = new Book("book 2", "122", 12.99);
        Book book3 = new Book("book 3", "123", 18.88);
        Book book4 = new Book("book 4", "124", 5.99);
        Book book5 = new Book("book 5", "125", 20.0);
        //book5.Display();
        Book.Display(book3);
    }
}
