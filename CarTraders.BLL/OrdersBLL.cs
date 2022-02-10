using CarTraders.DAL;
using CarTraders.DAL.DAO;
using CarTraders.DAL.DTO;
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

        public static List<OrderItemDto> GetCartItemsOfUser(Guid userId)
        {
            var cartItems = OrdersDAO.GetCartItemsOfUser(userId);
            var orderItemsDtos = new List<OrderItemDto>();

            foreach (OrderItem item in cartItems)
            {
                var dto = new OrderItemDto();
                dto.Id = item.Id;
                dto.ProductId = item.ProductId;
                dto.Price = item.Price;
                dto.Quantity = item.Quantity;
                dto.ProductType = item.ProductType;

                // Access product name using id and pass with OrderItemDto
                switch (item.ProductType)
                {
                    case "Car":
                        dto.ProductName = CarsDAO.GetCarById(item.ProductId).Name;
                        break;
                    case "CarPart":
                        dto.ProductName = CarPartsDAO.GetCarPartById(item.ProductId).Name;
                        break;
                    default:
                        break;
                }

                orderItemsDtos.Add(dto);
            }

            return orderItemsDtos;
        }

        public static List<Order> GetOrders()
        {
            return OrdersDAO.GetOrders();
        }

        public static bool DeleteOrderItem(Guid id)
        {
            return OrdersDAO.DeleteOrderItem(id);
        }

        public static Order AddOrder(Order order)
        {
            return OrdersDAO.AddOrder(order);
        }

        public static void UpdateOrderItemsOrderId(List<Guid> orderItemIds, Guid orderId)
        {
            OrdersDAO.UpdateOrderItemsOrderId(orderItemIds, orderId);
        }
    }
}
