using System;
public class Book {
    public string title, isbn;
    public double price;
}
public class Program {
    public static void Main(string[] args) {
        Book book1 = new Book();
        book1.title = "C# Programming";
        book1.isbn = "180056810X";
        book1.price = 42.74;
        Console.WriteLine($"title: {book1.title}, ISBN: {book1.isbn}, Price: {book1.price}");
        Console.WriteLine("book price increased!");
        increateBookPrice(book1, 10);
        Console.WriteLine($"title: {book1.title}, ISBN: {book1.isbn}, Price: {book1.price}");
    }
    public static void increateBookPrice(Book book, double price) {
        book.price += price;
    }
}
