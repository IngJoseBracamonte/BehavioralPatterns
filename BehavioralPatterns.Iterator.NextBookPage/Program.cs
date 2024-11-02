using BehavioralPatterns.Iterator.NextBookPage.Models;

var bookCollection = new BookCollection();
bookCollection.AddBook(new Book("The Catcher in the Rye"));
bookCollection.AddBook(new Book("To Kill a Mockingbird"));
bookCollection.AddBook(new Book("1984"));
var iterator = bookCollection.CreateIterator();

while (iterator.HasNext())
{
    var book = iterator.Next();
    Console.WriteLine($"Book Title: {book.Title}");
}