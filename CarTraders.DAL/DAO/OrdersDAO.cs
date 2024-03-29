﻿using CarTraders.DAL;
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

        // Gets all the saved cart items which are not ordered for the user
        public static List<OrderItem> GetCartItemsOfUser(Guid userId)
        {
            try
            {
                return db.OrderItems.Where(i => i.UserId == userId && i.OrderId == null).OrderBy(x => x.CreatedAt).ToList();
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }

        public static bool DeleteOrderItem(Guid id)
        {
            try
            {
                OrderItem orderItemFromDb = db.OrderItems.FirstOrDefault(i => i.Id == id);
                db.OrderItems.DeleteOnSubmit(orderItemFromDb);
                db.SubmitChanges();

                Car orderItemFromDbAfterDelete = db.Cars.FirstOrDefault(c => c.Id == id);
                var isDeleted = orderItemFromDbAfterDelete == null;
                return isDeleted;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public static List<Order> GetOrdersByUserId(Guid userId)
        {
            try
            {
                return db.Orders.Where(o => o.UserId == userId).OrderBy(x => x.CreatedAt).ToList();
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }

        public static List<Order> GetOrders()
        {
            try
            {
                return db.Orders.OrderBy(x => x.CreatedAt).ToList();
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }

        public static Order AddOrder(Order order)
        {
            try
            {
                order.CreatedAt = DateTime.Now;
                db.Orders.InsertOnSubmit(order);
                db.SubmitChanges();
                return order;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }

        public static bool DeleteOrder(Guid id)
        {
            try
            {
                Order orderFromDb = db.Orders.FirstOrDefault(i => i.Id == id);
                db.Orders.DeleteOnSubmit(orderFromDb);
                db.SubmitChanges();

                Car orderFromDbAfterDelete = db.Cars.FirstOrDefault(c => c.Id == id);
                var isDeleted = orderFromDbAfterDelete == null;
                return isDeleted;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public static List<OrderItem> GetOrderItemsByOrderId(Guid id)
        {
            try
            {
                return db.OrderItems.Where(i => i.OrderId == id).OrderBy(x => x.CreatedAt).ToList();
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }

        public static bool UpdateOrderStatus(Guid id, string status)
        {
            try
            {
                Order orderFromDb = db.Orders.FirstOrDefault(i => i.Id == id);
                orderFromDb.Status = status;
                orderFromDb.UpdatedAt = DateTime.Now;
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public static bool UpdateOrderItemsOrderId(List<Guid> orderItemIds, Guid orderId)
        {
            try
            {
                foreach (Guid id in orderItemIds)
                {
                    OrderItem orderItemFromDb = db.OrderItems.FirstOrDefault(i => i.Id == id);
                    orderItemFromDb.OrderId = orderId;
                    orderItemFromDb.UpdatedAt = DateTime.Now;
                }
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
    }
}
