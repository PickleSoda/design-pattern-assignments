using System;
using LibraryManagement.Core.Entities;
using LibraryManagement.Application.Services;

namespace LibraryManagement.Presentation.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            // Create library service and add books
            var libraryService = new LibraryService();
            libraryService.AddBook(new Book("1984", "George Orwell", 1949));
            libraryService.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", 1960));
            libraryService.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925));

            // Create an iterator for the library
            var iterator = libraryService.CreateIterator();

            // Iterate over the books in the library
            while (iterator.HasNext())
            {
                var book = iterator.Next();
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
            }
        }
    }
}
