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
            catch (Exception ex)
            {
                return null;
                throw ex;
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
                carFromDb.Image = car.Image;
                carFromDb.ImageName = car.ImageName;
                carFromDb.UpdatedAt = DateTime.Now;

                db.SubmitChanges();

                return carFromDb;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }

        public static bool DeleteCar(Car car)
        {
            try
            {              
                Car carFromDb = db.Cars.FirstOrDefault(c => c.Id == car.Id);
                db.Cars.DeleteOnSubmit(carFromDb);
                db.SubmitChanges();

                Car carFromDbAfterDelete = db.Cars.FirstOrDefault(c => c.Id == car.Id);
                var isDeleted = carFromDbAfterDelete == null;
                return isDeleted;               
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public static List<Car> GetCars()
        {
            try
            {
                return db.Cars.OrderBy(x => x.CreatedAt).ToList();
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }

        public static Car GetCarById(Guid id)
        {
            try
            {
                return db.Cars.FirstOrDefault(c => c.Id == id);
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }
    }
}
