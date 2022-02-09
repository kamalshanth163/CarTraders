using CarTraders.DAL;
using CarTraders.DAL.DAO;
using OrderTraders.DAL.DAO;
using System;
using System.Collections.Generic;

namespace CarTraders.BLL
{
    public class OrdersBLL
    {
        public static OrderItem AddOrderItem(OrderItem orderItem)
        {
            return OrdersDAO.AddOrderItem(orderItem);
        }

    }
}
