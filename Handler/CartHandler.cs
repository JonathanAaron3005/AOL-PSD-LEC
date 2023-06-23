using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSD_LEC.Model;
using PSD_LEC.Repository;

namespace PSD_LEC.Handler
{
    public class CartHandler
    {
        CartRepository cartRepository = new CartRepository();
        public void createCart(int userId, int bookId, int quantity)
        {
            cartRepository.createCart(userId, bookId, quantity);
        }

        public void deleteCarts(int memberId)
        {
            cartRepository.deleteCarts(memberId);
        }

        //ini bukan buat tampilin data carts, cmn buat delete aja kalo member nya clear cart
        public List<Cart> getAllCartsById(int memberId)
        {
            return cartRepository.getAllCartsById(memberId); ;
        }

        public dynamic getCarts(int userId)
        {
            return cartRepository.getCarts(userId);
        }
    }
}