using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSD_LEC.Controller;
using PSD_LEC.Model;

namespace PSD_LEC.Views.Users
{
    public partial class Login : System.Web.UI.Page
    {
        UserController userController = new UserController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null || Request.Cookies["UserCookie"] != null)
            {
                Response.Redirect("~/Views/Books/ViewBooks.aspx");
            }
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTxt.Text.ToString();
            string password = PasswordTxt.Text.ToString();
            bool rememberMe = RememberCheckBox.Checked;
            string valid = userController.validateLogin(username, password, rememberMe);

            if (valid == null || valid == "")
            {
                int id = (int)Session["ID"];
                User user = userController.getUserById(id);
                //int roleId = user.RoleId

                Response.Redirect("~/Views/Books/ViewBooks.aspx");
            }
            else
            {
                ErrorLbl.Text = valid;
                ErrorLbl.Visible = true;
            }
        }
    }
}