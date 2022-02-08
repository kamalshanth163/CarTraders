using System;
using System.Collections.Generic;
using System.Linq;

namespace CarTraders.DAL.DAO
{
    public class CarPartsDAO : DbContext
    {
        public static CarPart AddCarPart(CarPart carPart)
        {
            try
            {
                carPart.CreatedAt = DateTime.Now;
                db.CarParts.InsertOnSubmit(carPart);
                db.SubmitChanges();
                return carPart;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }

        public static CarPart UpdateCarPart(CarPart carPart)
        {
            try
            {
                CarPart carPartFromDb = db.CarParts.FirstOrDefault(c => c.Id == carPart.Id);
                carPartFromDb.Name = carPart.Name;
                carPartFromDb.Brand = carPart.Brand;
                carPartFromDb.Price = carPart.Price;
                carPartFromDb.Description = carPart.Description;
                carPartFromDb.Image = carPart.Image;
                carPartFromDb.ImageName = carPart.ImageName;
                carPartFromDb.UpdatedAt = DateTime.Now;

                db.SubmitChanges();

                return carPartFromDb;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }

        public static bool DeleteCarPart(CarPart carPart)
        {
            try
            {              
                CarPart carPartFromDb = db.CarParts.FirstOrDefault(c => c.Id == carPart.Id);
                db.CarParts.DeleteOnSubmit(carPartFromDb);
                db.SubmitChanges();

                CarPart carPartFromDbAfterDelete = db.CarParts.FirstOrDefault(c => c.Id == carPart.Id);
                var isDeleted = carPartFromDbAfterDelete == null;
                return isDeleted;               
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public static List<CarPart> GetCarParts()
        {
            try
            {
                return db.CarParts.OrderBy(x => x.CreatedAt).ToList();
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }
    }
}
