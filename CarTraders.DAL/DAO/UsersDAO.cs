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
                user.CreatedAt = DateTime.Now;
                db.Users.InsertOnSubmit(user);
                db.SubmitChanges();

                User userFromDb = db.Users.FirstOrDefault(u => u.Id == user.Id);
                return userFromDb;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }

        public static User GetUserByEmailAndPassword(string type, string email, string password)
        {
            try
            {
                var user = db.Users.FirstOrDefault(u => u.Type == type && u.Email == email && u.Password == password);
                return user;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }
    }
}
