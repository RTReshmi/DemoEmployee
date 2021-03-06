using DemoEmployee.db;
using DemoEmployee.Services;
using DemoEmployee.Services.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

builder.Services.AddDbContext<EmployeeDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("Default")
    ));
builder.Services.AddTransient<IEmployeeService,EmployeeService>();
builder.Services.AddTransient<ITeacherService, TeacherService>();
builder.Services.AddTransient<ICustomerServices, CustomerServices >();  



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
