using Grpc.Net.Client;
using GrpcGreeterClient;
using GrpcProductClient;


var message = new HelloRequest
{
    Name = "Sachin Tendulakar"
};

var channel = GrpcChannel.ForAddress("http://localhost:5276");
//var client = new Greeter.GreeterClient(channel);
//var serverReply = await client.SayHelloAsync(message);
//Console.WriteLine(serverReply.Message);
//Console.ReadLine();

var product = new GetProductDetail
{
    ProductId = 2
};

var client = new Product.ProductClient(channel);
var serverReply = await client.GetProductsInformationAsync(product);
Console.WriteLine($"{serverReply.ProductName} | {serverReply.ProductDescription}");
Console.ReadLine();



