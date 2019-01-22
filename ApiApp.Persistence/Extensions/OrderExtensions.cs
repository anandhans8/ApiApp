using ApiApp.Domain.Entities;

namespace ApiApp.Persistence.Infrastructure
{
    internal static class OrderExtensions
    {
        public static Order AddOrderDetails(this Order order, params OrderDetail[] orderDetails)
        {
            foreach (var orderDetail in orderDetails)
            {
                order.OrderDetails.Add(orderDetail);
            }

            return order;
        } 
    }
}
