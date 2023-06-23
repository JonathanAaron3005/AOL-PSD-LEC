using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSD_LEC.Model;
using PSD_LEC.Handler;

namespace PSD_LEC.Controller
{
    public class UserController
    {
        UserHandler userHandler = new UserHandler();

        public void register(int roleId, string username, string email, string gender, string password)
        {
            userHandler.register(roleId, username, email, gender, password);
        }

        public string validateLogin(string username, string password, bool rememberMe)
        {
            if (username.Length == 0)
            {
                return "Username cannot be empty";
            }

            if (password.Length == 0)
            {
                return "Password cannot be empty";
            }

            User user = userHandler.validateUser(username, password);

            if (user == null)
            {
                return "Credential is not valid";
            }
            //List<Raman> cart = new List<Raman>();
            HttpContext.Current.Session["Role"] = "User";
            HttpContext.Current.Session["User"] = user;
            HttpContext.Current.Session["Username"] = username;
            HttpContext.Current.Session["ID"] = user.Id;
            HttpContext.Current.Session["Email"] = user.Email;
            //HttpContext.Current.Session["Cart"] = cart;
            if (rememberMe)
            {
                HttpCookie userCookie = new HttpCookie("UserCookie");
                userCookie.Values.Add("UserId", user.Id.ToString());
                userCookie.Values.Add("Username", user.Username);
                userCookie.Values.Add("Password", password);
                userCookie.Expires = DateTime.Now.AddHours(24);
                HttpContext.Current.Response.Cookies.Add(userCookie);
            }
            return null;
        }

        public string registerValidation(int roleId, string username, string email, string gender,
            string password, string confirmPassword)
        {
            if (username.Length < 5 || username.Length > 15)
            {
                return "Username must be between 5 and 15 characters.";
            }

            if (!email.EndsWith(".com"))
            {
                return "Email Must ends with ‘.com’.";
            }

            if (gender.Length == 0)
            {
                return "Gender Must be chosen.";
            }

            if (password != confirmPassword)
            {
                return "Password must be the same with confirm password.";
            }

            if (confirmPassword != password)
            {
                return "Confirm password Must be the same with password.";
            }

            //register
            userHandler.register(roleId, username, email, gender, password);

            return null;
        }

        public User validateUser(string username, string pw)
        {
            return userHandler.validateUser(username, pw);
        }

        public User getUserById(int id)
        {
            return userHandler.getUserById(id);
        }

        public List<User> GetAllMember()
        {
            return userHandler.GetAllMember();
        }

        public List<User> GetAllStaff()
        {
            return userHandler.GetAllStaff();
        }

        public void updateUser(int id, int roleId, string username, string email, string gender,
           string password)
        {
            userHandler.updateUser(id, roleId, username, email, gender, password);
        }

        public List<String> getAllRoleName()
        {
            return userHandler.getAllRoleName();
        }

        public int getRoleId(string roleName)
        {
            return userHandler.getRoleId(roleName);
        }
    }
}