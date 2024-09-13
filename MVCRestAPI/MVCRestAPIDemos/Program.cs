using MVCRestAPIDemos.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSingleton<IStoreListRepository,StoreListRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapControllers();

app.Run();
