using CrystalData.DataAccess.Impl;
using CrystalData.DataAccess.Interface;
using CrystalData.Manager.Impl;
using CrystalData.Manager.Interface;

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

builder.Services.AddTransient<IAccessManager, AccessManager>();
builder.Services.AddTransient<IAccessDataAccess, AccessDataAccess>();

builder.Services.AddTransient<IAccessPermissionManager, AccessPermissionManager>();
builder.Services.AddTransient<IAccessPermissionDataAccess, AccessPermissionDataAccess>();

builder.Services.AddTransient<ICvAssemblyDetailsManager, CvAssemblyDetailsManager>();
builder.Services.AddTransient<ICvAssemblyDetailsDataAccess, CvAssemblyDetailsDataAccess>();
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
