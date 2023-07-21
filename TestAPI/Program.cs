using AuthLayer.DataAccess.Impl;
using AuthLayer.DataAccess.Interface;
using AuthLayer.Mangers.Interface;
using DataAccessLayer.Impl;
using DataAccessLayer.Interface;
using ManagersLayer.Impl;
using ManagersLayer.Interface;
using Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Dependency
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddTransient<ICvAssembliesManager, CvAssembliesManager>();
builder.Services.AddTransient<ICvAssembliesDataAccess, CvAssembliesDataAccess>();
builder.Services.AddTransient<ICvAssemblyCustomerOrderManager, cvAssemblyCustomerOrderManager>();
builder.Services.AddTransient<ICvAssemblyCustomerOrderDataAccess, CvAssemblyCustomerOrderDataAccess>();
builder.Services.AddTransient<ICvAssemblyDocumentMembersManager, CvAssemblyDocumentMembersManager>();
builder.Services.AddTransient<ICvAssemblyDocumentMembersDataAccess, CvAssemblyDocumentMembersDataAccess>();
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
