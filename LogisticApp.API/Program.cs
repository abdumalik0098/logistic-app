using System.Net;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

IPAddress ip = IPAddress.Parse("127.0.0.1");
IPEndPoint endpoint = new IPEndPoint(ip, 7106);


app.MapControllers();

app.Run();
