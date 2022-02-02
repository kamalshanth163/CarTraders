using CarTraders.DAL;
using CarTraders.DAL.DAO;
using System;
using System.Collections.Generic;

namespace CarTraders.BLL
{
    public class CarsBLL
    {
        public static Car AddCar(Car car)
        {
            return CarsDAO.AddCar(car);
        }

        public static List<Car> GetCars()
        {
            return CarsDAO.GetCars();
        }

        public static Car UpdateCar(Car car)
        {
            return CarsDAO.UpdateCar(car);
        }
    }
}
