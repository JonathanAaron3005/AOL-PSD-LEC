using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSD_LEC.Model;
using PSD_LEC.Controller;

namespace PSD_LEC.Views.Users
{
    public partial class Register : System.Web.UI.Page
    {
        UserController userController = new UserController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                List<String> roleNames = userController.getAllRoleName();
                roleList.DataSource = roleNames;
                roleList.DataBind();

                List<String> genderTypes = new List<String> { "Male", "Female" };
                genderList.DataSource = genderTypes;
                genderList.DataBind();
            }
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            string email = EmailTxt.Text.ToString();
            string password = PasswordTxt.Text.ToString();
            string confirmPassword = ConfirmPasswordTxt.Text.ToString();
            string username = UsernameTxt.Text.ToString();
            string gender = genderList.Text.ToString();
            int roleId = userController.getRoleId(roleList.Text);

            string valid = userController.registerValidation(roleId, username, email, gender, password, confirmPassword);
            ErrorLbl.Text = valid;
            ErrorLbl.Visible = true;

            if (valid == null)
            {
                Response.Redirect("~/Views/Users/Login.aspx");
            }
        }
    }
}