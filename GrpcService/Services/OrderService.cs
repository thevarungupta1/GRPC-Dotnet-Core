using Grpc.Core;
using GrpcService.Models;
using GrpcService;

namespace GrpcService.Services
{
    public class OrderService: OrderProcessing.OrderProcessingBase
    {
        private readonly ILogger _logger;
        private readonly IOrderReposiory orderReposiory;
        public OrderService(ILogger logger, IOrderReposiory orderReposiory)
        {
            _logger = logger;
            this.orderReposiory = orderReposiory;
        }

        public override Task<OrderResponse> GetOrder(OrderRequest request, 
            ServerCallContext context)
        {
            return Task.FromResult(
                new OrderResponse
                {
                    Order = orderReposiory.GetOrder().Result
                });
        }
    }
}
