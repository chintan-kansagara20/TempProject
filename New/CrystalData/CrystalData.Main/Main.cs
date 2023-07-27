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

            Service.AddTransient<ITbINVTransactionManager, TbINVTransactionManager>();
            Service.AddTransient<ITbINVTransactionDataAccess, TbINVTransactionDataAccess>();

            Service.AddTransient<ITbINVLotSerialManager, TbINVLotSerialManager>();
            Service.AddTransient<ITbINVLotSerialDataAccess, TbINVLotSerialDataAccess>();

            Service.AddTransient<ITbINVTransactionDetailManager, TbINVTransactionDetailManager>();
            Service.AddTransient<ITbINVTransactionDetailDataAccess, TbINVTransactionDetailDataAccess>();

            Service.AddTransient<ITbProductManager, TbProductManager>();
            Service.AddTransient<ITbProductDataAccess, TbProductDataAccess>();

            Service.AddTransient<ITbOrderDetailManager, TbOrderDetailManager>();
            Service.AddTransient<ITbOrderDetailDataAccess, TbOrderDetailDataAccess>();

            Service.AddTransient<IStoredProcedureManager, StoredProcedureManager>();
            Service.AddTransient<IStoredProcedureDataAccess, StoredProcedureDataAccess>();

            Service.AddTransient<ITbWorkFlowStatusManager, TbWorkFlowStatusManager>();
            Service.AddTransient<ITbWorkFlowStatusDataAccess, TbWorkFlowStatusDataAccess>();

            Service.AddTransient<ITbWarehouseManager, TbWarehouseManager>();
            Service.AddTransient<ITbWarehouseDataAccess, TbWarehouseDataAccess>();

            Service.AddTransient<ICustomerContractManager, CustomerContractManager>();
            Service.AddTransient<ICustomerContractDataAccess, CustomerContractDataAccess>();

            Service.AddTransient<ICustomerCreditStatusManager, CustomerCreditStatusManager>();
            Service.AddTransient<ICustomerCreditStatusDataAccess, CustomerCreditStatusDataAccess>();

            Service.AddTransient<ICustomerEmailAddressListManager, CustomerEmailAddressListManager>();
            Service.AddTransient<ICustomerEmailAddressListDataAccess, CustomerEmailAddressListDataAccess>();

            Service.AddTransient<IProductComponentManager, ProductComponentManager>();
            Service.AddTransient<IProductComponentDataAccess, ProductComponentDataAccess>();

            Service.AddTransient<ICustomerExportManager, CustomerExportManager>();
            Service.AddTransient<ICustomerExportDataAccess, CustomerExportDataAccess>();

            Service.AddTransient<ICustomerFullNameManager, CustomerFullNameManager>();
            Service.AddTransient<ICustomerFullNameDataAccess, CustomerFullNameDataAccess>();

            Service.AddTransient<ICustomerInfoManager, CustomerInfoManager>();
            Service.AddTransient<ICustomerInfoDataAccess, CustomerInfoDataAccess>();

            Service.AddTransient<ICustomerInvoiceTotalManager, CustomerInvoiceTotalManager>();
            Service.AddTransient<ICustomerInvoiceTotalDataAccess, CustomerInvoiceTotalDataAccess>();

            Service.AddTransient<ICustomerMarketingListXrefManager, CustomerMarketingListXrefManager>();
            Service.AddTransient<ICustomerMarketingListXrefDataAccess, CustomerMarketingListXrefDataAccess>();

            Service.AddTransient<ICustomerPaymentManager, CustomerPaymentManager>();
            Service.AddTransient<ICustomerPaymentDataAccess, CustomerPaymentDataAccess>();

            Service.AddTransient<ICustomerPaymentAppliedTotalManager, CustomerPaymentAppliedTotalManager>();
            Service.AddTransient<ICustomerPaymentAppliedTotalDataAccess, CustomerPaymentAppliedTotalDataAccess>();

            Service.AddTransient<ICustomerPaymentChargeTotalManager, CustomerPaymentChargeTotalManager>();
            Service.AddTransient<ICustomerPaymentChargeTotalDataAccess, CustomerPaymentChargeTotalDataAccess>();

            Service.AddTransient<ICustomerPaymentInvoiceManager, CustomerPaymentInvoiceManager>();
            Service.AddTransient<ICustomerPaymentInvoiceDataAccess, CustomerPaymentInvoiceDataAccess>();

            Service.AddTransient<ICustomerPaymentInvoiceTotalManager, CustomerPaymentInvoiceTotalManager>();
            Service.AddTransient<ICustomerPaymentInvoiceTotalDataAccess, CustomerPaymentInvoiceTotalDataAccess>();

            Service.AddTransient<ICustomerPaymentTotalManager, CustomerPaymentTotalManager>();
            Service.AddTransient<ICustomerPaymentTotalDataAccess, CustomerPaymentTotalDataAccess>();

            Service.AddTransient<ICustomerPaymentViewManager, CustomerPaymentViewManager>();
            Service.AddTransient<ICustomerPaymentViewDataAccess, CustomerPaymentViewDataAccess>();

            Service.AddTransient<ICustomerProductManager, CustomerProductManager>();
            Service.AddTransient<ICustomerProductDataAccess, CustomerProductDataAccess>();

            Service.AddTransient<ICustomerShipManager, CustomerShipManager>();
            Service.AddTransient<ICustomerShipDataAccess, CustomerShipDataAccess>();

            Service.AddTransient<ICustomerShipToInfoManager, CustomerShipToInfoManager>();
            Service.AddTransient<ICustomerShipToInfoDataAccess, CustomerShipToInfoDataAccess>();

            Service.AddTransient<ICustomerShipViewManager, CustomerShipViewManager>();
            Service.AddTransient<ICustomerShipViewDataAccess, CustomerShipViewDataAccess>();

            Service.AddTransient<ICustomerStatementManager, CustomerStatementManager>();
            Service.AddTransient<ICustomerStatementDataAccess, CustomerStatementDataAccess>();

            Service.AddTransient<ICustomerTypeInfoManager, CustomerTypeInfoManager>();
            Service.AddTransient<ICustomerTypeInfoDataAccess, CustomerTypeInfoDataAccess>();

            Service.AddTransient<ICustomerViewManager, CustomerViewManager>();
            Service.AddTransient<ICustomerViewDataAccess, CustomerViewDataAccess>();

            Service.AddTransient<ICustomFieldManager, CustomFieldManager>();
            Service.AddTransient<ICustomFieldDataAccess, CustomFieldDataAccess>();

            Service.AddTransient<IcvAccessGroupManager, cvAccessGroupManager>();
            Service.AddTransient<IcvAccessGroupDataAccess, cvAccessGroupDataAccess>();

            Service.AddTransient<IcvAccessGroupUsersManager, cvAccessGroupUsersManager>();
            Service.AddTransient<IcvAccessGroupUsersDataAccess, cvAccessGroupUsersDataAccess>();

            Service.AddTransient<IcvAssemblyComponentAvailabilityManager, cvAssemblyComponentAvailabilityManager>();
            Service.AddTransient<IcvAssemblyComponentAvailabilityDataAccess, cvAssemblyComponentAvailabilityDataAccess>();

            Service.AddTransient<IcvAssemblyComponentLotAvailabilityManager, cvAssemblyComponentLotAvailabilityManager>();
            Service.AddTransient<IcvAssemblyComponentLotAvailabilityDataAccess, cvAssemblyComponentLotAvailabilityDataAccess>();

            Service.AddTransient<IcvAssemblyOrderDetManager, cvAssemblyOrderDetManager>();
            Service.AddTransient<IcvAssemblyOrderDetDataAccess, cvAssemblyOrderDetDataAccess>();

            Service.AddTransient<IcvAssemblyOrderDetailManager, cvAssemblyOrderDetailManager>();
            Service.AddTransient<IcvAssemblyOrderDetailDataAccess, cvAssemblyOrderDetailDataAccess>();

            Service.AddTransient<IcvAssemblyOrderDetailStatsManager, cvAssemblyOrderDetailStatsManager>();
            Service.AddTransient<IcvAssemblyOrderDetailStatsDataAccess, cvAssemblyOrderDetailStatsDataAccess>();

            Service.AddTransient<IcvAssemblyOrderDetailSummaryManager, cvAssemblyOrderDetailSummaryManager>();
            Service.AddTransient<IcvAssemblyOrderDetailSummaryDataAccess, cvAssemblyOrderDetailSummaryDataAccess>();

            Service.AddTransient<IcvAssemblyOrderHeaderManager, cvAssemblyOrderHeaderManager>();
            Service.AddTransient<IcvAssemblyOrderHeaderDataAccess, cvAssemblyOrderHeaderDataAccess>();

            Service.AddTransient<IcvAssemblyOrderMembersManager, cvAssemblyOrderMembersManager>();
            Service.AddTransient<IcvAssemblyOrderMembersDataAccess, cvAssemblyOrderMembersDataAccess>();

            Service.AddTransient<IcvAssemblyOrderPackagingManager, cvAssemblyOrderPackagingManager>();
            Service.AddTransient<IcvAssemblyOrderPackagingDataAccess, cvAssemblyOrderPackagingDataAccess>();

            Service.AddTransient<IcvAssemblyOrdersManager, cvAssemblyOrdersManager>();
            Service.AddTransient<IcvAssemblyOrdersDataAccess, cvAssemblyOrdersDataAccess>();

            Service.AddTransient<IcvAssemblyOrdersExtendedManager, cvAssemblyOrdersExtendedManager>();
            Service.AddTransient<IcvAssemblyOrdersExtendedDataAccess, cvAssemblyOrdersExtendedDataAccess>();

            Service.AddTransient<IcvAssemblyParentManager, cvAssemblyParentManager>();
            Service.AddTransient<IcvAssemblyParentDataAccess, cvAssemblyParentDataAccess>();

            Service.AddTransient<IcvAssemblyParentComponentManager, cvAssemblyParentComponentManager>();
            Service.AddTransient<IcvAssemblyParentComponentDataAccess, cvAssemblyParentComponentDataAccess>();

            Service.AddTransient<IcvAssemblyProductionPassFailManager, cvAssemblyProductionPassFailManager>();
            Service.AddTransient<IcvAssemblyProductionPassFailDataAccess, cvAssemblyProductionPassFailDataAccess>();

            Service.AddTransient<IcvAssemblyProductionReportManager, cvAssemblyProductionReportManager>();
            Service.AddTransient<IcvAssemblyProductionReportDataAccess, cvAssemblyProductionReportDataAccess>();

            Service.AddTransient<IcvAssemblyProductionReportInnerManager, cvAssemblyProductionReportInnerManager>();
            Service.AddTransient<IcvAssemblyProductionReportInnerDataAccess, cvAssemblyProductionReportInnerDataAccess>();

            Service.AddTransient<IcvAssemblyProductLabelManager, cvAssemblyProductLabelManager>();
            Service.AddTransient<IcvAssemblyProductLabelDataAccess, cvAssemblyProductLabelDataAccess>();

            Service.AddTransient<IcvAssemblySessionsManager, cvAssemblySessionsManager>();
            Service.AddTransient<IcvAssemblySessionsDataAccess, cvAssemblySessionsDataAccess>();

            Service.AddTransient<IcvAssemblyUnallocatedComponentsManager, cvAssemblyUnallocatedComponentsManager>();
            Service.AddTransient<IcvAssemblyUnallocatedComponentsDataAccess, cvAssemblyUnallocatedComponentsDataAccess>();

            Service.AddTransient<IcvBorsightTransfersForAssembliesManager, cvBorsightTransfersForAssembliesManager>();
            Service.AddTransient<IcvBorsightTransfersForAssembliesDataAccess, cvBorsightTransfersForAssembliesDataAccess>();

            Service.AddTransient<IcvCustomerContactCleanPhoneManager, cvCustomerContactCleanPhoneManager>();
            Service.AddTransient<IcvCustomerContactCleanPhoneDataAccess, cvCustomerContactCleanPhoneDataAccess>();

            Service.AddTransient<IcvIncomingInspectionBOMManager, cvIncomingInspectionBOMManager>();
            Service.AddTransient<IcvIncomingInspectionBOMDataAccess, cvIncomingInspectionBOMDataAccess>();

            Service.AddTransient<IcvIncomingQCTemplateManager, cvIncomingQCTemplateManager>();
            Service.AddTransient<IcvIncomingQCTemplateDataAccess, cvIncomingQCTemplateDataAccess>();

            Service.AddTransient<IcvIngredientClaimActivitiesManager, cvIngredientClaimActivitiesManager>();
            Service.AddTransient<IcvIngredientClaimActivitiesDataAccess, cvIngredientClaimActivitiesDataAccess>();

            Service.AddTransient<IcvInventorySerialLotSummaryTransactionsManager, cvInventorySerialLotSummaryTransactionsManager>();
            Service.AddTransient<IcvInventorySerialLotSummaryTransactionsDataAccess, cvInventorySerialLotSummaryTransactionsDataAccess>();

            Service.AddTransient<IcvInventoryTransfersManager, cvInventoryTransfersManager>();
            Service.AddTransient<IcvInventoryTransfersDataAccess, cvInventoryTransfersDataAccess>();

            Service.AddTransient<IcvInvoiceBalanceManager, cvInvoiceBalanceManager>();
            Service.AddTransient<IcvInvoiceBalanceDataAccess, cvInvoiceBalanceDataAccess>();

            Service.AddTransient<IcvINVTransactionDetailCrystalControlManager, cvINVTransactionDetailCrystalControlManager>();
            Service.AddTransient<IcvINVTransactionDetailCrystalControlDataAccess, cvINVTransactionDetailCrystalControlDataAccess>();

            Service.AddTransient<IcvINVTransferDetailsManager, cvINVTransferDetailsManager>();
            Service.AddTransient<IcvINVTransferDetailsDataAccess, cvINVTransferDetailsDataAccess>();

            Service.AddTransient<IcvIssueManager, cvIssueManager>();
            Service.AddTransient<IcvIssueDataAccess, cvIssueDataAccess>();
        }
    }
}