using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSD_LEC.Model;
using PSD_LEC.Handler;

namespace PSD_LEC.Controller
{
    public class CartController
    {
        CartHandler cartHandler = new CartHandler();

        public void createCart(int userId, int bookId, int quantity)
        {
            cartHandler.createCart(userId, bookId, quantity);
        }

        public void deleteCarts(int memberId)
        {
            cartHandler.deleteCarts(memberId);
        }

        //ini bukan buat tampilin data carts, cmn buat delete aja kalo member nya clear cart
        public List<Cart> getAllCartsById(int memberId)
        {
            return cartHandler.getAllCartsById(memberId); ;
        }

        public dynamic getCarts(int userId)
        {
            return cartHandler.getCarts(userId);
        }
    }
}