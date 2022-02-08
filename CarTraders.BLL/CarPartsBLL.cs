using CarTraders.DAL;
using CarTraders.DAL.DAO;
using System;
using System.Collections.Generic;

namespace CarTraders.BLL
{
    public class CarPartsBLL
    {
        public static CarPart AddCarPart(CarPart carPart)
        {
            return CarPartsDAO.AddCarPart(carPart);
        }

        public static List<CarPart> GetCarParts()
        {
            return CarPartsDAO.GetCarParts();
        }

        public static CarPart UpdateCarPart(CarPart carPart)
        {
            return CarPartsDAO.UpdateCarPart(carPart);
        }
        public static bool DeleteCarPart(CarPart carPart)
        {
            return CarPartsDAO.DeleteCarPart(carPart);
        }
    }
}
