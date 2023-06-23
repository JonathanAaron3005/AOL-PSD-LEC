using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSD_LEC.Model;
using PSD_LEC.Factory;

namespace PSD_LEC.Repository
{
    public class BookRepository
    {
        Database1Entities1 db = new Database1Entities1();

        public void createBook(string isbn, int publisherId, string name, DateTime year, int price)
        {
            Book book = BookFactory.createBook(isbn, publisherId, name, year, price);
            db.Books.Add(book);
            db.SaveChanges();
        }

        public List<Book> getBooks()
        {
            return db.Books.ToList();
        }

        public Book getBookById(int id)
        {
            return db.Books.Find(id);
        }

        public void updateBook(int id, string isbn, int publisherId, string name, 
            DateTime year, int price)
        {
            Book book = getBookById(id);
            book.ISBN = isbn;
            book.PublisherId = publisherId;
            book.Name = name;
            book.Year = year;
            book.Price = price;

            db.SaveChanges();
        }

        public void deleteBook(int id)
        {
            Book del = getBookById(id);
            db.Books.Remove(del);
            db.SaveChanges();
        }

        public int getPublisherId(string name)
        {
            return (from pub in db.Publishers where pub.Name == name select pub.Id).FirstOrDefault();
        }

        public List<String> getAllPublisherName()
        {
            return (from pub in db.Publishers select pub.Name).ToList();
        }
    }
}
