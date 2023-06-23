using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSD_LEC.Model;
using PSD_LEC.Controller;

namespace PSD_LEC.Views
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        UserController userController = new UserController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                //logic kalo user belom login
                login_li.Visible = true;
                register_li.Visible = true;
                logout_Button.Visible = false;
                view_books_li.Visible = false;
                history_li.Visible = false;
                order_queue_li.Visible = false;
                insert_book_li.Visible = false;
                manage_book_li.Visible = false;
                cart_li.Visible = false;
            }
            else
            {
                login_li.Visible = false;
                register_li.Visible = false;
                logout_Button.Visible = true;

                //logic kalo user udah login
                int id = (int)Session["ID"];
                User user = userController.getUserById(id);
                int roleId = user.RoleId;

                //member
                if (roleId == 1)
                {
                    order_queue_li.Visible = false;
                    manage_book_li.Visible = false;
                    insert_book_li.Visible = false;

                    view_books_li.Visible = true;
                    history_li.Visible = true;
                    cart_li.Visible = true;
                }
                //staff
                else if (roleId == 2)
                {
                    order_queue_li.Visible = true;
                    manage_book_li.Visible = true;
                    insert_book_li.Visible = true;
                    history_li.Visible = true;
                    cart_li.Visible = false;

                    view_books_li.Visible = false;
                }

            }
        }

        protected void logout_Button_Click(object sender, EventArgs e)
        {
            Session["User"] = null;
            HttpContext.Current.Session.Clear();
            if (HttpContext.Current.Request.Cookies["UserCookie"] != null)
            {
                var userCookie = new HttpCookie("UserCookie");
                userCookie.Expires = DateTime.Now.AddDays(-1);
                HttpContext.Current.Response.Cookies.Add(userCookie);
            }
            Response.Redirect("~/Views/Users/Login.aspx");
        }
    }
}