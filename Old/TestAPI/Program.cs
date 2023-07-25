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
builder.Services.AddTransient<ICvAssemblyProductionRecordManager, CvAssemblyProductionRecordManager>();
builder.Services.AddTransient<ICvAssemblyProductionRecordDataAccess, CvAssemblyProductionRecordDataAccess>();
builder.Services.AddTransient<ICvInventoryTransfersRepeaterManager, CvInventoryTransfersRepeaterManager>();
builder.Services.AddTransient<ICvInventoryTransfersRepeaterDataAccess, CvInventoryTransfersRepeaterDataAccess>();
builder.Services.AddTransient<IAccessManager, AccessManager>();
builder.Services.AddTransient<IAccessDataAccess, AccessDataAccess>();
builder.Services.AddTransient<IAccessPermissionManager, AccessPermissionManager>();
builder.Services.AddTransient<IAccessPermissionDataAccess, AccessPermissionDataAccess>();
builder.Services.AddTransient<IAccessPermissionMasterManager, AccessPermissionMasterManager>();
builder.Services.AddTransient<IAccessPermissionMasterDataAccess, AccessPermissionMasterDataAccess>();
builder.Services.AddTransient<IBranchManager, BranchManager>();
builder.Services.AddTransient<IBranchDataAccess, BranchDataAccess>();
builder.Services.AddTransient<IBusinessActivityManager, BusinessActivityManager>();
builder.Services.AddTransient<IBusinessActivityDataAccess, BusinessActivityDataAccess>();
builder.Services.AddTransient<IBusinessActivityHistoryManager, BusinessActivityHistoryManager>();
builder.Services.AddTransient<IBusinessActivityHistoryDataAccess, BusinessActivityHistoryDataAccess>();
builder.Services.AddTransient<IBusinessActivityRelatedItemsManager, BusinessActivityRelatedItemsManager>();
builder.Services.AddTransient<IBusinessActivityRelatedItemsDataAccess, BusinessActivityRelatedItemsDataAccess>();
builder.Services.AddTransient<IBusinessActivityTimeAndMaterialsManager, BusinessActivityTimeAndMaterialsManager>();
builder.Services.AddTransient<IBusinessActivityTimeAndMaterialsDataAccess, BusinessActivityTimeAndMaterialsDataAccess>();
builder.Services.AddTransient<ICarrierManager, CarrierManager>();
builder.Services.AddTransient<ICarrierDataAccess, CarrierDataAccess>();
builder.Services.AddTransient<ICarrierBillingOptionsManager, CarrierBillingOptionsManager>();
builder.Services.AddTransient<ICarrierBillingOptionsDataAccess, CarrierBillingOptionsDataAccess>();
builder.Services.AddTransient<ICarrierInsuranceOptionsManager, CarrierInsuranceOptionsManager>();
builder.Services.AddTransient<ICarrierInsuranceOptionsDataAccess, CarrierInsuranceOptionsDataAccess>();
builder.Services.AddTransient<ICarrierServiceManager, CarrierServiceManager>();
builder.Services.AddTransient<ICarrierServiceDataAccess, CarrierServiceDataAccess>();
builder.Services.AddTransient<ICarrierVoidOptionsManager, CarrierVoidOptionsManager>();
builder.Services.AddTransient<ICarrierVoidOptionsDataAccess, CarrierVoidOptionsDataAccess>();
builder.Services.AddTransient<IChargeManager, ChargeManager>();
builder.Services.AddTransient<IChargeDataAccess, ChargeDataAccess>();
builder.Services.AddTransient<IClassManager, ClassManager>();
builder.Services.AddTransient<IClassDataAccess, ClassDataAccess>();
builder.Services.AddTransient<IContractTypeManager, ContractTypeManager>();
builder.Services.AddTransient<IContractTypeDataAccess, ContractTypeDataAccess>();
builder.Services.AddTransient<ICostLayerIssuesManager, CostLayerIssuesManager>();
builder.Services.AddTransient<ICostLayerIssuesDataAccess, CostLayerIssuesDataAccess>();
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
