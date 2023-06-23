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
    public partial class UpdateBook : System.Web.UI.Page
    {
        BookController bookController = new BookController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request["ID"]);

                Book book = bookController.getBookById(id);

                publisher_selector.DataSource = bookController.getAllPublisherName();
                publisher_selector.DataBind();

                bookName_TextBox.Text = book.Name;
                bookISBN_TextBox.Text = book.ISBN;
                bookPrice_TextBox.Text = book.Price.ToString();
                year_TextBox.Text = book.Year.ToString();
                publisher_selector.SelectedValue = book.Publisher.Name;
            }
        }

        protected void updateBook_Btn_Click(object sender, EventArgs e)
        {
            int publisherId = bookController.getPublisherId(publisher_selector.Text.ToString());
            string bookName = bookName_TextBox.Text.ToString();
            string bookISBN = bookISBN_TextBox.Text.ToString();
            DateTime bookYear = Convert.ToDateTime(year_TextBox.Text.ToString());
            int bookPrice = Convert.ToInt32(bookPrice_TextBox.Text.ToString());

            bookController.updateBook(int.Parse(Request["ID"]), bookISBN, publisherId, bookName, bookYear, bookPrice);
            Response.Redirect("~/Views/Books/ViewBooks.aspx");
        }
    }
}