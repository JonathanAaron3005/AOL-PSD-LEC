using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSD_LEC.Model;

namespace PSD_LEC.Factory
{
    public class CartFactory
    {
        public static Cart createCart(int userId, int bookId, int qty)
        {
            Cart cart = new Cart();
            cart.UserId = userId;
            cart.BookId = bookId;
            cart.Quantity = qty;

            return cart;
        }
    }
}