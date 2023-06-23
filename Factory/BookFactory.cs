using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSD_LEC.Model;

namespace PSD_LEC.Factory
{
    public class BookFactory
    {
        public static Book createBook(string isbn, int publisherId, string name, DateTime year, int price)
        {
            Book book = new Book();
            book.ISBN = isbn;
            book.PublisherId = publisherId;
            book.Name = name;
            book.Year = year;
            book.Price = price;

            return book;
        }

        public static Publisher createPublisher(string name)
        {
            Publisher publisher = new Publisher();
            publisher.Name = name;

            return publisher;
        }
    }
}