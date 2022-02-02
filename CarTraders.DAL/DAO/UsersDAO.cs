using System;
using System.Linq;

namespace CarTraders.DAL.DAO
{
    public class UsersDAO : DbContext
    {
        public static User AddUser(User user)
        {
            try
            {
                db.Users.InsertOnSubmit(user);
                db.SubmitChanges();
                return user;
            }
            catch
            {
                return null;
            }
        }

        public static User GetUserByEmailAndPassword(string type, string email, string password)
        {
            try
            {
                var user = db.Users.FirstOrDefault(u => u.Type == type && u.Email == email && u.Password == password);
                return user;
            }
            catch
            {
                return null;
            }
        }
    }
}
