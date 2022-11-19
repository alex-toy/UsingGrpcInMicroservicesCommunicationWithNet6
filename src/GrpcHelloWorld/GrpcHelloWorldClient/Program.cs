// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;
using GrpcGreeterClient;


// The port number(5001) must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("https://localhost:5001");
var client = new Greeter.GreeterClient(channel);

HelloRequest? helloRequest = new HelloRequest { Name = "GreeterClient" };

var reply = await client.SayHelloAsync(helloRequest);

Console.WriteLine("Greeting: " + reply.Message);

Console.WriteLine("Press any key to exit...");
Console.ReadKey();