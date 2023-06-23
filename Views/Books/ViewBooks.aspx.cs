using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSD_LEC.Controller;

namespace PSD_LEC.Views.Books
{
    public partial class ViewBooks : System.Web.UI.Page
    {
        BookController bookController = new BookController();

        protected void Page_Load(object sender, EventArgs e)
        {
            CardRepeater.DataSource = bookController.getBooks();
            CardRepeater.DataBind();
        }

        protected void OpenDetail_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)(sender);
            int id = int.Parse(btn.CommandArgument);

            Response.Redirect("~/Views/Books/BookDetail.aspx?ID=" + id);
        }
    }
}