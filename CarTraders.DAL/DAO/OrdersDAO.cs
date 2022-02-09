using CarTraders.DAL;
using CarTraders.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderTraders.DAL.DAO
{
    public class OrdersDAO : DbContext
    {
        public static OrderItem AddOrderItem(OrderItem orderItem)
        {
            try
            {
                orderItem.CreatedAt = DateTime.Now;
                db.OrderItems.InsertOnSubmit(orderItem);
                db.SubmitChanges();
                return orderItem;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }
    }
}
