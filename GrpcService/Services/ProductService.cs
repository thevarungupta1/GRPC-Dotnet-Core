using Grpc.Core;
using GrpcService.Protos;

namespace GrpcService.Services
{
    public class ProductService : Product.ProductBase
    {
        private readonly ILogger<ProductService> _logger;

        public ProductService(ILogger<ProductService> logger)
        {
            _logger = logger;
        }

        public override Task<ProductModel> GetProductsInformation(GetProductDetail request, ServerCallContext context)
        {
            ProductModel productDetail = new ProductModel();
            if(request.ProductId == 1)
            {
                productDetail.ProductName = "Product 1";
                productDetail.ProductDescription = "Description 1";
                productDetail.ProductPrice = 10000;
                productDetail.ProductQty = 10;
            }
            else if(request.ProductId == 2)
            {
                productDetail.ProductName = "Product 2";
                productDetail.ProductDescription = "Description 2";
                productDetail.ProductPrice = 20000;
                productDetail.ProductQty = 10;
            }
            else if (request.ProductId == 3)
            {
                productDetail.ProductName = "Product 3";
                productDetail.ProductDescription = "Description 3";
                productDetail.ProductPrice = 30000;
                productDetail.ProductQty = 10;
            }

            return Task.FromResult(productDetail);
        }
    }
}
