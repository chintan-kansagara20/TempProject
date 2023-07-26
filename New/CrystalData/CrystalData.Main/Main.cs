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

            Service.AddTransient<ICvAssemblyCustomerOrderManager, cvAssemblyCustomerOrderManager>();
            Service.AddTransient<ICvAssemblyCustomerOrderDataAccess, CvAssemblyCustomerOrderDataAccess>();

            Service.AddTransient<ICvAssemblyDocumentMembersManager, CvAssemblyDocumentMembersManager>();
            Service.AddTransient<ICvAssemblyDocumentMembersDataAccess, CvAssemblyDocumentMembersDataAccess>();

            Service.AddTransient<ICvAssemblyProductionRecordManager, CvAssemblyProductionRecordManager>();
            Service.AddTransient<ICvAssemblyProductionRecordDataAccess, CvAssemblyProductionRecordDataAccess>();

            Service.AddTransient<ICvInventoryTransfersRepeaterManager, CvInventoryTransfersRepeaterManager>();
            Service.AddTransient<ICvInventoryTransfersRepeaterDataAccess, CvInventoryTransfersRepeaterDataAccess>();

            Service.AddTransient<ICostLayerReceiptsManager, CostLayerReceiptsManager>();
            Service.AddTransient<ICostLayerReceiptsDataAccess, CostLayerReceiptsDataAccess>();

            Service.AddTransient<ICostLayersManager, CostLayersManager>();
            Service.AddTransient<ICostLayersDataAccess, CostLayersDataAccess>();

            Service.AddTransient<ICurrencyManager, CurrencyManager>();
            Service.AddTransient<ICurrencyDataAccess, CurrencyDataAccess>();

            Service.AddTransient<ICustomDataListManager, CustomDataListManager>();
            Service.AddTransient<ICustomDataListDataAccess, CustomDataListDataAccess>();

            Service.AddTransient<ICustomerManager, CustomerManager>();
            Service.AddTransient<ICustomerDataAccess, CustomerDataAccess>();

            Service.AddTransient<ICustomerBalanceManager, CustomerBalanceManager>();
            Service.AddTransient<ICustomerBalanceDataAccess, CustomerBalanceDataAccess>();

            Service.AddTransient<ICustomerChargeTotalManager, CustomerChargeTotalManager>();
            Service.AddTransient<ICustomerChargeTotalDataAccess, CustomerChargeTotalDataAccess>();

            Service.AddTransient<ICustomerContactManager, CustomerContactManager>();
            Service.AddTransient<ICustomerContactDataAccess, CustomerContactDataAccess>();

            Service.AddTransient<ITbINVRegisterManager, TbINVRegisterManager>();
            Service.AddTransient<ITbINVRegisterDataAccess, TbINVRegisterDataAccess>();
        }
    }
}