using GrpcHelloWorldServer.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGrpc();

var app = builder.Build();



//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapGrpcService<HelloWorldService>();

//    endpoints.MapGet("/", async context =>
//    {
//        await context.Response.WriteAsync("Hello World!");
//    });
//});

//app.MapGet("/", () => "Hello World!");

app.MapGrpcService<HelloWorldService>();

app.Run();
