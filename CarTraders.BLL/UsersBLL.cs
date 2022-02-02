using CarTraders.DAL;
using CarTraders.DAL.DAO;
using System;

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
    }
}
