using MainSignalServer;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();

var app = builder.Build();

app.MapHub<MainHub>("/current-time");

// Change the port
app.Run("http://localhost:5001");
