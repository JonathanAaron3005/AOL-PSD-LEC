using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSD_LEC.Model;
using PSD_LEC.Controller;

namespace PSD_LEC.Views.Carts
{
    public partial class ViewCart : System.Web.UI.Page
    {
        CartController cartController = new CartController();
        TransactionController trController = new TransactionController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int userId = (int)Session["ID"];
                TableRepeater.DataSource = cartController.getCarts(userId);
                TableRepeater.DataBind();
            }
        }

        protected void buyCartBtn_Click(object sender, EventArgs e)
        {
            int userid = (int)Session["ID"];
            List<Cart> transactions = cartController.getAllCartsById(userid);
            int headerId = trController.createTransaction(userid, 1, DateTime.Now.AddYears(1000));
            foreach (Cart cart in transactions)
            {
                trController.createDetail(headerId, cart.BookId, cart.Quantity);
            }
            cartController.deleteCarts(userid);
            Response.Redirect("~/Views/Books/ViewBooks.aspx");
        }

        protected void clearCartBtn_Click(object sender, EventArgs e)
        {
            int userId = (int)Session["ID"];
            cartController.deleteCarts(userId);
            TableRepeater.DataSource = cartController.getCarts(userId);
            TableRepeater.DataBind();
        }
    }
}