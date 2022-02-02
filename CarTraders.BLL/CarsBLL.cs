using CarTraders.DAL;
using CarTraders.DAL.DAO;
using System;

namespace CarTraders.BLL
{
    public class CarsBLL
    {
        public static Car AddCar(Car car)
        {
            return CarsDAO.AddCar(car);
        }
    }
}
