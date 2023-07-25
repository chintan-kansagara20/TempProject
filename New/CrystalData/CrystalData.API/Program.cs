using AuthLayer.DataAccess.Impl;
using AuthLayer.DataAccess.Interface;
using AuthLayer.Mangers.Impl;
using AuthLayer.Mangers.Interface;
using CrystalData.Main;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddTransient<IUserDataAccess, UserDataAccess>();
builder.Services.AddTransient<IUserManager, UserManager>();

builder.Services.AddTransient<IRoleDataAccess, RoleDataAccess>();
builder.Services.AddTransient<IRoleManager, RoleManager>();

#region Dependency
Main.AddDependencies(builder.Services);
#endregion

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
