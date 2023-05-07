using GrpcService.Models;

namespace GrpcService.Services
{
    public class OrderRepository : IOrderReposiory
    {
        public async Task<Order> GetOrder()
        {
            return await Task.FromResult(
                new Order
                {
                    OrderId = 1,
                    ShipAddress = "Address 1",
                    ShipCity = "City 1",
                    Qty = 100
                });
        }
    }
}
