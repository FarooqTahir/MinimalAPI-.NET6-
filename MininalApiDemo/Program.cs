using MinimalApiDemo.DataAccess;
using MinimalApiDemo.DataAccess.Interface;
using MinimalApiDemo.Model;
using MininalApiDemo.EmployeeAPI;

var builder = WebApplication.CreateBuilder(args);

// Service Registration
builder.Services.AddScoped<IEmployeeRepository,EmployeeRepository>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/2", () => "Hello World 2!");

// Employee
app.RegisterEmployeeAPI();


app.Run();
