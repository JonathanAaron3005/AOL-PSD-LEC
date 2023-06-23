using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSD_LEC.Model;
using PSD_LEC.Factory;

namespace PSD_LEC.Repository
{
    public class CartRepository
    {
        Database1Entities1 db = new Database1Entities1();

        public void createCart(int userId, int bookId, int quantity)
        {
            //Cart cart = CartFactory.createCart(userId, bookId, quantity);
            //db.Carts.Add(cart);
            //db.SaveChanges();
            Cart existingCart = db.Carts.FirstOrDefault(c => c.UserId == userId && c.BookId == bookId);

            if (existingCart != null)
            {
                existingCart.Quantity += quantity;
            }
            else
            {
                Cart cart = CartFactory.createCart(userId, bookId, quantity);
                db.Carts.Add(cart);
            }

            db.SaveChanges();
        }

        public void deleteCarts(int memberId)
        {
            List<Cart> del = getAllCartsById(memberId);
            foreach (Cart item in del)
            {
                db.Carts.Remove(item);
                db.SaveChanges();
            }
        }

        //ini bukan buat tampilin data carts, cmn buat delete aja kalo member nya clear cart
        public List<Cart> getAllCartsById(int memberId)
        {
            List<Cart> cartList = (from cart in db.Carts 
                                   where cart.User.Id == memberId 
                                   select cart).ToList();
            return cartList;
        }
        

        public dynamic getCarts(int userId)
        {
            return db.Carts.Join(db.Books,
                cart => cart.BookId,
                book => book.Id,
                (cart, book) => new
                {
                    UserID = cart.UserId,
                    BookISBN = book.ISBN,
                    PublisherID = book.PublisherId,
                    BookName = book.Name,
                    BookYear = book.Year,
                    BookPrice = book.Price,
                    Quantity = cart.Quantity,
                }).Join(db.Publishers,
                    bookCart => bookCart.PublisherID,
                    publisher => publisher.Id,
                    (bookCart, publisher) => new
                    {
                        UserID = bookCart.UserID,
                        BookISBN = bookCart.BookISBN,
                        PublisherName = publisher.Name,
                        BookName = bookCart.BookName,
                        BookYear = bookCart.BookYear,
                        BookPrice = bookCart.BookPrice,
                        Quantity = bookCart.Quantity,
                    }).Where(x => x.UserID == userId).ToList();
        }

    }
}