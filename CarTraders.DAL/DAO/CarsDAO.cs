using System;
using System.Collections.Generic;
using System.Linq;

namespace CarTraders.DAL.DAO
{
    public class CarsDAO : DbContext
    {
        public static Car AddCar(Car car)
        {
            try
            {
                car.CreatedAt = DateTime.Now;
                db.Cars.InsertOnSubmit(car);
                db.SubmitChanges();
                return car;
            }
            catch
            {
                return null;
            }
        }

        public static Car UpdateCar(Car car)
        {
            try
            {
                Car carFromDb = db.Cars.FirstOrDefault(c => c.Id == car.Id);
                carFromDb.Name = car.Name;
                carFromDb.Brand = car.Brand;
                carFromDb.Price = car.Price;
                carFromDb.Description = car.Description;
                carFromDb.UpdatedAt = DateTime.Now;

                db.SubmitChanges();

                return carFromDb;
            }
            catch
            {
                return null;
            }
        }

        public static List<Car> GetCars()
        {
            try
            {
                return db.Cars.OrderBy(x => x.CreatedAt).ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}
