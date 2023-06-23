using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSD_LEC.Controller;

namespace PSD_LEC.Views.Books
{
    public partial class InsertBook : System.Web.UI.Page
    {
        BookController bookController = new BookController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                publisher_selector.DataSource = bookController.getAllPublisherName();
                publisher_selector.DataBind();
            }
        }

        protected void InsertBook_Btn_Click(object sender, EventArgs e)
        {
            string publisherName = publisher_selector.Text.ToString();
            int publisherId = bookController.getPublisherId(publisherName);
            string name = bookName_TextBox.Text.ToString();
            int price = 0;
            if(bookPrice_TextBox.Text.ToString().Length != 0)
            {
                price = Convert.ToInt32(bookPrice_TextBox.Text.ToString());
            }
            string isbn = bookISBN_TextBox.Text.ToString();
            DateTime year = DateTime.Now.AddDays(10000);
            int yearTxtBoxLength = year_TextBox.Text.ToString().Length;
            if (yearTxtBoxLength != 0)
            {
                year = Convert.ToDateTime(year_TextBox.Text.ToString());
            }
            errorText_Label.Visible = true;
            string errorMsg = bookController.validateBook(name, isbn, price, year, yearTxtBoxLength);
            errorText_Label.Text = errorMsg;

            if (errorMsg.Length == 0)
            {
                bookController.createBook(isbn, publisherId, name, year, price);
                Response.Redirect("~/Views/Books/ViewBooks.aspx");
            }
        }
    }
}