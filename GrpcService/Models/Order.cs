namespace GrpcService.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public int Qty { get; set; }
    }
}
