using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSD_LEC.Model;

namespace PSD_LEC.Factory
{
    public class UserFactory
    {
        public static User createUser(int roleid, string username, string email, string gender, string password)
        {
            User newUser = new User
            {
                RoleId = roleid,
                Username = username,
                Email = email,
                Gender = gender,
                Password = password
            };

            return newUser;
        } 
    }
}