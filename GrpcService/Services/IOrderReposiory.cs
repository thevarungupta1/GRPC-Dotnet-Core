using GrpcService.Models;
namespace GrpcService.Services
{
    public interface IOrderReposiory
    {
        public Task<Order> GetOrder();
    }
}
