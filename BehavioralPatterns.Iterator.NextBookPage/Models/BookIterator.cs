using BehavioralPatterns.Iterator.NextBookPage.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Iterator.NextBookPage.Models
{
    public class BookIterator : IIterator<Book>
    {
        private BookCollection _bookCollection;
        private int _currentIndex = 0;
        public BookIterator(BookCollection bookCollection)
        {
            _bookCollection = bookCollection;
        }
        public bool HasNext()
        {
            return _currentIndex < _bookCollection.GetBooks().Count;
        }

        public Book Next()
        {
            return _bookCollection.GetBooks()[_currentIndex++];
        }
    }
}
