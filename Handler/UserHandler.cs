using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSD_LEC.Model;
using PSD_LEC.Repository;

namespace PSD_LEC.Handler
{
    public class UserHandler
    {
        UserRepository userRepository = new UserRepository();

        public void register(int roleId, string username, string email, string gender, string password)
        {
            userRepository.register(roleId, username, email, gender, password);
        }

        public User validateUser(string username, string pw)
        {
            return userRepository.validateUser(username, pw);
        }

        public User getUserById(int id)
        {
            return userRepository.getUserById(id);
        }

        public List<User> GetAllMember()
        {
            return userRepository.GetAllMember();
        }

        public List<User> GetAllStaff()
        {
            return userRepository.GetAllStaff();
        }

        public void updateUser(int id, int roleId, string username, string email, string gender,
           string password)
        {
            userRepository.updateUser(id, roleId, username, email, gender, password);
        }

        public List<String> getAllRoleName()
        {
            return userRepository.getAllRoleName();
        }

        public int getRoleId(string roleName)
        {
            return userRepository.getRoleId(roleName);
        }
    }
}