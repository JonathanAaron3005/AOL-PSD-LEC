using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSD_LEC.Model;
using PSD_LEC.Controller;

namespace PSD_LEC.Views.Books
{
    public partial class BookDetail : System.Web.UI.Page
    {
        BookController bookController = new BookController();
        CartController cartController = new CartController();
        UserController userController = new UserController();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int bookId = int.Parse(Request["ID"]);
                Book book = bookController.getBookById(bookId);

                bookName.Text = book.Name;
                bookISBN.Text = book.ISBN;
                bookPublisher.Text = book.Publisher.Name;
                bookPrice.Text = book.Price.ToString();
                bookYear.Text = book.Year.ToString();
            }
            int id = (int)Session["ID"];
            User user = userController.getUserById(id);
            int roleId = user.RoleId;

            //member
            if (roleId == 1)
            {
                updateBtn.Visible = false;
                deleteBtn.Visible = false;
                orderBtn.Visible = true;
                quantityTxt.Visible = true;
            }
            //staff
            else if (roleId == 2)
            {
                updateBtn.Visible = true;
                deleteBtn.Visible = true;
                orderBtn.Visible = false;
                quantityTxt.Visible = false;
            }
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request["ID"]);

            Response.Redirect("~/Views/Books/UpdateBook.aspx?ID=" + id);
        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request["ID"]);

            bookController.deleteBook(id);
            Response.Redirect("~/Views/Books/ViewBooks.aspx");
        }

        protected void orderBtn_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(Request["ID"]);
            int userId = (int)Session["ID"];
            int quantity = int.Parse(quantityTxt.Text.ToString());

            cartController.createCart(userId, bookId, quantity);
            Response.Redirect("~/Views/Carts/ViewCart.aspx");
        }
    }
}