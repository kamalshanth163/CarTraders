using System;
using System.Collections.Generic;
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

        public static User UpdateUser(User user)
        {
            try
            {
                User userFromDb = db.Users.FirstOrDefault(c => c.Id == user.Id);
                userFromDb.Name = user.Name;
                userFromDb.Address = user.Address;
                userFromDb.Phone = user.Phone;
                userFromDb.Email = user.Email;
                userFromDb.Password = user.Password;
                userFromDb.UpdatedAt = DateTime.Now;

                db.SubmitChanges();

                return userFromDb;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }

        public static bool DeleteUser(User user)
        {
            try
            {
                User userFromDb = db.Users.FirstOrDefault(c => c.Id == user.Id);
                db.Users.DeleteOnSubmit(userFromDb);
                db.SubmitChanges();

                User userFromDbAfterDelete = db.Users.FirstOrDefault(c => c.Id == user.Id);
                var isDeleted = userFromDbAfterDelete == null;
                return isDeleted;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public static List<User> GetUsersByType(string type)
        {
            try
            {
                return db.Users.Where(u => u.Type == type).OrderBy(x => x.CreatedAt).ToList();
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }
    }
}
