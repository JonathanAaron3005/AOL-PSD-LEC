using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSD_LEC.Model;
using PSD_LEC.Factory;

namespace PSD_LEC.Repository
{
    public class UserRepository
    {
        Database1Entities1 db = new Database1Entities1();

        public void register(int roleId, string username, string email, string gender, string password)
        {
            User user = UserFactory.createUser(roleId, username, email, gender, password);
            db.Users.Add(user);
            db.SaveChanges();
        }

        public User validateUser(string username, string password)
        {
            User user = db.Users.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
            return user;
        }

        public User getUserById(int id)
        {
            return db.Users.Find(id);
        }

        public List<User> GetAllMember()
        {
            List<User> members = db.Users.Where(x => x.RoleId == 1).ToList();
            //Roleid utk member == 1
            return members;
        }

        public List<User> GetAllStaff()
        {
            List<User> staff = db.Users.Where(x => x.RoleId == 2).ToList();
            //Roleid utk staff == 2
            return staff;
        }

        public void updateUser(int id, int roleId, string username, string email, string gender,
           string password)
        {
            User user = getUserById(id);
            user.Username = username;
            user.RoleId = roleId;
            user.Email = email;
            user.Gender = gender;
            user.Password = password;
            db.SaveChanges();
        }

        public List<String> getAllRoleName()
        {
            return (from role in db.Roles select role.Name).ToList();
        }

        public int getRoleId(string roleName)
        {
            return (from role in db.Roles 
                    where role.Name == roleName 
                    select role.Id).ToList().FirstOrDefault();
        }
    }
}