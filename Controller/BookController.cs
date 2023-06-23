using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSD_LEC.Model;
using PSD_LEC.Handler;

namespace PSD_LEC.Controller
{
    public class BookController
    {
        BookHandler bookHandler = new BookHandler();

        public void createBook(string isbn, int publisherId, string name, DateTime year, int price)
        {
            bookHandler.createBook(isbn, publisherId, name, year, price);
        }

        public void deleteBook(int id)
        {
            bookHandler.deleteBook(id);
        }

        public Book getBookById(int id)
        {
            return bookHandler.getBookById(id);
        }

        public List<Book> getBooks()
        {
            return bookHandler.getBooks();
        }

        public void updateBook(int id, string isbn, int publisherId, string name,
            DateTime year, int price)
        {
            bookHandler.updateBook(id, isbn, publisherId, name, year, price);
        }

        public int getPublisherId(string name)
        {
            return bookHandler.getPublisherId(name);
        }

        public string validateBook(string name, string isbn, int price, DateTime year, int yearTxtBoxLength)
        {
            string priceString = price.ToString();

            if(name.Length == 0)
            {
                return "Name must be filled!";
            }
            else if(isbn.Length != 17)
            {
                return "ISBN must consist of 17 characters!";
            }
            else if (priceString.Length == 0)
            {
                return "Price must be filled";
            }
            else if (price < 5000)
            {
                return "Price must be at least 5000";
            }
            else if (yearTxtBoxLength == 0)
            {
                return "Year must be filled!";
            }
            else if(year > DateTime.Now)
            {
                return "Input a valid date!";
            }
            return "";
        }

        public List<String> getAllPublisherName()
        {
            return bookHandler.getAllPublisherName();
        }
    }
}