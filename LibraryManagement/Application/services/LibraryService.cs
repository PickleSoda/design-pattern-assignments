using System.Collections.Generic;
using LibraryManagement.Core.Entities;
using LibraryManagement.Core.Interfaces;

namespace LibraryManagement.Application.Services
{
    public class LibraryService
    {
        private List<Book> books;

        public LibraryService()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public IIterator<Book> CreateIterator()
        {
            return new LibraryIterator(books);
        }
    }

    public class LibraryIterator : IIterator<Book>
    {
        private List<Book> _books;
        private int _position = 0;

        public LibraryIterator(List<Book> books)
        {
            _books = books;
        }

        public bool HasNext()
        {
            return _position < _books.Count;
        }

        public Book Next()
        {
            return _books[_position++];
        }
    }
}
