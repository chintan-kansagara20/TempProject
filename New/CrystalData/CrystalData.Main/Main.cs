using AuthLayer.DataAccess.Interface;
using CrystalData.DataAccess.Impl;
using CrystalData.DataAccess.Interface;
using CrystalData.Manager.Impl;
using CrystalData.Manager.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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

            Service.AddTransient<ITbProductionWorkflowStatusManager, TbProductionWorkflowStatusManager>();
            Service.AddTransient<ITbProductionWorkflowStatusDataAccess, TbProductionWorkflowStatusDataAccess>();

            Service.AddTransient<ITbWorkFlowStatusManager, TbWorkFlowStatusManager>();
            Service.AddTransient<ITbWorkFlowStatusDataAccess, TbWorkFlowStatusDataAccess>();

            Service.AddTransient<ITbWarehouseManager, TbWarehouseManager>();
            Service.AddTransient<ITbWarehouseDataAccess, TbWarehouseDataAccess>();

            Service.AddTransient<ITbAccessManager, TbAccessManager>();
            Service.AddTransient<ITbAccessDataAccess, TbAccessDataAccess>();

            Service.AddTransient<ITbProductComponentManager, TbProductComponentManager>();
            Service.AddTransient<ITbProductComponentDataAccess, TbProductComponentDataAccess>();

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

            Service.AddTransient<IcvIssueAssemblyManager, cvIssueAssemblyManager>();
            Service.AddTransient<IcvIssueAssemblyDataAccess, cvIssueAssemblyDataAccess>();

            Service.AddTransient<IcvIssueChangedAssignmentManager, cvIssueChangedAssignmentManager>();
            Service.AddTransient<IcvIssueChangedAssignmentDataAccess, cvIssueChangedAssignmentDataAccess>();

            Service.AddTransient<IcvIssuesForMfgManager, cvIssuesForMfgManager>();
            Service.AddTransient<IcvIssuesForMfgDataAccess, cvIssuesForMfgDataAccess>();

            Service.AddTransient<IcvIssuesForWarehouseManager, cvIssuesForWarehouseManager>();
            Service.AddTransient<IcvIssuesForWarehouseDataAccess, cvIssuesForWarehouseDataAccess>();

            Service.AddTransient<IcvIssueViewersManager, cvIssueViewersManager>();
            Service.AddTransient<IcvIssueViewersDataAccess, cvIssueViewersDataAccess>();

            Service.AddTransient<IcvIssueViewersAssembliesManager, cvIssueViewersAssembliesManager>();
            Service.AddTransient<IcvIssueViewersAssembliesDataAccess, cvIssueViewersAssembliesDataAccess>();

            Service.AddTransient<IcvIssueViewersParentAssemblyManager, cvIssueViewersParentAssemblyManager>();
            Service.AddTransient<IcvIssueViewersParentAssemblyDataAccess, cvIssueViewersParentAssemblyDataAccess>();

            Service.AddTransient<IcvLastPOForProductManager, cvLastPOForProductManager>();
            Service.AddTransient<IcvLastPOForProductDataAccess, cvLastPOForProductDataAccess>();

            Service.AddTransient<IcvLinkConfigManager, cvLinkConfigManager>();
            Service.AddTransient<IcvLinkConfigDataAccess, cvLinkConfigDataAccess>();

            Service.AddTransient<IcvLinkConfigDocumentFoldersManager, cvLinkConfigDocumentFoldersManager>();
            Service.AddTransient<IcvLinkConfigDocumentFoldersDataAccess, cvLinkConfigDocumentFoldersDataAccess>();

            Service.AddTransient<IcvLinkConfigDocumentsManager, cvLinkConfigDocumentsManager>();
            Service.AddTransient<IcvLinkConfigDocumentsDataAccess, cvLinkConfigDocumentsDataAccess>();

            Service.AddTransient<IcvLinkConfigGuidesManager, cvLinkConfigGuidesManager>();
            Service.AddTransient<IcvLinkConfigGuidesDataAccess, cvLinkConfigGuidesDataAccess>();

            Service.AddTransient<IcvLinkConfigLabelsManager, cvLinkConfigLabelsManager>();
            Service.AddTransient<IcvLinkConfigLabelsDataAccess, cvLinkConfigLabelsDataAccess>();

            Service.AddTransient<IcvLinkConfigReportsManager, cvLinkConfigReportsManager>();
            Service.AddTransient<IcvLinkConfigReportsDataAccess, cvLinkConfigReportsDataAccess>();

            Service.AddTransient<IcvLinkConfigXrefManager, cvLinkConfigXrefManager>();
            Service.AddTransient<IcvLinkConfigXrefDataAccess, cvLinkConfigXrefDataAccess>();

            Service.AddTransient<IcvLinkProductSelectorManager, cvLinkProductSelectorManager>();
            Service.AddTransient<IcvLinkProductSelectorDataAccess, cvLinkProductSelectorDataAccess>();

            Service.AddTransient<IcvLocationSummaryManager, cvLocationSummaryManager>();
            Service.AddTransient<IcvLocationSummaryDataAccess, cvLocationSummaryDataAccess>();

            Service.AddTransient<IcvLotSerialInventoryManager, cvLotSerialInventoryManager>();
            Service.AddTransient<IcvLotSerialInventoryDataAccess, cvLotSerialInventoryDataAccess>();

            Service.AddTransient<IcvLotSerialLocationSummaryManager, cvLotSerialLocationSummaryManager>();
            Service.AddTransient<IcvLotSerialLocationSummaryDataAccess, cvLotSerialLocationSummaryDataAccess>();

            Service.AddTransient<IcvNegativeLotLocationManager, cvNegativeLotLocationManager>();
            Service.AddTransient<IcvNegativeLotLocationDataAccess, cvNegativeLotLocationDataAccess>();

            Service.AddTransient<IcvNegativeLotLocationNAHSManager, cvNegativeLotLocationNAHSManager>();
            Service.AddTransient<IcvNegativeLotLocationNAHSDataAccess, cvNegativeLotLocationNAHSDataAccess>();

            Service.AddTransient<IcvOptionGroupManager, cvOptionGroupManager>();
            Service.AddTransient<IcvOptionGroupDataAccess, cvOptionGroupDataAccess>();

            Service.AddTransient<IcvOptionsManager, cvOptionsManager>();
            Service.AddTransient<IcvOptionsDataAccess, cvOptionsDataAccess>();

            Service.AddTransient<IcvOptionTypeManager, cvOptionTypeManager>();
            Service.AddTransient<IcvOptionTypeDataAccess, cvOptionTypeDataAccess>();

            Service.AddTransient<IcvOrderDetTranslationManager, cvOrderDetTranslationManager>();
            Service.AddTransient<IcvOrderDetTranslationDataAccess, cvOrderDetTranslationDataAccess>();

            Service.AddTransient<IcvPODetWhereUsedManager, cvPODetWhereUsedManager>();
            Service.AddTransient<IcvPODetWhereUsedDataAccess, cvPODetWhereUsedDataAccess>();

            Service.AddTransient<IcvPODetWithReceiptsAssyNeededManager, cvPODetWithReceiptsAssyNeededManager>();
            Service.AddTransient<IcvPODetWithReceiptsAssyNeededDataAccess, cvPODetWithReceiptsAssyNeededDataAccess>();

            Service.AddTransient<IcvPOReceiptManager, cvPOReceiptManager>();
            Service.AddTransient<IcvPOReceiptDataAccess, cvPOReceiptDataAccess>();

            Service.AddTransient<IcvPOReceiptsAssyNeededManager, cvPOReceiptsAssyNeededManager>();
            Service.AddTransient<IcvPOReceiptsAssyNeededDataAccess, cvPOReceiptsAssyNeededDataAccess>();

            Service.AddTransient<IcvPriorPOForProductManager, cvPriorPOForProductManager>();
            Service.AddTransient<IcvPriorPOForProductDataAccess, cvPriorPOForProductDataAccess>();

            Service.AddTransient<IcvproductManager, cvproductManager>();
            Service.AddTransient<IcvproductDataAccess, cvproductDataAccess>();

            Service.AddTransient<IcvProductAvailabilityManager, cvProductAvailabilityManager>();
            Service.AddTransient<IcvProductAvailabilityDataAccess, cvProductAvailabilityDataAccess>();

            Service.AddTransient<IcvProductBatchManager, cvProductBatchManager>();
            Service.AddTransient<IcvProductBatchDataAccess, cvProductBatchDataAccess>();

            Service.AddTransient<IcvProductComponentManager, cvProductComponentManager>();
            Service.AddTransient<IcvProductComponentDataAccess, cvProductComponentDataAccess>();

            Service.AddTransient<IcvProductEffectivePriceManager, cvProductEffectivePriceManager>();
            Service.AddTransient<IcvProductEffectivePriceDataAccess, cvProductEffectivePriceDataAccess>();

            Service.AddTransient<IcvProductExportNSSManager, cvProductExportNSSManager> ();
            Service.AddTransient<IcvProductExportNSSDataAccess, cvProductExportNSSDataAccess>();

            Service.AddTransient<IcvProductFinishedNSSManager, cvProductFinishedNSSManager>();
            Service.AddTransient<IcvProductFinishedNSSDataAccess, cvProductFinishedNSSDataAccess>();

            Service.AddTransient<IcvProductIngredientNSSManager, cvProductIngredientNSSManager>();
            Service.AddTransient<IcvProductIngredientNSSDataAccess, cvProductIngredientNSSDataAccess>();

            Service.AddTransient<IcvProductLocationSummaryManager, cvProductLocationSummaryManager>();
            Service.AddTransient<IcvProductLocationSummaryDataAccess, cvProductLocationSummaryDataAccess>();

            Service.AddTransient<IcvProductMetricsManager, cvProductMetricsManager>();
            Service.AddTransient<IcvProductMetricsDataAccess, cvProductMetricsDataAccess>();

            Service.AddTransient<IcvProductPackageUnitConversionManager, cvProductPackageUnitConversionManager>();
            Service.AddTransient<IcvProductPackageUnitConversionDataAccess, cvProductPackageUnitConversionDataAccess>();

            Service.AddTransient<IcvProductPackagingManager, cvProductPackagingManager>();
            Service.AddTransient<IcvProductPackagingDataAccess, cvProductPackagingDataAccess>();

            Service.AddTransient<IcvProductProcManager, cvProductProcManager>();
            Service.AddTransient<IcvProductProcDataAccess, cvProductProcDataAccess>();

            Service.AddTransient<IcvProductPurchaseUnitConversionManager, cvProductPurchaseUnitConversionManager>();
            Service.AddTransient<IcvProductPurchaseUnitConversionDataAccess, cvProductPurchaseUnitConversionDataAccess>();

            Service.AddTransient<IcvProductQCManager, cvProductQCManager>();
            Service.AddTransient<IcvProductQCDataAccess, cvProductQCDataAccess>();

            Service.AddTransient<IcvProductSpecAssembliesManager, cvProductSpecAssembliesManager>();
            Service.AddTransient<IcvProductSpecAssembliesDataAccess, cvProductSpecAssembliesDataAccess>();

            Service.AddTransient<IcvProductVendorPriceManager, cvProductVendorPriceManager>();
            Service.AddTransient<IcvProductVendorPriceDataAccess, cvProductVendorPriceDataAccess>();

            Service.AddTransient<IcvReceiptTransactionDetailManager, cvReceiptTransactionDetailManager>();
            Service.AddTransient<IcvReceiptTransactionDetailDataAccess, cvReceiptTransactionDetailDataAccess>();

            Service.AddTransient<IcvReceivingLogManager, cvReceivingLogManager>();
            Service.AddTransient<IcvReceivingLogDataAccess, cvReceivingLogDataAccess>();

            Service.AddTransient<IcvRoleAccessManager, cvRoleAccessManager>();
            Service.AddTransient<IcvRoleAccessDataAccess, cvRoleAccessDataAccess>();

            Service.AddTransient<IcvSuppManufactureManager, cvSuppManufactureManager>();
            Service.AddTransient<IcvSuppManufactureDataAccess, cvSuppManufactureDataAccess>();

            Service.AddTransient<IcvSuppManufactureYieldManager, cvSuppManufactureYieldManager>();
            Service.AddTransient<IcvSuppManufactureYieldDataAccess, cvSuppManufactureYieldDataAccess>();

            Service.AddTransient<IcvTrxDetailControlSeriesManager, cvTrxDetailControlSeriesManager>();
            Service.AddTransient<IcvTrxDetailControlSeriesDataAccess, cvTrxDetailControlSeriesDataAccess>();

            Service.AddTransient<IcvTrxDetailControlValuesManager, cvTrxDetailControlValuesManager>();
            Service.AddTransient<IcvTrxDetailControlValuesDataAccess, cvTrxDetailControlValuesDataAccess>();

            Service.AddTransient<IcvVendorRequestForQuotesManager, cvVendorRequestForQuotesManager>();
            Service.AddTransient<IcvVendorRequestForQuotesDataAccess, cvVendorRequestForQuotesDataAccess>();

            Service.AddTransient<IDocumentManager, DocumentManager>();
            Service.AddTransient<IDocumentDataAccess, DocumentDataAccess>();

            Service.AddTransient<IEDIAdditionalInformationManager, EDIAdditionalInformationManager>();
            Service.AddTransient<IEDIAdditionalInformationDataAccess, EDIAdditionalInformationDataAccess>();

            Service.AddTransient<IEDIOrderDetailExManager, EDIOrderDetailExManager>();
            Service.AddTransient<IEDIOrderDetailExDataAccess, EDIOrderDetailExDataAccess>();

            Service.AddTransient<IEDIOrdersExManager, EDIOrdersExManager>();
            Service.AddTransient<IEDIOrdersExDataAccess, EDIOrdersExDataAccess>();

            Service.AddTransient<IEmployeeManager, EmployeeManager>();
            Service.AddTransient<IEmployeeDataAccess, EmployeeDataAccess>();

            Service.AddTransient<IFIFOCostLayersManager, FIFOCostLayersManager>();
            Service.AddTransient<IFIFOCostLayersDataAccess, FIFOCostLayersDataAccess>();

            Service.AddTransient<IFlattenedKitComponentsManager, FlattenedKitComponentsManager>();
            Service.AddTransient<IFlattenedKitComponentsDataAccess, FlattenedKitComponentsDataAccess>();

            Service.AddTransient<IGLAccountManager, GLAccountManager>();
            Service.AddTransient <IGLAccountDataAccess, GLAccountDataAccess>();

            Service.AddTransient<IGLAccountSegmentManager, GLAccountSegmentManager>();
            Service.AddTransient<IGLAccountSegmentDataAccess, GLAccountSegmentDataAccess>();

            Service.AddTransient<IImpExpDocumentColumnManager, ImpExpDocumentColumnManager>();
            Service.AddTransient<IImpExpDocumentColumnDataAccess, ImpExpDocumentColumnDataAccess>();

            Service.AddTransient<IImpExpDocumentTableManager, ImpExpDocumentTableManager>();
            Service.AddTransient<IImpExpDocumentTableDataAccess, ImpExpDocumentTableDataAccess>();

            Service.AddTransient<IImpExpDocumentTypeManager, ImpExpDocumentTypeManager>();
            Service.AddTransient<IImpExpDocumentTypeDataAccess, ImpExpDocumentTypeDataAccess>();

            Service.AddTransient<IImportManager, ImportManager>();
            Service.AddTransient<IImportDataAccess, ImportDataAccess>();

            Service.AddTransient<IImportConversionManager, ImportConversionManager>();
            Service.AddTransient<IImportConversionDataAccess, ImportConversionDataAccess>();

            Service.AddTransient<IImportDefaultConversionManager, ImportDefaultConversionManager>();
            Service.AddTransient<IImportDefaultConversionDataAccess, ImportDefaultConversionDataAccess>();

            Service.AddTransient<IImportDefaultMapManager, ImportDefaultMapManager>();
            Service.AddTransient<IImportDefaultMapDataAccess, ImportDefaultMapDataAccess>();

            Service.AddTransient<IImportDefaultNamespaceManager, ImportDefaultNamespaceManager>();
            Service.AddTransient<IImportDefaultNamespaceDataAccess, ImportDefaultNamespaceDataAccess>();

            Service.AddTransient<IImportDefaultSourceFieldsManager, ImportDefaultSourceFieldsManager>();
            Service.AddTransient<IImportDefaultSourceFieldsDataAccess, ImportDefaultSourceFieldsDataAccess>();

            Service.AddTransient<IImportDefaultTableManager, ImportDefaultTableManager>();
            Service.AddTransient<IImportDefaultTableDataAccess, ImportDefaultTableDataAccess>();

            Service.AddTransient<IImportErrorsManager, ImportErrorsManager>();
            Service.AddTransient<IImportErrorsDataAccess, ImportErrorsDataAccess>();

            Service.AddTransient<IImportMapManager, ImportMapManager>();
            Service.AddTransient<IImportMapDataAccess, ImportMapDataAccess>();

            Service.AddTransient<IImportNamespaceManager, ImportNamespaceManager>();
            Service.AddTransient<IImportNamespaceDataAccess, ImportNamespaceDataAccess>();

            Service.AddTransient<IImportSkippedManager, ImportSkippedManager>();
            Service.AddTransient<IImportSkippedDataAccess, ImportSkippedDataAccess>();

            Service.AddTransient<IImportSourceFieldsManager, ImportSourceFieldsManager>();
            Service.AddTransient<IImportSourceFieldsDataAccess, ImportSourceFieldsDataAccess>();

            Service.AddTransient<IImportSourceFileManager, ImportSourceFileManager>();
            Service.AddTransient<IImportSourceFileDataAccess, ImportSourceFileDataAccess>();

            Service.AddTransient<IImportSourceRelateFieldsManager, ImportSourceRelateFieldsManager>();
            Service.AddTransient<IImportSourceRelateFieldsDataAccess, ImportSourceRelateFieldsDataAccess>();

            Service.AddTransient<IImportTableManager, ImportTableManager>();
            Service.AddTransient<IImportTableDataAccess, ImportTableDataAccess>();

            Service.AddTransient<IImportTemplateOptionsManager, ImportTemplateOptionsManager>();
            Service.AddTransient<IImportTemplateOptionsDataAccess, ImportTemplateOptionsDataAccess>();

            Service.AddTransient<IImportTransformationManager, ImportTransformationManager>();
            Service.AddTransient<IImportTransformationDataAccess, ImportTransformationDataAccess>();

            Service.AddTransient<IInventoryJournalManager, InventoryJournalManager>();
            Service.AddTransient<IInventoryJournalDataAccess, InventoryJournalDataAccess>();

            Service.AddTransient<IInventoryJournalDetailManager, InventoryJournalDetailManager>();
            Service.AddTransient<IInventoryJournalDetailDataAccess, InventoryJournalDetailDataAccess>();

            Service.AddTransient<IInventoryJournalDetail_NoAccountsManager, InventoryJournalDetail_NoAccountsManager>();
            Service.AddTransient<IInventoryJournalDetail_NoAccountsDataAccess, InventoryJournalDetail_NoAccountsDataAccess>();

            Service.AddTransient<IInventoryJournalSummaryManager, InventoryJournalSummaryManager>();
            Service.AddTransient<IInventoryJournalSummaryDataAccess, InventoryJournalSummaryDataAccess>();

            Service.AddTransient<IINVLotSerialTraceManager, INVLotSerialTraceManager>();
            Service.AddTransient<IINVLotSerialTraceDataAccess, INVLotSerialTraceDataAccess>();

            Service.AddTransient<IINVLotSerialTraceDetailManager, INVLotSerialTraceDetailManager>();
            Service.AddTransient<IINVLotSerialTraceDetailDataAccess, INVLotSerialTraceDetailDataAccess>();

            Service.AddTransient<IInvoiceManager, InvoiceManager>();
            Service.AddTransient<IInvoiceDataAccess, InvoiceDataAccess>();

            Service.AddTransient<IInvoiceAmtSummaryManager, InvoiceAmtSummaryManager>();
            Service.AddTransient<IInvoiceAmtSummaryDataAccess, InvoiceAmtSummaryDataAccess>();

            Service.AddTransient<IInvoiceDetailManager, InvoiceDetailManager>();
            Service.AddTransient<IInvoiceDetailDataAccess, InvoiceDetailDataAccess>();

            Service.AddTransient<IInvoicesAndChargesManager, InvoicesAndChargesManager>();
            Service.AddTransient<IInvoicesAndChargesDataAccess, InvoicesAndChargesDataAccess>();

            Service.AddTransient<IINVRegisterManager, INVRegisterManager>();
            Service.AddTransient<IINVRegisterDataAccess, INVRegisterDataAccess>();

            Service.AddTransient<IINVTransactionManager, INVTransactionManager>();
            Service.AddTransient<IINVTransactionDataAccess, INVTransactionDataAccess>();

            Service.AddTransient<IINVTransactionDetailManager, INVTransactionDetailManager>();
            Service.AddTransient<IINVTransactionDetailDataAccess, INVTransactionDetailDataAccess>();

            Service.AddTransient<IINVTransactionDetailOnHandSummaryManager, INVTransactionDetailOnHandSummaryManager>();
            Service.AddTransient<IINVTransactionDetailOnHandSummaryDataAccess, INVTransactionDetailOnHandSummaryDataAccess>();

            Service.AddTransient<IINVTransactionDetailSummaryManager, INVTransactionDetailSummaryManager>();
            Service.AddTransient<IINVTransactionDetailSummaryDataAccess, INVTransactionDetailSummaryDataAccess>();

            Service.AddTransient<IIssueManager, IssueManager>();
            Service.AddTransient<IIssueDataAccess, IssueDataAccess>();

            Service.AddTransient<IIssueCodeManager, IssueCodeManager>();
            Service.AddTransient<IIssueCodeDataAccess, IssueCodeDataAccess>();

            Service.AddTransient<IIssueLogManager, IssueLogManager>();
            Service.AddTransient<IIssueLogDataAccess, IssueLogDataAccess>();

            Service.AddTransient<IIssuePriorityCodeManager, IssuePriorityCodeManager>();
            Service.AddTransient<IIssuePriorityCodeDataAccess, IssuePriorityCodeDataAccess>();

            Service.AddTransient<IIssueResolutionCodeManager, IssueResolutionCodeManager>();
            Service.AddTransient<IIssueResolutionCodeDataAccess, IssueResolutionCodeDataAccess>();

            Service.AddTransient<IIssueSchedulingClassManager, IssueSchedulingClassManager>();
            Service.AddTransient<IIssueSchedulingClassDataAccess, IssueSchedulingClassDataAccess>();

            Service.AddTransient<IIssueStatusCodeManager, IssueStatusCodeManager>();
            Service.AddTransient<IIssueStatusCodeDataAccess, IssueStatusCodeDataAccess>();

            Service.AddTransient<IIssueTypeManager, IssueTypeManager>();
            Service.AddTransient<IIssueTypeDataAccess, IssueTypeDataAccess>();

            Service.AddTransient<IIssueTypeCodeXrefManager, IssueTypeCodeXrefManager>();
            Service.AddTransient<IIssueTypeCodeXrefDataAccess, IssueTypeCodeXrefDataAccess>();

            Service.AddTransient<IIssueTypePriorityXrefManager, IssueTypePriorityXrefManager>();
            Service.AddTransient<IIssueTypePriorityXrefDataAccess, IssueTypePriorityXrefDataAccess>();

            Service.AddTransient<IIssueTypeResolutionXrefManager, IssueTypeResolutionXrefManager>();
            Service.AddTransient<IIssueTypeResolutionXrefDataAccess, IssueTypeResolutionXrefDataAccess>();

            Service.AddTransient<IIssueTypeSchedulingClassXrefManager, IssueTypeSchedulingClassXrefManager>();
            Service.AddTransient<IIssueTypeSchedulingClassXrefDataAccess, IssueTypeSchedulingClassXrefDataAccess>();

            Service.AddTransient<IIssueTypeStatusXrefManager, IssueTypeStatusXrefManager>();
            Service.AddTransient<IIssueTypeStatusXrefDataAccess, IssueTypeStatusXrefDataAccess>();

            Service.AddTransient<IIssueXrefManager, IssueXrefManager>();
            Service.AddTransient<IIssueXrefDataAccess, IssueXrefDataAccess>();

            Service.AddTransient<IJournalManager, JournalManager>();
            Service.AddTransient<IJournalDataAccess, JournalDataAccess>();

            Service.AddTransient<IJournalLineManager, JournalLineManager>();
            Service.AddTransient<IJournalLineDataAccess, JournalLineDataAccess>();

            Service.AddTransient<ILIFOCostLayersManager, LIFOCostLayersManager>();
            Service.AddTransient<ILIFOCostLayersDataAccess, LIFOCostLayersDataAccess>();

            Service.AddTransient<ILocationSummaryManager, LocationSummaryManager>();
            Service.AddTransient<ILocationSummaryDataAccess, LocationSummaryDataAccess>();

            Service.AddTransient<ILocationSummaryNoAvailabilityManager, LocationSummaryNoAvailabilityManager>();
            Service.AddTransient<ILocationSummaryNoAvailabilityDataAccess, LocationSummaryNoAvailabilityDataAccess>();

            Service.AddTransient<ILostBusinessManager, LostBusinessManager>();
            Service.AddTransient<ILostBusinessDataAccess, LostBusinessDataAccess>();

            Service.AddTransient<ILotSerialDefaultLocationManager, LotSerialDefaultLocationManager>();
            Service.AddTransient<ILotSerialDefaultLocationDataAccess, LotSerialDefaultLocationDataAccess>();

            Service.AddTransient<ILotSerialInventoryManager, LotSerialInventoryManager>();
            Service.AddTransient<ILotSerialInventoryDataAccess, LotSerialInventoryDataAccess>();

            Service.AddTransient<ILotSerialInventoryIssuesManager, LotSerialInventoryIssuesManager>();
            Service.AddTransient<ILotSerialInventoryIssuesDataAccess, LotSerialInventoryIssuesDataAccess>();

            Service.AddTransient<ILotSerialInventoryReceiptsManager, LotSerialInventoryReceiptsManager>();
            Service.AddTransient<ILotSerialInventoryReceiptsDataAccess, LotSerialInventoryReceiptsDataAccess>();

            Service.AddTransient<ILotSerialInventoryWithoutLastReceiptManager, LotSerialInventoryWithoutLastReceiptManager>();
            Service.AddTransient<ILotSerialInventoryWithoutLastReceiptDataAccess, LotSerialInventoryWithoutLastReceiptDataAccess>();

            Service.AddTransient<ILotSerialLocationManager, LotSerialLocationManager>();
            Service.AddTransient<ILotSerialLocationDataAccess, LotSerialLocationDataAccess>();

            Service.AddTransient<ILotSerialLocationSummaryManager, LotSerialLocationSummaryManager>();
            Service.AddTransient<ILotSerialLocationSummaryDataAccess, LotSerialLocationSummaryDataAccess>();

            Service.AddTransient<ILotSerialLocationSummaryNoAvailabilityManager, LotSerialLocationSummaryNoAvailabilityManager>();
            Service.AddTransient<ILotSerialLocationSummaryNoAvailabilityDataAccess, LotSerialLocationSummaryNoAvailabilityDataAccess>();

            Service.AddTransient<ILotSerialSummaryManager, LotSerialSummaryManager>();
            Service.AddTransient<ILotSerialSummaryDataAccess, LotSerialSummaryDataAccess>();

            Service.AddTransient<IMarketingCodeManager, MarketingCodeManager>();
            Service.AddTransient<IMarketingCodeDataAccess, MarketingCodeDataAccess>();

            Service.AddTransient<IMarketingListCodeManager, MarketingListCodeManager>();
            Service.AddTransient<IMarketingListCodeDataAccess, MarketingListCodeDataAccess>();

            Service.AddTransient<IMarketingListXrefManager, MarketingListXrefManager>();
            Service.AddTransient<IMarketingListXrefDataAccess, MarketingListXrefDataAccess>();

            Service.AddTransient<IMessagesManager, MessagesManager>();
            Service.AddTransient<IMessagesDataAccess, MessagesDataAccess>();

            Service.AddTransient<INoteCategoryManager, NoteCategoryManager>();
            Service.AddTransient<INoteCategoryDataAccess, NoteCategoryDataAccess>();

            Service.AddTransient<INotesManager, NotesManager>();
            Service.AddTransient<INotesDataAccess, NotesDataAccess>();

            Service.AddTransient<INoteStatusManager, NoteStatusManager>();
            Service.AddTransient<INoteStatusDataAccess, NoteStatusDataAccess>();

            Service.AddTransient<INotesViewManager, NotesViewManager>();
            Service.AddTransient<INotesViewDataAccess, NotesViewDataAccess>();

            Service.AddTransient<INumbersManager, NumbersManager>();
            Service.AddTransient<INumbersDataAccess, NumbersDataAccess>();

            Service.AddTransient<IOrderDetailManager, OrderDetailManager>();
            Service.AddTransient<IOrderDetailDataAccess, OrderDetailDataAccess>();

            Service.AddTransient<IOrderDetailLotManager, OrderDetailLotManager>();
            Service.AddTransient<IOrderDetailLotDataAccess, OrderDetailLotDataAccess>();

            Service.AddTransient<IOrderDetailSummaryManager, OrderDetailSummaryManager>();
            Service.AddTransient<IOrderDetailSummaryDataAccess, OrderDetailSummaryDataAccess>();

            Service.AddTransient<IOrderDetailTopLevelComponentQuantityManager, OrderDetailTopLevelComponentQuantityManager>();
            Service.AddTransient<IOrderDetailTopLevelComponentQuantityDataAccess, OrderDetailTopLevelComponentQuantityDataAccess>();

            Service.AddTransient<IOrderManagementSummaryManager, OrderManagementSummaryManager>();
            Service.AddTransient<IOrderManagementSummaryDataAccess, OrderManagementSummaryDataAccess>();

            Service.AddTransient<IOrderPackagesManager, OrderPackagesManager>();
            Service.AddTransient<IOrderPackagesDataAccess, OrderPackagesDataAccess>();

            Service.AddTransient<IOrderPendingAssembliesManager, OrderPendingAssembliesManager>();
            Service.AddTransient<IOrderPendingAssembliesDataAccess, OrderPendingAssembliesDataAccess>();

            Service.AddTransient<IOrdersManager, OrdersManager>();
            Service.AddTransient<IOrdersDataAccess, OrdersDataAccess>();

            Service.AddTransient<IOrdersAvailableToShipManager, OrdersAvailableToShipManager>();
            Service.AddTransient<IOrdersAvailableToShipDataAccess, OrdersAvailableToShipDataAccess>();

            Service.AddTransient<IOrderWorkFlowStatusManager, OrderWorkFlowStatusManager>();
            Service.AddTransient<IOrderWorkFlowStatusDataAccess, OrderWorkFlowStatusDataAccess>();

            Service.AddTransient<IPaymentMethodManager, PaymentMethodManager>();
            Service.AddTransient<IPaymentMethodDataAccess, PaymentMethodDataAccess>();

            Service.AddTransient<IPicklistManager, PicklistManager>();
            Service.AddTransient<IPicklistDataAccess, PicklistDataAccess>();

            Service.AddTransient<IPicklistDetailManager, PicklistDetailManager>();
            Service.AddTransient<IPicklistDetailDataAccess, PicklistDetailDataAccess>();

            Service.AddTransient<IPicklistDetailLotManager, PicklistDetailLotManager>();
            Service.AddTransient<IPicklistDetailLotDataAccess, PicklistDetailLotDataAccess>();

            Service.AddTransient<IPicklistOrderManager, PicklistOrderManager>();
            Service.AddTransient<IPicklistOrderDataAccess, PicklistOrderDataAccess>();

            Service.AddTransient<IPOManager, POManager>();
            Service.AddTransient<IPODataAccess, PODataAccess>();

            Service.AddTransient<IPODetailManager, PODetailManager>();
            Service.AddTransient<IPODetailDataAccess, PODetailDataAccess>();

            Service.AddTransient<IPODetailInvoicedManager, PODetailInvoicedManager>();
            Service.AddTransient<IPODetailInvoicedDataAccess, PODetailInvoicedDataAccess>();

            Service.AddTransient<IPODetailInvoiceSummaryManager, PODetailInvoiceSummaryManager>();
            Service.AddTransient<IPODetailInvoiceSummaryDataAccess, PODetailInvoiceSummaryDataAccess>();

            Service.AddTransient<IPODetailReceiptSummaryManager, PODetailReceiptSummaryManager>();
            Service.AddTransient<IPODetailReceiptSummaryDataAccess, PODetailReceiptSummaryDataAccess>();

            Service.AddTransient<IPODetailReceivedManager, PODetailReceivedManager>();
            Service.AddTransient<IPODetailReceivedDataAccess, PODetailReceivedDataAccess>();

            Service.AddTransient<IPODetailSimpleManager, PODetailSimpleManager>();
            Service.AddTransient<IPODetailSimpleDataAccess, PODetailSimpleDataAccess>();

            Service.AddTransient<IPOInvoiceManager, POInvoiceManager>();
            Service.AddTransient<IPOInvoiceDataAccess, POInvoiceDataAccess>();

            Service.AddTransient<IPOInvoiceDetailManager, POInvoiceDetailManager>();
            Service.AddTransient<IPOInvoiceDetailDataAccess, POInvoiceDetailDataAccess>();

            Service.AddTransient<IPOManagementSummaryManager, POManagementSummaryManager>();
            Service.AddTransient<IPOManagementSummaryDataAccess, POManagementSummaryDataAccess>();
        }
    }
}