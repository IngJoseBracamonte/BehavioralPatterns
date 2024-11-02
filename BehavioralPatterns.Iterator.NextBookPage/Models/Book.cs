using BehavioralPatterns.Iterator.NextBookPage.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Iterator.NextBookPage.Models
{
    public class Book
    {
        public string Title { get; set; }
        public Book(string title)
        {
            Title = title; 
        }
    }

    public class BookCollection : IAggregate<Book>
    {
        private List<Book> _books = new List<Book>();
        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public IIterator<Book> CreateIterator()
        {
            return new BookIterator(this);
        }

        public List<Book> GetBooks()
        {
            return _books;
        }
    }
}
