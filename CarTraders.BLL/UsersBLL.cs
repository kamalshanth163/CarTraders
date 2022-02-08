using CarTraders.DAL;
using CarTraders.DAL.DAO;
using System;
using System.Collections.Generic;

namespace CarTraders.BLL
{
    public class UsersBLL
    {
        public static User AddUser(User user)
        {
            return UsersDAO.AddUser(user);
        }

        public static User LoginUser(string type, string email, string password)
        {
            return UsersDAO.GetUserByEmailAndPassword(type, email, password);
        }

        public static User UpdateUser(User user)
        {
            return UsersDAO.UpdateUser(user);
        }

        public static bool DeleteUser(User user)
        {
            return UsersDAO.DeleteUser(user);
        }

        public static List<User> GetUsersByType(string type)
        {
            return UsersDAO.GetUsersByType(type);
        }
    }
}
