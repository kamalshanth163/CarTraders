using System;

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
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
