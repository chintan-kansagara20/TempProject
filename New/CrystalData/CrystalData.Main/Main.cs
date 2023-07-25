using AuthLayer.DataAccess.Interface;
using CrystalData.DataAccess.Impl;
using CrystalData.DataAccess.Interface;
using CrystalData.Manager.Impl;
using CrystalData.Manager.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace CrystalData.Main
{
    public class Main
    {
        public static void AddDependencies(IServiceCollection Service)
        {
            Service.AddTransient<ICvAssembliesManager, CvAssembliesManager>();
            Service.AddTransient<ICvAssembliesDataAccess, CvAssembliesDataAccess>();

            Service.AddTransient<IAccessManager, AccessManager>();
            Service.AddTransient<IAccessDataAccess, AccessDataAccess>();

            Service.AddTransient<IAccessPermissionManager, AccessPermissionManager>();
            Service.AddTransient<IAccessPermissionDataAccess, AccessPermissionDataAccess>();

            Service.AddTransient<ICvAssemblyDetailsManager, CvAssemblyDetailsManager>();
            Service.AddTransient<ICvAssemblyDetailsDataAccess, CvAssemblyDetailsDataAccess>();

            Service.AddTransient<IAccessPermissionMasterManager, AccessPermissionMasterManager>();
            Service.AddTransient<IAccessPermissionMasterDataAccess, AccessPermissionMasterDataAccess>();

            Service.AddTransient<IBranchManager, BranchManager>();
            Service.AddTransient<IBranchDataAccess, BranchDataAccess>();

            Service.AddTransient<IBusinessActivityHistoryManager, BusinessActivityHistoryManager>();
            Service.AddTransient<IBusinessActivityHistoryDataAccess, BusinessActivityHistoryDataAccess>();

            Service.AddTransient<IBusinessActivityManager, BusinessActivityManager>();
            Service.AddTransient<IBusinessActivityDataAccess, BusinessActivityDataAccess>();

            Service.AddTransient<IBusinessActivityRelatedItemsManager, BusinessActivityRelatedItemsManager>();
            Service.AddTransient<IBusinessActivityRelatedItemsDataAccess, BusinessActivityRelatedItemsDataAccess>();

            Service.AddTransient<IBusinessActivityTimeAndMaterialsManager, BusinessActivityTimeAndMaterialsManager>();
            Service.AddTransient<IBusinessActivityTimeAndMaterialsDataAccess, BusinessActivityTimeAndMaterialsDataAccess>();

            Service.AddTransient<ICarrierManager, CarrierManager>();
            Service.AddTransient<ICarrierDataAccess, CarrierDataAccess>();

            Service.AddTransient<ICarrierBillingOptionsManager, CarrierBillingOptionsManager>();
            Service.AddTransient<ICarrierBillingOptionsDataAccess, CarrierBillingOptionsDataAccess>();

            Service.AddTransient<ICarrierInsuranceOptionsManager, CarrierInsuranceOptionsManager>();
            Service.AddTransient<ICarrierInsuranceOptionsDataAccess, CarrierInsuranceOptionsDataAccess>();

            Service.AddTransient<ICarrierServiceManager, CarrierServiceManager>();
            Service.AddTransient<ICarrierServiceDataAccess, CarrierServiceDataAccess>();

            Service.AddTransient<ICarrierVoidOptionsManager, CarrierVoidOptionsManager>();
            Service.AddTransient<ICarrierVoidOptionsDataAccess, CarrierVoidOptionsDataAccess>();

            Service.AddTransient<IChargeManager, ChargeManager>();
            Service.AddTransient<IChargeDataAccess, ChargeDataAccess>();

            Service.AddTransient<IClassManager, ClassManager>();
            Service.AddTransient<IClassDataAccess, ClassDataAccess>();

            Service.AddTransient<IContractTypeManager, ContractTypeManager>();
            Service.AddTransient<IContractTypeDataAccess, ContractTypeDataAccess>();

            Service.AddTransient<ICostLayerIssuesManager, CostLayerIssuesManager>();
            Service.AddTransient<ICostLayerIssuesDataAccess, CostLayerIssuesDataAccess>();
        }
    }
}