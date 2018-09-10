using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortfolioIO.Orders.Models;

namespace PortfolioIO.Orders.Services
{
    public class OrderService : IOrderService
    {
        private IList<Order> _orders;


        public OrderService()
        {
            _orders = new List<Order>();
            _orders.Add(new Order("1000", "98 Misuta", DateTime.Now, 1, "0bb893e5-321a-4c6b-a3fd-f0b30811dfaf"));
            _orders.Add(new Order("2000", "MRS 11", DateTime.Now.AddHours(1), 2, "e5efcc1e-1e68-4eb9-b5dc-6235399cc056"));
            _orders.Add(new Order("3000", "Hviezdoslavova", DateTime.Now.AddHours(2), 3, "d4dcdeda-9803-4d5f-8d9d-8cfaf780fe27"));
            _orders.Add(new Order("4000", "Vysokoskolakov", DateTime.Now.AddDays(3), 4, "c0befdea-944d-4782-a40a-408061226a35"));
            _orders.Add(new Order("5000", "Malonecpalska", DateTime.Now.AddMinutes(13), 5, "c0befdea-944d-4782-a40a-408061226a35"));
        }

        public Task<IEnumerable<Order>> GetOrderAsync()
        {
            return Task.FromResult(_orders.AsEnumerable());
        }

        public Task<Order> GetOrderByIdAsync(string id)
        {
            return Task.FromResult(_orders.Single(o => Equals(o.Id, id)));
        }
    }

    public interface IOrderService
    {
        Task<Order> GetOrderByIdAsync(string id);
        Task<IEnumerable<Order>> GetOrderAsync();
    }
}
