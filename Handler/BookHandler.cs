using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSD_LEC.Model;
using PSD_LEC.Repository;

namespace PSD_LEC.Handler
{
    public class BookHandler
    {
        BookRepository bookRepository = new BookRepository();
        public void createBook(string isbn, int publisherId, string name, DateTime year, int price)
        {
            bookRepository.createBook(isbn, publisherId, name, year, price);
        }

        public void deleteBook(int id)
        {
            bookRepository.deleteBook(id);
        }

        public Book getBookById(int id)
        {
            return bookRepository.getBookById(id);
        }

        public List<Book> getBooks()
        {
            return bookRepository.getBooks();
        }

        public void updateBook(int id, string isbn, int publisherId, string name,
            DateTime year, int price)
        {
            bookRepository.updateBook(id, isbn, publisherId, name, year, price);
        }

        public int getPublisherId(string name)
        {
            return bookRepository.getPublisherId(name);
        }

        public List<String> getAllPublisherName()
        {
            return bookRepository.getAllPublisherName();
        }
    }
}