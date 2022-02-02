using System;
using System.Linq;

namespace CarTraders.DAL.DAO
{
    public class CarsDAO : DbContext
    {
        public static Car AddCar(Car car)
        {
            try
            {
                db.Cars.InsertOnSubmit(car);
                db.SubmitChanges();
                return car;
            }
            catch
            {
                return null;
            }
        }
    }
}
