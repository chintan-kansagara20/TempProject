﻿using AuthLayer.ActionFilters;
using AuthLayer.Utility;
using CrystalData.DataAccess.Interface;
using CrystalData.Manager.Impl;
using CrystalData.Manager.Interface;
using CrystalData.Models;
using EasyCrudLibrary.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CrystalData.API.Controllers
{
    [ApiController]
    [FullAuthorization]
    public class ExecController : ControllerBase
    {
        ICvAssembliesManager _CvAssembliesManager { get; set; }
        IAccessManager _AccessManager { get; set; }
        IAccessPermissionManager _AccessPermissionManager { get; set; }
        ICvAssemblyDetailsManager _CvAssemblyDetailsManager { get; set; }
        IAccessPermissionMasterManager __AccessPermissionMasterManager { get; set; }
        IBranchManager _BranchManager { get; set; }
        IBusinessActivityHistoryManager _BusinessActivityHistoryManager { get; set; }
        IBusinessActivityManager _BusinessActivityManager { get; set; }
        IBusinessActivityRelatedItemsManager _BusinessActivityRelatedItemsManager { get; set; }
        IBusinessActivityTimeAndMaterialsManager _BusinessActivityTimeAndMaterialsManager { get; set; }
        ICarrierManager _CarrierManager { get; set; }
        ICarrierBillingOptionsManager _CarrierBillingOptionsManager { get; set; }
        ICarrierInsuranceOptionsManager _CarrierInsuranceOptionsManager { get; set; }
        ICarrierServiceManager _CarrierServiceManager { get; set; }
        ICarrierVoidOptionsManager _CarrierVoidOptionsManager { get; set; }
        IChargeManager _ChargeManager { get; set; }
        IClassManager _ClassManager { get; set; }
        IContractTypeManager _ContractTypeManager { get; set; }
        ICostLayerIssuesManager _CostLayerIssues { get; set; }
        ICvAssemblyCustomerOrderManager _CvAssemblyCustomerOrderManager { get; set; }
        ICvAssemblyDocumentMembersManager _CvAssemblyDocumentMembersManager { get; set; }
        ICvAssemblyProductionRecordManager _CvAssemblyProductionRecordManager { get; set; }
        ICvInventoryTransfersRepeaterManager _CvInventoryTransfersRepeaterManager { get; set; }
        ICostLayerReceiptsManager _CostLayerReceiptsManager { get; set; }
        ICostLayersManager _CostLayersManager { get; set; }
        ICurrencyManager _CurrencyManager { get; set; }
        ICustomDataListManager _CustomDataListManager { get; set; }
        ICustomerManager _CustomerManager { get; set; }
        ICustomerBalanceManager _CustomerBalanceManager { get; set; }
        ICustomerChargeTotalManager _CustomerChargeTotalDataAccess { get; set; }
        ICustomerContactManager _CustomerContactDataAccess { get; set; }
        ICustomerContractManager _CustomerContractManager { get; set; }
        ICustomerCreditStatusManager _CustomerCreditStatusManager { get; set; }
        ICustomerEmailAddressListManager _CustomerEmailAddressListManager { get; set; }
        IProductComponentManager _ProductComponentManager { get; set; }
        ICustomerExportManager _CustomerExportManager { get; set; }
        ICustomerFullNameManager _CustomerFullNameManager { get; set; }
        ICustomerInfoManager _CustomerInfoManager { get; set; }
        ICustomerInvoiceTotalManager _CustomerInvoiceTotalManager { get; set; }
        ICustomerMarketingListXrefManager _CustomerMarketingListXrefManager { get; set; }
        ICustomerPaymentManager _CustomerPaymentManager { get; set; }
        ICustomerPaymentAppliedTotalManager _CustomerPaymentAppliedTotalManager { get; set; }
        ICustomerPaymentChargeTotalManager _CustomerPaymentChargeTotalManager { get; set; }
        ICustomerPaymentInvoiceManager _CustomerPaymentInvoiceManager { get; set; }
        ICustomerPaymentInvoiceTotalManager _CustomerPaymentInvoiceTotalManager { get; set; }
        ICustomerPaymentTotalManager _CustomerPaymentTotalManager { get; set; }
        ICustomerPaymentViewManager _CustomerPaymentViewManager { get; set; }
        ICustomerProductManager _CustomerProductManager { get; set; }
        ICustomerShipManager _CustomerShipManager { get; set; }
        ICustomerShipToInfoManager _CustomerShipToInfoManager { get; set; }
        ICustomerShipViewManager _CustomerShipViewManager { get; set; }
        ICustomerStatementManager _CustomerStatementManager { get; set; }
        ICustomerTypeInfoManager _CustomerTypeInfoManager { get; set; }
        ICustomerViewManager _CustomerViewManager { get; set; }
        ICustomFieldManager _CustomFeildManager { get; set; }
        IcvAccessGroupManager _cvAccessGroupManager { get; set; }
        IcvAccessGroupUsersManager _cvAccessGroupUsersManager { get; set; }
        IcvAssemblyComponentAvailabilityManager _cvAssemblyComponentAvailabilityManager { get; set; }
        IcvAssemblyComponentLotAvailabilityManager _cvAssemblyComponentLotAvailabilityManager { get; set; }
        IcvAssemblyOrderDetManager _cvAssemblyOrderDetManager { get; set; }
        IcvAssemblyOrderDetailManager _cvAssemblyOrderDetailManager { get; set; }
        IcvAssemblyOrderDetailStatsManager _cvAssemblyOrderDetailStatsManager { get; set; }
        IcvAssemblyOrderDetailSummaryManager _cvAssemblyOrderDetailSummaryManager { get; set; }
        IcvAssemblyOrderHeaderManager _cvAssemblyOrderHeaderManager { get; set; }
        IcvAssemblyOrderMembersManager _cvAssemblyOrderMembersManager { get; set; }
        IcvAssemblyOrderPackagingManager _cvAssemblyOrderPackagingManager { get; set; }
        IcvAssemblyOrdersManager _cvAssemblyOrdersManager { get; set; }
        IcvAssemblyOrdersExtendedManager _cvAssemblyOrdersExtendedManager { get; set; }
        IcvAssemblyParentManager _cvAssemblyParentManager { get; set; }
        IcvAssemblyParentComponentManager _cvAssemblyParentComponentManager { get; set; }
        IcvAssemblyProductionPassFailManager _cvAssemblyProductionPassFailManager { get; set; }
        IcvAssemblyProductionReportManager _cvAssemblyProductionReportManager { get; set; }
        IcvAssemblyProductionReportInnerManager _cvAssemblyProductionReportInnerManager { get; set; }
        IcvAssemblyProductLabelManager _cvAssemblyProductLabelManager { get; set; }
        IcvAssemblySessionsManager _cvAssemblySessionsManager { get; set; }
        IcvAssemblyUnallocatedComponentsManager _cvAssemblyUnallocatedComponentsManager { get; set; }
        IcvBorsightTransfersForAssembliesManager _cvBorsightTransfersForAssembliesManager { get; set; }
        IcvCustomerContactCleanPhoneManager _cvCustomerContactCleanPhoneManager { get; set; }
        IcvIncomingInspectionBOMManager _cvIncomingInspectionBOMManager { get; set; }
        IcvIncomingQCTemplateManager _cvIncomingQCTemplateManager { get; set; }
        IcvIngredientClaimActivitiesManager _cvIngredientClaimActivitiesManager { get; set; }
        IcvInventorySerialLotSummaryTransactionsManager _cvInventorySerialLotSummaryTransactionsManager { get; set; }
        IcvInventoryTransfersManager _cvInventoryTransfersManager { get; set; }
        IcvInvoiceBalanceManager _cvInvoiceBalanceManager { get; set; }
        IcvINVTransactionDetailCrystalControlManager _cvINVTransactionDetailCrystalControlManager { get; set; }
        IcvINVTransferDetailsManager _cvINVTransferDetailsManager { get; set; }
        IcvIssueManager _cvIssueManager { get; set; }
        IcvIssueAssemblyManager _cvIssueAssemblyManager { get; set; }
        IcvIssueChangedAssignmentManager _cvIssueChangedAssignmentManager { get; set; }
        IcvIssuesForMfgManager _cvIssuesForMfgManager { get; set; }
        IcvIssuesForWarehouseManager _cvIssuesForWarehouseManager { get; set; }
        IcvIssueViewersManager _cvIssueViewersManager { get; set; }
        IcvIssueViewersAssembliesManager _cvIssueViewersAssembliesManager { get; set; }
        IcvIssueViewersParentAssemblyManager _cvIssueViewersParentAssemblyManager { get; set; }
        IcvLastPOForProductManager _cvLastPOForProductManager { get; set; }
        IcvLinkConfigManager _cvLinkConfigManager { get; set; }
        IcvLinkConfigDocumentFoldersManager _cvLinkConfigDocumentFoldersManager { get; set; }
        IcvLinkConfigDocumentsManager _cvLinkConfigDocumentsManager { get; set; }
        IcvLinkConfigGuidesManager _cvLinkConfigGuidesManager { get; set; }
        IcvLinkConfigLabelsManager _cvLinkConfigLabelsManager { get; set; }
        IcvLinkConfigReportsManager _cvLinkConfigReportsManager { get; set; }
        IcvLinkConfigXrefManager _cvLinkConfigXrefManager { get; set; }
        IcvLinkProductSelectorManager _cvLinkProductSelectorManager { get; set; }
        IcvLocationSummaryManager _cvLocationSummaryManager { get; set; }
        IcvLotSerialInventoryManager _cvLotSerialInventoryManager { get; set; }
        IcvLotSerialLocationSummaryManager _cvLotSerialLocationSummaryManager { get; set; }
        IcvNegativeLotLocationManager _cvNegativeLotLocationManager { get; set; }
        IcvNegativeLotLocationNAHSManager _cvNegativeLotLocationNAHSManager { get; set; }
        IcvOptionGroupManager _cvOptionGroupManager { get; set; }
        IcvOptionsManager _cvOptionsManager { get; set; }
        IcvOptionTypeManager _cvOptionTypeManager { get; set; }
        IcvOrderDetTranslationManager _cvOrderDetTranslationManager { get; set; }
        IcvPODetWhereUsedManager _cvPODetWhereUsedManager { get; set; }
        IcvPODetWithReceiptsAssyNeededManager _cvPODetWithReceiptsAssyNeededManager { get; set; }
        IcvPOReceiptManager _cvPOReceiptManager { get; set; }
        IcvPOReceiptsAssyNeededManager _cvPOReceiptsAssyNeededManager { get; set; }
        IcvPriorPOForProductManager _cvPriorPOForProductManager { get; set; }
        IcvproductManager _cvproductManager { get; set; }
        IcvProductAvailabilityManager _cvProductAvailabilityManager { get; set; }
        IcvProductBatchManager _cvProductBatchManager { get; set; }
        IcvProductComponentManager _cvProductComponentManager { get; set; }
        IcvProductEffectivePriceManager _cvProductEffectivePriceManager { get; set; }
        IcvProductExportNSSManager _cvProductExportNSSManager { get; set; }
        IcvProductFinishedNSSManager _cvProductFinishedNSSManager { get; set; }
        IcvProductIngredientNSSManager _cvProductIngredientNSSManager { get; set; }
        IcvProductLocationSummaryManager _cvProductLocationSummaryManager { get; set; }
        IcvProductMetricsManager _cvProductMetricsManager { get; set; }
        IcvProductPackageUnitConversionManager _cvProductPackageUnitConversionManager { get; set; }
        IcvProductPackagingManager _cvProductPackagingManager { get; set; } 
        IcvProductProcManager _cvProductProcManager { get; set; }
        IcvProductPurchaseUnitConversionManager _cvProductPurchaseUnitConversionManager { get; set; }
        IcvProductQCManager _cvProductQCManager { get; set; }
        IcvProductSpecAssembliesManager _cvProductSpecAssembliesManager { get; set; }
        IcvProductVendorPriceManager _cvProductVendorPriceManager { get; set; }
        IcvReceiptTransactionDetailManager _cvReceiptTransactionDetailManager { get; set; }
        IcvReceivingLogManager _cvReceivingLogManager { get; set; }
        IcvRoleAccessManager _cvRoleAccessManager { get; set; }
        IcvSuppManufactureManager _cvSuppManufactureManager { get; set; }
        IcvSuppManufactureYieldManager _cvSuppManufactureYieldManager { get; set; }
        IcvTrxDetailControlSeriesManager _cvTrxDetailControlSeriesManager { get; set; }
        IcvTrxDetailControlValuesManager _cvTrxDetailControlValuesManager { get; set; }
        IcvVendorRequestForQuotesManager _cvVendorRequestForQuotesManager { get; set; }
        IEDIAdditionalInformationManager _EDIAdditionalInformationManager { get; set; }
        IEDIOrderDetailExManager _EDIOrderDetailExManager { get; set; }
        IDocumentManager _DocumentManager { get; set; }
        IEDIOrdersExManager _EDIOrdersExManager { get; set; }
        IEmployeeManager _EmployeeManager { get; set; }
        IFIFOCostLayersManager _FIFOCostLayersManager { get; set; }
        IFlattenedKitComponentsManager _FlattenedKitComponentsManager { get; set; }
        IGLAccountManager _GLAccountManager { get; set; }
        IGLAccountSegmentManager _GLAccountSegmentManager { get; set; }
        IImpExpDocumentColumnManager _ImpExpDocumentColumnManager { get; set; }
        IImpExpDocumentTableManager _ImpExpDocumentTableManager { get; set; }
        IImpExpDocumentTypeManager _ImpExpDocumentTypeManager { get; set; }
        IImportManager _ImportManager { get; set; }
        IImportConversionManager _ImportConversionManager { get; set; }
        IImportDefaultConversionManager _ImportDefaultConversionManager { get; set; }
        IImportDefaultMapManager _ImportDefaultMapManager { get; set; }
        IImportDefaultNamespaceManager _ImportDefaultNamespaceManager { get; set; }
        IImportDefaultSourceFieldsManager _ImportDefaultSourceFieldsManager { get; set; }
        IImportDefaultTableManager _IImportDefaultTableManager { get; set; }
        IImportErrorsManager _ImportErrorsManager { get; set; }
        IImportMapManager _ImportMapManager { get; set; }
        IImportNamespaceManager _ImportNamespaceManager { get; set; }
        IImportSkippedManager _ImportSkippedManager { get; set; }
        IImportSourceFieldsManager _ImportSourceFieldsManager { get; set; }
        IImportSourceFileManager _ImportSourceFileManager { get; set; }
        IImportSourceRelateFieldsManager _ImportSourceRelateFieldsManager { get; set; }
        IImportTableManager _ImportTableManager { get; set; }
        IImportTemplateOptionsManager _ImportTemplateOptionsManager { get; set; }
        IImportTransformationManager _ImportTransformationManager { get; set; }
        IInventoryJournalManager _InventoryJournalManager { get; set; }
        IInventoryJournalDetailManager _InventoryJournalDetailManager { get; set; }
        IInventoryJournalDetail_NoAccountsManager _InventoryJournalDetail_NoAccountsManager { get; set; }
        IInventoryJournalSummaryManager _InventoryJournalSummaryManager { get; set; }
        IINVLotSerialTraceManager _INVLotSerialTraceManager { get; set; }
        IINVLotSerialTraceDetailManager _INVLotSerialTraceDetailManager { get; set; }
        IInvoiceManager _InvoiceManager { get; set; }
        IInvoiceAmtSummaryManager _InvoiceAmtSummaryManager { get; set; }
        IInvoiceDetailManager _InvoiceDetailManager { get; set; }
        IInvoicesAndChargesManager _InvoicesAndChargesManager { get; set; }
        IINVRegisterManager _INVRegisterManager { get; set; }
        IINVTransactionManager _INVTransactionManager { get; set; }
        IINVTransactionDetailManager _INVTransactionDetailManager { get; set; }
        IINVTransactionDetailOnHandSummaryManager _INVTransactionDetailOnHandSummaryManager { get; set; }
        IINVTransactionDetailSummaryManager _INVTransactionDetailSummaryManager { get; set; }
        IIssueCodeManager _IssueCodeManager { get; set; }
        IIssueManager _IssueManager { get; set; }
        IIssueLogManager _IssueLogManager { get; set; }
        IIssuePriorityCodeManager _IssuePriorityCodeManager { get; set; }
        IIssueResolutionCodeManager _IssueResolutionCodeManager { get; set; }
        IIssueSchedulingClassManager _IssueSchedulingClassManager { get; set; }
        IIssueStatusCodeManager _IssueStatusCodeManager { get; set; }
        IIssueTypeManager _IssueTypeManager { get; set; }
        IIssueTypeCodeXrefManager _IssueTypeCodeXrefManager { get; set; }
        IIssueTypePriorityXrefManager _IssueTypePriorityXrefManager { get; set; }
        IIssueTypeResolutionXrefManager _IssueTypeResolutionXrefManager { get; set; }
        IIssueTypeSchedulingClassXrefManager _IssueTypeSchedulingClassXrefManager { get; set; }
        IIssueTypeStatusXrefManager _IssueTypeStatusXrefManager { get; set; }
        IIssueXrefManager _IssueXrefManager { get; set; }
        IJournalManager _JournalManager { get; set; }
        IJournalLineManager _JournalLineManager { get; set; }
        ILIFOCostLayersManager _LIFOCostLayersManager { get; set; }
        ILocationSummaryManager _LocationSummaryManager { get; set; }
        ILocationSummaryNoAvailabilityManager _LocationSummaryNoAvailabilityManager { get; set; }
        ILostBusinessManager _LostBusinessManager { get; set; }
        ILotSerialDefaultLocationManager _LotSerialDefaultLocationManager { get; set; }
        ILotSerialInventoryManager _LotSerialInventoryManager { get; set; }
        ILotSerialInventoryIssuesManager _LotSerialInventoryIssuesManager { get; set; }
        ILotSerialInventoryReceiptsManager _LotSerialInventoryReceiptsManager { get; set; }
        ILotSerialInventoryWithoutLastReceiptManager _LotSerialInventoryWithoutLastReceiptManager { get; set; }
        ILotSerialLocationManager _LotSerialLocationManager { get; set; }
        ILotSerialLocationSummaryManager _LotSerialLocationSummaryManager { get; set; }
        ILotSerialLocationSummaryNoAvailabilityManager _LotSerialLocationSummaryNoAvailabilityManager { get; set; }
        ILotSerialSummaryManager _LotSerialSummaryManager { get; set; }
        IMarketingCodeManager _MarketingCodeManager { get; set; }
        IMarketingListCodeManager _MarketingListCodeManager { get; set; }
        IMarketingListXrefManager _MarketingListXrefManager { get; set; }
        IMessagesManager _MessagesManager { get; set; }
        INoteCategoryManager _NoteCategoryManager { get; set; }
        INotesManager _NotesManager { get; set; }
        public ExecController(
            ICvAssembliesManager cvAssembliesManager, 
            IAccessManager AccessManager,
            ICvAssemblyDetailsManager CvAssemblyDetailsManager,
            IAccessPermissionManager accessPermissionManager,
            IAccessPermissionMasterManager accessPermissionMasterManager,
            IBranchManager branchManager,
            IBusinessActivityHistoryManager businessActivityHistoryManager,
            IBusinessActivityManager businessActivityManager,
            IBusinessActivityRelatedItemsManager businessActivityRelatedItemsManager,
            IBusinessActivityTimeAndMaterialsManager businessActivityTimeAndMaterialsManager,
            ICarrierManager carrierManager,
            ICarrierBillingOptionsManager carrierBillingOptionsManager,
            ICarrierInsuranceOptionsManager carrierInsuranceOptionsManager,
            ICarrierServiceManager carrierServiceManager,
            ICarrierVoidOptionsManager carrierVoidOptionsManager,
            IChargeManager chargeManager,
            IClassManager classManager,
            IContractTypeManager contractTypeManager,
            ICostLayerIssuesManager costLayerIssues,
            ICvAssemblyCustomerOrderManager cvAssemblyCustomerOrder,
            ICvAssemblyDocumentMembersManager cvAssemblyDocumentMembersManager,
            ICvAssemblyProductionRecordManager cvAssemblyProductionRecordManager,
            ICvInventoryTransfersRepeaterManager cvInventoryTransfersRepeaterManager,
            ICostLayerReceiptsManager costLayerReceiptsManager,
            ICostLayersManager costLayersManager,
            ICurrencyManager currencyManager,
            ICustomDataListManager customDataListManager,
            ICustomerManager customerManager,
            ICustomerBalanceManager customerBalanceManager,
            ICustomerChargeTotalManager customerChargeTotalDataAccess,
            ICustomerContactManager customerContactDataAccess,
            ICustomerContractManager customerContractManager,
            ICustomerCreditStatusManager customerCreditStatusManager,
            ICustomerEmailAddressListManager customerEmailAddressListManager,
            IProductComponentManager productComponentManager,
            ICustomerExportManager customerExportManager,
            ICustomerFullNameManager customerFullNameManager,
            ICustomerInfoManager customerInfoManager,
            ICustomerInvoiceTotalManager customerInvoiceTotalManager,
            ICustomerMarketingListXrefManager customerMarketingListXrefManager,
            ICustomerPaymentManager customerPaymentManager,
            ICustomerPaymentAppliedTotalManager customerPaymentAppliedTotalManager,
            ICustomerPaymentChargeTotalManager customerPaymentChargeTotalManager,
            ICustomerPaymentInvoiceManager customerPaymentInvoiceManager,
            ICustomerPaymentInvoiceTotalManager customerPaymentInvoiceTotalManager,
            ICustomerPaymentTotalManager customerPaymentTotalManager,
            ICustomerPaymentViewManager customerPaymentViewManager,
            ICustomerProductManager customerProductManager,
            ICustomerShipManager customerShipManager,
            ICustomerShipToInfoManager customerShipToInfoManager,
            ICustomerShipViewManager customerShipViewManager,
            ICustomerStatementManager customerStatementManager,
            ICustomerTypeInfoManager customerTypeInfoManager,
            ICustomerViewManager customerViewManager,
            ICustomFieldManager customFeildManager,
            IcvAccessGroupManager cvAccessGroupManager,
            IcvAccessGroupUsersManager cvAccessGroupUsersManager,
            IcvAssemblyComponentAvailabilityManager cvAssemblyComponentAvailabilityManager,
            IcvAssemblyComponentLotAvailabilityManager cvAssemblyComponentLotAvailabilityManager,
            IcvAssemblyOrderDetManager cvAssemblyOrderDetManager,
            IcvAssemblyOrderDetailManager cvAssemblyOrderDetailManager,
            IcvAssemblyOrderDetailStatsManager cvAssemblyOrderDetailStatsManager,
            IcvAssemblyOrderDetailSummaryManager cvAssemblyOrderDetailSummaryManager,
            IcvAssemblyOrderHeaderManager cvAssemblyOrderHeaderManager,
            IcvAssemblyOrderMembersManager cvAssemblyOrderMembersManager,
            IcvAssemblyOrderPackagingManager cvAssemblyOrderPackagingManager,
            IcvAssemblyOrdersManager cvAssemblyOrdersManager,
            IcvAssemblyOrdersExtendedManager cvAssemblyOrdersExtendedManager,
            IcvAssemblyParentManager cvAssemblyParentManager,
            IcvAssemblyParentComponentManager cvAssemblyParentComponentManager,
            IcvAssemblyProductionPassFailManager cvAssemblyProductionPassFailManager,
            IcvAssemblyProductionReportManager cvAssemblyProductionReportManager,
            IcvAssemblyProductionReportInnerManager cvAssemblyProductionReportInnerManager,
            IcvAssemblyProductLabelManager cvAssemblyProductLabelManager,
            IcvAssemblySessionsManager cvAssemblySessionsManager,
            IcvAssemblyUnallocatedComponentsManager cvAssemblyUnallocatedComponentsManager,
            IcvBorsightTransfersForAssembliesManager cvBorsightTransfersForAssembliesManager,
            IcvCustomerContactCleanPhoneManager cvCustomerContactCleanPhoneManager,
            IcvIncomingInspectionBOMManager cvIncomingInspectionBOMManager,
            IcvIncomingQCTemplateManager cvIncomingQCTemplateManager,
            IcvIngredientClaimActivitiesManager cvIngredientClaimActivitiesManager,
            IcvInventorySerialLotSummaryTransactionsManager cvInventorySerialLotSummaryTransactionsManager,
            IcvInventoryTransfersManager cvInventoryTransfersManager,
            IcvInvoiceBalanceManager cvInvoiceBalanceManager,
            IcvINVTransactionDetailCrystalControlManager cvINVTransactionDetailCrystalControlManager,
            IcvINVTransferDetailsManager cvINVTransferDetailsManager,
            IcvIssueManager cvIssueManager,
            IcvIssueAssemblyManager cvIssueAssemblyManager,
            IcvIssueChangedAssignmentManager cvIssueChangedAssignmentManager,
            IcvIssuesForMfgManager cvIssuesForMfgManager,
            IcvIssuesForWarehouseManager cvIssuesForWarehouseManager,
            IcvIssueViewersManager cvIssueViewersManager,
            IcvIssueViewersAssembliesManager cvIssueViewersAssembliesManager,
            IcvIssueViewersParentAssemblyManager cvIssueViewersParentAssemblyManager,
            IcvLastPOForProductManager cvLastPOForProductManager,
            IcvLinkConfigManager cvLinkConfigManager,
            IcvLinkConfigDocumentFoldersManager cvLinkConfigDocumentFoldersManager,
            IcvLinkConfigDocumentsManager cvLinkConfigDocumentsManager,
            IcvLinkConfigGuidesManager cvLinkConfigGuidesManager,
            IcvLinkConfigLabelsManager cvLinkConfigLabelsManager,
            IcvLinkConfigReportsManager cvLinkConfigReportsManager,
            IcvLinkConfigXrefManager cvLinkConfigXrefManager,
            IcvLinkProductSelectorManager cvLinkProductSelectorManager,
            IcvLocationSummaryManager cvLocationSummaryManager,
            IcvLotSerialInventoryManager cvLotSerialInventoryManager,
            IcvLotSerialLocationSummaryManager cvLotSerialLocationSummaryManager,
            IcvNegativeLotLocationManager cvNegativeLotLocationManager,
            IcvNegativeLotLocationNAHSManager cvNegativeLotLocationNAHSManager,
            IcvOptionGroupManager cvOptionGroupManager,
            IcvOptionsManager cvOptionsManager,
            IcvOptionTypeManager cvOptionTypeManager,
            IcvOrderDetTranslationManager cvOrderDetTranslationManager,
            IcvPODetWhereUsedManager cvPODetWhereUsedManager,
            IcvPODetWithReceiptsAssyNeededManager cvPODetWithReceiptsAssyNeededManager,
            IcvPOReceiptManager cvPOReceiptManager,
            IcvPOReceiptsAssyNeededManager cvPOReceiptsAssyNeededManager,
            IcvPriorPOForProductManager cvPriorPOForProductManager,
            IcvproductManager cvproductManager,
            IcvProductAvailabilityManager cvProductAvailabilityManager,
            IcvProductBatchManager cvProductBatchManager,
            IcvProductComponentManager cvProductComponentManager,
            IcvProductEffectivePriceManager cvProductEffectivePriceManager,
            IcvProductExportNSSManager cvProductExportNSSManager,
            IcvProductFinishedNSSManager cvProductFinishedNSSManager,
            IcvProductIngredientNSSManager cvProductIngredientNSSManager,
            IcvProductLocationSummaryManager cvProductLocationSummaryManager,
            IcvProductMetricsManager cvProductMetricsManager,
            IcvProductPackageUnitConversionManager cvProductPackageUnitConversionManager,
            IcvProductPackagingManager cvProductPackagingManager,
            IcvProductProcManager cvProductProcManager,
            IcvProductPurchaseUnitConversionManager cvProductPurchaseUnitConversionManager,
            IcvProductQCManager cvProductQCManager,
            IcvProductSpecAssembliesManager cvProductSpecAssembliesManager,
            IcvProductVendorPriceManager cvProductVendorPriceManager,
            IcvReceiptTransactionDetailManager cvReceiptTransactionDetailManager,
            IcvReceivingLogManager cvReceivingLogManager,
            IcvRoleAccessManager cvRoleAccessManager,
            IcvSuppManufactureManager cvSuppManufactureManager,
            IcvSuppManufactureYieldManager cvSuppManufactureYieldManager,
            IcvTrxDetailControlSeriesManager cvTrxDetailControlSeriesManager,
            IcvTrxDetailControlValuesManager cvTrxDetailControlValuesManager,
            IcvVendorRequestForQuotesManager cvVendorRequestForQuotesManager,
            IDocumentManager documentManager,
            IEDIAdditionalInformationManager eDIAdditionalInformationManager,
            IEDIOrderDetailExManager eDIOrderDetailExManager,
            IEDIOrdersExManager eDIOrdersExManager,
            IEmployeeManager employeeManager,
            IFIFOCostLayersManager fIFOCostLayersManager,
            IFlattenedKitComponentsManager flattenedKitComponentsManager,
            IGLAccountManager gLAccountManager,
            IGLAccountSegmentManager gLAccountSegmentManager,
            IImpExpDocumentColumnManager impExpDocumentColumnManager,
            IImpExpDocumentTableManager impExpDocumentTableManager,
            IImpExpDocumentTypeManager impExpDocumentTypeManager,
            IImportManager importManager,
            IImportConversionManager importConversionManager,
            IImportDefaultConversionManager importDefaultConversionManager,
            IImportDefaultMapManager importDefaultMapManager,
            IImportDefaultNamespaceManager importDefaultNamespaceManager,
            IImportDefaultSourceFieldsManager importDefaultSourceFieldsManager,
            IImportDefaultTableManager iImportDefaultTableManager,
            IImportErrorsManager importErrorsManager,
            IImportMapManager importMapManager,
            IImportNamespaceManager importNamespaceManager,
            IImportSkippedManager importSkippedManager,
            IImportSourceFieldsManager importSourceFieldsManager,
            IImportSourceFileManager importSourceFileManager,
            IImportSourceRelateFieldsManager importSourceRelateFieldsManager,
            IImportTableManager importTableManager,
            IImportTemplateOptionsManager importTemplateOptionsManager,
            IImportTransformationManager importTransformationManager,
            IInventoryJournalManager inventoryJournalManager,
            IInventoryJournalDetailManager inventoryJournalDetailManager,
            IInventoryJournalDetail_NoAccountsManager inventoryJournalDetail_NoAccountsManager,
            IInventoryJournalSummaryManager inventoryJournalSummaryManager,
            IINVLotSerialTraceManager iNVLotSerialTraceManager,
            IINVLotSerialTraceDetailManager iNVLotSerialTraceDetailManager,
            IInvoiceManager invoiceManager,
            IInvoiceAmtSummaryManager invoiceAmtSummaryManager,
            IInvoiceDetailManager invoiceDetailManager,
            IInvoicesAndChargesManager invoicesAndChargesManager,
            IINVRegisterManager iNVRegisterManager,
            IINVTransactionManager iNVTransactionManager,
            IINVTransactionDetailManager iNVTransactionDetailManager,
            IINVTransactionDetailOnHandSummaryManager iNVTransactionDetailOnHandSummaryManager,
            IINVTransactionDetailSummaryManager iNVTransactionDetailSummaryManager,
            IIssueManager issueManager,
            IIssueCodeManager issueCodeManager,
            IIssueLogManager issueLogManager,
            IIssuePriorityCodeManager issuePriorityCodeManager,
            IIssueResolutionCodeManager issueResolutionCodeManager,
            IIssueSchedulingClassManager issueSchedulingClassManager,
            IIssueStatusCodeManager issueStatusCodeManager,
            IIssueTypeManager issueTypeManager,
            IIssueTypeCodeXrefManager issueTypeCodeXrefManager,
            IIssueTypePriorityXrefManager issueTypePriorityXrefManager,
            IIssueTypeResolutionXrefManager issueTypeResolutionXrefManager,
            IIssueTypeSchedulingClassXrefManager issueTypeSchedulingClassXrefManager,
            IIssueTypeStatusXrefManager issueTypeStatusXrefManager,
            IIssueXrefManager issueXrefManager,
            IJournalManager journalManager,
            IJournalLineManager journalLineManager,
            ILIFOCostLayersManager lIFOCostLayersManager,
            ILocationSummaryManager locationSummaryManager,
            ILocationSummaryNoAvailabilityManager locationSummaryNoAvailabilityManager,
            ILostBusinessManager lostBusinessManager,
            ILotSerialDefaultLocationManager lotSerialDefaultLocationManager,
            ILotSerialInventoryManager lotSerialInventoryManager,
            ILotSerialInventoryIssuesManager lotSerialInventoryIssuesManager,
            ILotSerialInventoryReceiptsManager lotSerialInventoryReceiptsManager,
            ILotSerialInventoryWithoutLastReceiptManager lotSerialInventoryWithoutLastReceiptManager,
            ILotSerialLocationManager lotSerialLocationManager,
            ILotSerialLocationSummaryManager lotSerialLocationSummaryManager,
            ILotSerialLocationSummaryNoAvailabilityManager lotSerialLocationSummaryNoAvailabilityManager,
            ILotSerialSummaryManager lotSerialSummaryManager,
            IMarketingCodeManager marketingCodeManager,
            IMarketingListCodeManager marketingListCodeManager,
            IMarketingListXrefManager marketingListXrefManager,
            IMessagesManager messagesManager,
            INoteCategoryManager noteCategoryManager,
            INotesManager notesManager)

        {
            _CvAssembliesManager = cvAssembliesManager;
            _AccessManager = AccessManager;
            _AccessPermissionManager = accessPermissionManager;
            _CvAssemblyDetailsManager = CvAssemblyDetailsManager;
            __AccessPermissionMasterManager = accessPermissionMasterManager;
            _BranchManager = branchManager;
            _BusinessActivityHistoryManager = businessActivityHistoryManager;
            _BusinessActivityManager = businessActivityManager;
            _BusinessActivityRelatedItemsManager = businessActivityRelatedItemsManager;
            _BusinessActivityTimeAndMaterialsManager = businessActivityTimeAndMaterialsManager;
            _CarrierManager = carrierManager;
            _CarrierBillingOptionsManager = carrierBillingOptionsManager;
            _CarrierInsuranceOptionsManager = carrierInsuranceOptionsManager;
            _CarrierServiceManager = carrierServiceManager;
            _CarrierVoidOptionsManager = carrierVoidOptionsManager;
            _ChargeManager = chargeManager;
            _ClassManager = classManager;
            _ContractTypeManager = contractTypeManager;
            _CostLayerIssues = costLayerIssues;
            _CvAssemblyCustomerOrderManager = cvAssemblyCustomerOrder;
            _CvAssemblyDocumentMembersManager = cvAssemblyDocumentMembersManager;
            _CvAssemblyProductionRecordManager = cvAssemblyProductionRecordManager;
            _CvInventoryTransfersRepeaterManager = cvInventoryTransfersRepeaterManager;
            _CostLayerReceiptsManager = costLayerReceiptsManager;
            _CostLayersManager = costLayersManager;
            _CurrencyManager = currencyManager;
            _CustomDataListManager = customDataListManager;
            _CustomerManager = customerManager;
            _CustomerBalanceManager = customerBalanceManager;
            _CustomerChargeTotalDataAccess = customerChargeTotalDataAccess;
            _CustomerContactDataAccess = customerContactDataAccess;
            _CustomerContractManager = customerContractManager;
            _CustomerCreditStatusManager = customerCreditStatusManager;
            _CustomerEmailAddressListManager = customerEmailAddressListManager;
            _ProductComponentManager = productComponentManager;
            _CustomerExportManager = customerExportManager;
            _CustomerFullNameManager = customerFullNameManager;
            _CustomerInfoManager = customerInfoManager;
            _CustomerInvoiceTotalManager = customerInvoiceTotalManager;
            _CustomerMarketingListXrefManager = customerMarketingListXrefManager;
            _CustomerPaymentManager = customerPaymentManager;
            _CustomerPaymentAppliedTotalManager = customerPaymentAppliedTotalManager;
            _CustomerPaymentChargeTotalManager = customerPaymentChargeTotalManager;
            _CustomerPaymentInvoiceManager = customerPaymentInvoiceManager;
            _CustomerPaymentInvoiceTotalManager = customerPaymentInvoiceTotalManager;
            _CustomerPaymentTotalManager = customerPaymentTotalManager;
            _CustomerPaymentViewManager = customerPaymentViewManager;
            _CustomerProductManager = customerProductManager;
            _CustomerShipManager = customerShipManager;
            _CustomerShipToInfoManager = customerShipToInfoManager;
            _CustomerShipViewManager = customerShipViewManager;
            _CustomerStatementManager = customerStatementManager;
            _CustomerTypeInfoManager = customerTypeInfoManager;
            _CustomerViewManager = customerViewManager;
            _CustomFeildManager = customFeildManager;
            _cvAccessGroupManager = cvAccessGroupManager;
            _cvAccessGroupUsersManager = cvAccessGroupUsersManager;
            _cvAssemblyComponentAvailabilityManager = cvAssemblyComponentAvailabilityManager;
            _cvAssemblyComponentLotAvailabilityManager = cvAssemblyComponentLotAvailabilityManager;
            _cvAssemblyOrderDetManager = cvAssemblyOrderDetManager;
            _cvAssemblyOrderDetailManager = cvAssemblyOrderDetailManager;
            _cvAssemblyOrderDetailStatsManager = cvAssemblyOrderDetailStatsManager;
            _cvAssemblyOrderDetailSummaryManager = cvAssemblyOrderDetailSummaryManager;
            _cvAssemblyOrderHeaderManager = cvAssemblyOrderHeaderManager;
            _cvAssemblyOrderMembersManager = cvAssemblyOrderMembersManager;
            _cvAssemblyOrderPackagingManager = cvAssemblyOrderPackagingManager;
            _cvAssemblyOrdersManager = cvAssemblyOrdersManager;
            _cvAssemblyOrdersExtendedManager = cvAssemblyOrdersExtendedManager;
            _cvAssemblyParentManager = cvAssemblyParentManager;
            _cvAssemblyParentComponentManager = cvAssemblyParentComponentManager;
            _cvAssemblyProductionPassFailManager = cvAssemblyProductionPassFailManager;
            _cvAssemblyProductionReportManager = cvAssemblyProductionReportManager;
            _cvAssemblyProductionReportInnerManager = cvAssemblyProductionReportInnerManager;
            _cvAssemblyProductLabelManager = cvAssemblyProductLabelManager;
            _cvAssemblySessionsManager = cvAssemblySessionsManager;
            _cvAssemblyUnallocatedComponentsManager = cvAssemblyUnallocatedComponentsManager;
            _cvBorsightTransfersForAssembliesManager = cvBorsightTransfersForAssembliesManager;
            _cvCustomerContactCleanPhoneManager = cvCustomerContactCleanPhoneManager;
            _cvIncomingInspectionBOMManager = cvIncomingInspectionBOMManager;
            _cvIncomingQCTemplateManager = cvIncomingQCTemplateManager;
            _cvIngredientClaimActivitiesManager = cvIngredientClaimActivitiesManager;
            _cvInventorySerialLotSummaryTransactionsManager = cvInventorySerialLotSummaryTransactionsManager;
            _cvInventoryTransfersManager = cvInventoryTransfersManager;
            _cvInvoiceBalanceManager = cvInvoiceBalanceManager;
            _cvINVTransactionDetailCrystalControlManager = cvINVTransactionDetailCrystalControlManager;
            _cvINVTransferDetailsManager = cvINVTransferDetailsManager;
            _cvIssueManager = cvIssueManager;
            _cvIssueAssemblyManager = cvIssueAssemblyManager;
            _cvIssueChangedAssignmentManager = cvIssueChangedAssignmentManager;
            _cvIssuesForMfgManager = cvIssuesForMfgManager;
            _cvIssuesForWarehouseManager = cvIssuesForWarehouseManager;
            _cvIssueViewersManager = cvIssueViewersManager;
            _cvIssueViewersAssembliesManager = cvIssueViewersAssembliesManager;
            _cvIssueViewersParentAssemblyManager = cvIssueViewersParentAssemblyManager;
            _cvLastPOForProductManager = cvLastPOForProductManager;
            _cvLinkConfigManager = cvLinkConfigManager;
            _cvLinkConfigDocumentFoldersManager = cvLinkConfigDocumentFoldersManager;
            _cvLinkConfigDocumentsManager = cvLinkConfigDocumentsManager;
            _cvLinkConfigGuidesManager = cvLinkConfigGuidesManager;
            _cvLinkConfigLabelsManager = cvLinkConfigLabelsManager;
            _cvLinkConfigReportsManager = cvLinkConfigReportsManager;
            _cvLinkConfigXrefManager = cvLinkConfigXrefManager;
            _cvLinkProductSelectorManager = cvLinkProductSelectorManager;
            _cvLocationSummaryManager = cvLocationSummaryManager;
            _cvLotSerialInventoryManager = cvLotSerialInventoryManager;
            _cvLotSerialLocationSummaryManager = cvLotSerialLocationSummaryManager;
            _cvNegativeLotLocationManager = cvNegativeLotLocationManager;
            _cvNegativeLotLocationNAHSManager = cvNegativeLotLocationNAHSManager;
            _cvOptionGroupManager = cvOptionGroupManager;
            _cvOptionsManager = cvOptionsManager;
            _cvOptionTypeManager = cvOptionTypeManager;
            _cvOrderDetTranslationManager = cvOrderDetTranslationManager;
            _cvPODetWhereUsedManager = cvPODetWhereUsedManager;
            _cvPODetWithReceiptsAssyNeededManager = cvPODetWithReceiptsAssyNeededManager;
            _cvPOReceiptManager = cvPOReceiptManager;
            _cvPOReceiptsAssyNeededManager = cvPOReceiptsAssyNeededManager;
            _cvPriorPOForProductManager = cvPriorPOForProductManager;
            _cvproductManager = cvproductManager;
            _cvProductAvailabilityManager = cvProductAvailabilityManager;
            _cvProductBatchManager = cvProductBatchManager;
            _cvProductComponentManager = cvProductComponentManager;
            _cvProductEffectivePriceManager = cvProductEffectivePriceManager;
            _cvProductExportNSSManager = cvProductExportNSSManager;
            _cvProductFinishedNSSManager = cvProductFinishedNSSManager;
            _cvProductIngredientNSSManager = cvProductIngredientNSSManager;
            _cvProductLocationSummaryManager = cvProductLocationSummaryManager;
            _cvProductMetricsManager = cvProductMetricsManager;
            _cvProductPackageUnitConversionManager = cvProductPackageUnitConversionManager;
            _cvProductPackagingManager = cvProductPackagingManager;
            _cvProductProcManager = cvProductProcManager;
            _cvProductPurchaseUnitConversionManager = cvProductPurchaseUnitConversionManager;
            _cvProductQCManager = cvProductQCManager;
            _cvProductSpecAssembliesManager = cvProductSpecAssembliesManager;
            _cvProductVendorPriceManager = cvProductVendorPriceManager;
            _cvReceiptTransactionDetailManager = cvReceiptTransactionDetailManager;
            _cvReceivingLogManager = cvReceivingLogManager;
            _cvRoleAccessManager = cvRoleAccessManager;
            _cvSuppManufactureManager = cvSuppManufactureManager;
            _cvSuppManufactureYieldManager = cvSuppManufactureYieldManager;
            _cvTrxDetailControlSeriesManager = cvTrxDetailControlSeriesManager;
            _cvTrxDetailControlValuesManager = cvTrxDetailControlValuesManager;
            _cvVendorRequestForQuotesManager = cvVendorRequestForQuotesManager;
            _DocumentManager = documentManager;
            _EDIAdditionalInformationManager = eDIAdditionalInformationManager;
            _EDIOrderDetailExManager = eDIOrderDetailExManager;
            _EDIOrdersExManager = eDIOrdersExManager;
            _EmployeeManager = employeeManager;
            _FIFOCostLayersManager = fIFOCostLayersManager;
            _FlattenedKitComponentsManager = flattenedKitComponentsManager;
            _GLAccountManager = gLAccountManager;
            _GLAccountSegmentManager = gLAccountSegmentManager;
            _ImpExpDocumentColumnManager = impExpDocumentColumnManager;
            _ImpExpDocumentTableManager = impExpDocumentTableManager;
            _ImpExpDocumentTypeManager = impExpDocumentTypeManager;
            _ImportManager = importManager;
            _ImportConversionManager = importConversionManager;
            _ImportDefaultConversionManager = importDefaultConversionManager;
            _ImportDefaultMapManager = importDefaultMapManager;
            _ImportDefaultNamespaceManager = importDefaultNamespaceManager;
            _ImportDefaultSourceFieldsManager = importDefaultSourceFieldsManager;
            _IImportDefaultTableManager = iImportDefaultTableManager;
            _ImportErrorsManager = importErrorsManager;
            _ImportMapManager = importMapManager;
            _ImportNamespaceManager = importNamespaceManager;
            _ImportSkippedManager = importSkippedManager;
            _ImportSourceFieldsManager = importSourceFieldsManager;
            _ImportSourceFileManager = importSourceFileManager;
            _ImportSourceRelateFieldsManager = importSourceRelateFieldsManager;
            _ImportTableManager = importTableManager;
            _ImportTemplateOptionsManager = importTemplateOptionsManager;
            _ImportTransformationManager = importTransformationManager;
            _InventoryJournalManager = inventoryJournalManager;
            _InventoryJournalDetailManager = inventoryJournalDetailManager;
            _InventoryJournalDetail_NoAccountsManager = inventoryJournalDetail_NoAccountsManager;
            _InventoryJournalSummaryManager = inventoryJournalSummaryManager;
            _INVLotSerialTraceManager = iNVLotSerialTraceManager;
            _INVLotSerialTraceDetailManager = iNVLotSerialTraceDetailManager;
            _InvoiceManager = invoiceManager;
            _InvoiceAmtSummaryManager = invoiceAmtSummaryManager;
            _InvoiceDetailManager = invoiceDetailManager;
            _InvoicesAndChargesManager = invoicesAndChargesManager;
            _INVRegisterManager = iNVRegisterManager;
            _INVTransactionManager = iNVTransactionManager;
            _INVTransactionDetailManager = iNVTransactionDetailManager;
            _INVTransactionDetailOnHandSummaryManager = iNVTransactionDetailOnHandSummaryManager;
            _INVTransactionDetailSummaryManager = iNVTransactionDetailSummaryManager;
            _IssueManager = issueManager;
            _IssueCodeManager = issueCodeManager;
            _IssueLogManager = issueLogManager;
            _IssuePriorityCodeManager = issuePriorityCodeManager;
            _IssueResolutionCodeManager = issueResolutionCodeManager;
            _IssueSchedulingClassManager = issueSchedulingClassManager;
            _IssueStatusCodeManager = issueStatusCodeManager;
            _IssueTypeManager = issueTypeManager;
            _IssueTypeCodeXrefManager = issueTypeCodeXrefManager;
            _IssueTypePriorityXrefManager = issueTypePriorityXrefManager;
            _IssueTypeResolutionXrefManager = issueTypeResolutionXrefManager;
            _IssueTypeSchedulingClassXrefManager = issueTypeSchedulingClassXrefManager;
            _IssueTypeStatusXrefManager = issueTypeStatusXrefManager;
            _IssueXrefManager = issueXrefManager;
            _JournalManager = journalManager;
            _JournalLineManager = journalLineManager;
            _LIFOCostLayersManager = lIFOCostLayersManager;
            _LocationSummaryManager = locationSummaryManager;
            _LocationSummaryNoAvailabilityManager = locationSummaryNoAvailabilityManager;
            _LostBusinessManager = lostBusinessManager;
            _LotSerialDefaultLocationManager = lotSerialDefaultLocationManager;
            _LotSerialInventoryManager = lotSerialInventoryManager;
            _LotSerialInventoryIssuesManager = lotSerialInventoryIssuesManager;
            _LotSerialInventoryReceiptsManager = lotSerialInventoryReceiptsManager;
            _LotSerialInventoryWithoutLastReceiptManager = lotSerialInventoryWithoutLastReceiptManager;
            _LotSerialLocationManager = lotSerialLocationManager;
            _LotSerialLocationSummaryManager = lotSerialLocationSummaryManager;
            _LotSerialLocationSummaryNoAvailabilityManager = lotSerialLocationSummaryNoAvailabilityManager;
            _LotSerialSummaryManager = lotSerialSummaryManager;
            _MarketingCodeManager = marketingCodeManager;
            _MarketingListCodeManager = marketingListCodeManager;
            _MarketingListXrefManager = marketingListXrefManager;
            _MessagesManager = messagesManager;
            _NoteCategoryManager = noteCategoryManager;
            _NotesManager = notesManager;
        }

        [HttpPost]
        [Route("/api/Full/Notes/Get")]
        public ActionResult NotesGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_NotesManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/NoteCategory/Get")]
        public ActionResult NoteCategoryGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_NoteCategoryManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/Messages/Get")]
        public ActionResult MessagesGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_MessagesManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/MarketingListXref/Get")]
        public ActionResult MarketingListXrefGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_MarketingListXrefManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/MarketingListCode/Get")]
        public ActionResult MarketingListCodeGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_MarketingListCodeManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/MarketingCode/Get")]
        public ActionResult MarketingCodeGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_MarketingCodeManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/LotSerialSummary/Get")]
        public ActionResult LotSerialSummaryGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_LotSerialSummaryManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/LotSerialLocationSummaryNoAvailability/Get")]
        public ActionResult LotSerialLocationSummaryNoAvailabilityGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_LotSerialLocationSummaryNoAvailabilityManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/LotSerialLocationSummary/Get")]
        public ActionResult LotSerialLocationSummaryGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_LotSerialLocationSummaryManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/LotSerialLocation/Get")]
        public ActionResult LotSerialLocationGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_LotSerialLocationManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/LotSerialInventoryWithoutLastReceipt/Get")]
        public ActionResult LotSerialInventoryWithoutLastReceiptGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_LotSerialInventoryWithoutLastReceiptManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/LotSerialInventoryReceipts/Get")]
        public ActionResult LotSerialInventoryReceiptsGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_LotSerialInventoryReceiptsManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/LotSerialInventoryIssues/Get")]
        public ActionResult LotSerialInventoryIssuesGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_LotSerialInventoryIssuesManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/LotSerialInventory/Get")]
        public ActionResult LotSerialInventoryGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_LotSerialInventoryManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/LotSerialDefaultLocation/Get")]
        public ActionResult LotSerialDefaultLocationGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_LotSerialDefaultLocationManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/LostBusiness/Get")]
        public ActionResult LostBusinessGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_LostBusinessManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/LocationSummaryNoAvailability/Get")]
        public ActionResult LocationSummaryNoAvailabilityGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_LocationSummaryNoAvailabilityManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/LocationSummary/Get")]
        public ActionResult LocationSummaryGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_LocationSummaryManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/LIFOCostLayers/Get")]
        public ActionResult LIFOCostLayersGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_LIFOCostLayersManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/JournalLine/Get")]
        public ActionResult JournalLineGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_JournalLineManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/Journal/Get")]
        public ActionResult JournalGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_JournalManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/IssueXref/Get")]
        public ActionResult IssueXrefGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_IssueXrefManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/IssueTypeStatusXref/Get")]
        public ActionResult IssueTypeStatusXrefGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_IssueTypeStatusXrefManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/IssueTypeSchedulingClassXref/Get")]
        public ActionResult IssueTypeSchedulingClassXrefGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_IssueTypeSchedulingClassXrefManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/IssueTypeResolutionXref/Get")]
        public ActionResult IssueTypeResolutionXrefGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_IssueTypeResolutionXrefManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/IssueTypePriorityXref/Get")]
        public ActionResult IssueTypePriorityXrefGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_IssueTypePriorityXrefManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/IssueTypeCodeXref/Get")]
        public ActionResult IssueTypeCodeXrefGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_IssueTypeCodeXrefManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/IssueType/Get")]
        public ActionResult IssueTypeGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_IssueTypeManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/IssueStatusCode/Get")]
        public ActionResult IssueStatusCodeGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_IssueStatusCodeManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/IssueSchedulingClass/Get")]
        public ActionResult IssueSchedulingClassGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_IssueSchedulingClassManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/IssueResolutionCode/Get")]
        public ActionResult IssueResolutionCodeGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_IssueResolutionCodeManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/IssuePriorityCode/Get")]
        public ActionResult IssuePriorityCodeGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_IssuePriorityCodeManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/IssueLog/Get")]
        public ActionResult IssueLogGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_IssueLogManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/IssueCode/Get")]
        public ActionResult IssueCodeGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_IssueCodeManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/Issue/Get")]
        public ActionResult IssueGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_IssueManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/INVTransactionDetailSummary/Get")]
        public ActionResult INVTransactionDetailSummaryGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_INVTransactionDetailSummaryManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/INVTransactionDetailOnHandSummary/Get")]
        public ActionResult INVTransactionDetailOnHandSummaryGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_INVTransactionDetailOnHandSummaryManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/INVTransactionDetail/Get")]
        public ActionResult INVTransactionDetailGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_INVTransactionDetailManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/INVTransaction/Get")]
        public ActionResult INVTransactionGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_INVTransactionManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/INVRegister/Get")]
        public ActionResult INVRegisterGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_INVRegisterManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/InvoicesAndCharges/Get")]
        public ActionResult InvoicesAndChargesGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_InvoicesAndChargesManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/InvoiceDetail/Get")]
        public ActionResult InvoiceDetailGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_InvoiceDetailManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/InvoiceAmtSummary/Get")]
        public ActionResult InvoiceAmtSummaryGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_InvoiceAmtSummaryManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/Invoice/Get")]
        public ActionResult InvoiceGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_InvoiceManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/INVLotSerialTraceDetail/Get")]
        public ActionResult INVLotSerialTraceDetailGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_INVLotSerialTraceDetailManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/INVLotSerialTrace/Get")]
        public ActionResult INVLotSerialTraceGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_INVLotSerialTraceManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/InventoryJournalSummary/Get")]
        public ActionResult InventoryJournalSummaryGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_InventoryJournalSummaryManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/InventoryJournalDetail_NoAccounts/Get")]
        public ActionResult InventoryJournalDetail_NoAccountsGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_InventoryJournalDetail_NoAccountsManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/InventoryJournalDetail/Get")]
        public ActionResult InventoryJournalDetailGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_InventoryJournalDetailManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/InventoryJournal/Get")]
        public ActionResult InventoryJournalGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_InventoryJournalManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/ImportTransformation/Get")]
        public ActionResult ImportTransformationGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_ImportTransformationManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/ImportTemplateOptions/Get")]
        public ActionResult ImportTemplateOptionsGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_ImportTemplateOptionsManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/ImportTable/Get")]
        public ActionResult ImportTableGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_ImportTableManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/ImportSourceRelateFields/Get")]
        public ActionResult ImportSourceRelateFieldsGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_ImportSourceRelateFieldsManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/ImportSourceFile/Get")]
        public ActionResult ImportSourceFileGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_ImportSourceFileManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/ImportSourceFields/Get")]
        public ActionResult ImportSourceFieldsGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_ImportSourceFieldsManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/ImportSkipped/Get")]
        public ActionResult ImportSkippedGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_ImportSkippedManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/ImportNamespace/Get")]
        public ActionResult ImportNamespaceGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_ImportNamespaceManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/ImportMap/Get")]
        public ActionResult ImportMapGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_ImportMapManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/ImportErrors/Get")]
        public ActionResult ImportErrorsGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_ImportErrorsManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/ImportDefaultTable/Get")]
        public ActionResult ImportDefaultTableGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_IImportDefaultTableManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/ImportDefaultSourceFields/Get")]
        public ActionResult ImportDefaultSourceFieldsGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_ImportDefaultSourceFieldsManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/ImportDefaultNamespace/Get")]
        public ActionResult ImportDefaultNamespaceGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_ImportDefaultNamespaceManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/ImportDefaultMap/Get")]
        public ActionResult ImportDefaultMapGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_ImportDefaultMapManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/ImportDefaultConversion/Get")]
        public ActionResult ImportDefaultConversionGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_ImportDefaultConversionManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/ImportConversion/Get")]
        public ActionResult ImportConversionGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_ImportConversionManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/Import/Get")]
        public ActionResult ImportGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_ImportManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/ImpExpDocumentType/Get")]
        public ActionResult ImpExpDocumentTypeGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_ImpExpDocumentTypeManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/ImpExpDocumentTable/Get")]
        public ActionResult ImpExpDocumentTableGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_ImpExpDocumentTableManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/ImpExpDocumentColumn/Get")]
        public ActionResult ImpExpDocumentColumnGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_ImpExpDocumentColumnManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/GLAccountSegment/Get")]
        public ActionResult GLAccountSegmentGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_GLAccountSegmentManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/GLAccount/Get")]
        public ActionResult GLAccountGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_GLAccountManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/FlattenedKitComponents/Get")]
        public ActionResult FlattenedKitComponentsGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_FlattenedKitComponentsManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/FIFOCostLayers/Get")]
        public ActionResult FIFOCostLayersGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_FIFOCostLayersManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/Employee/Get")]
        public ActionResult EmployeeGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_EmployeeManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/EDIOrdersEx/Get")]
        public ActionResult EDIOrdersExGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_EDIOrdersExManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/EDIOrderDetailEx/Get")]
        public ActionResult EDIOrderDetailExGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_EDIOrderDetailExManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/EDIAdditionalInformation/Get")]
        public ActionResult EDIAdditionalInformationGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_EDIAdditionalInformationManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/Document/Get")]
        public ActionResult DocumentGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_DocumentManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvVendorRequestForQuotes/Get")]
        public ActionResult cvVendorRequestForQuotesGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvVendorRequestForQuotesManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvTrxDetailControlValues/Get")]
        public ActionResult cvTrxDetailControlValuesGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvTrxDetailControlValuesManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvTrxDetailControlSeries/Get")]
        public ActionResult cvTrxDetailControlSeriesGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvTrxDetailControlSeriesManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvSuppManufactureYield/Get")]
        public ActionResult cvSuppManufactureYieldGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvSuppManufactureYieldManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvSuppManufacture/Get")]
        public ActionResult cvSuppManufactureGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvSuppManufactureManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvRoleAccess/Get")]
        public ActionResult cvRoleAccessGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvRoleAccessManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvReceivingLog/Get")]
        public ActionResult cvReceivingLogGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvReceivingLogManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvReceiptTransactionDetail/Get")]
        public ActionResult cvReceiptTransactionDetailGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvReceiptTransactionDetailManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvProductVendorPrice/Get")]
        public ActionResult cvProductVendorPriceGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvProductVendorPriceManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvProductSpecAssemblies/Get")]
        public ActionResult cvProductSpecAssembliesGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvProductSpecAssembliesManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvProductQC/Get")]
        public ActionResult cvProductQCGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvProductQCManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvProductPurchaseUnitConversion/Get")]
        public ActionResult cvProductPurchaseUnitConversionGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvProductPurchaseUnitConversionManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvProductProc/Get")]
        public ActionResult cvProductProcGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvProductProcManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvProductPackaging/Get")]
        public ActionResult cvProductPackagingGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvProductPackagingManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvProductPackageUnitConversion/Get")]
        public ActionResult cvProductPackageUnitConversionGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvProductPackageUnitConversionManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvProductMetrics/Get")]
        public ActionResult cvProductMetricsGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvProductMetricsManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvProductLocationSummary/Get")]
        public ActionResult cvProductLocationSummaryGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvProductLocationSummaryManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvProductIngredientNSS/Get")]
        public ActionResult cvProductIngredientNSSGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvProductIngredientNSSManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvProductFinishedNSS/Get")]
        public ActionResult cvProductFinishedNSSGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvProductFinishedNSSManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvProductExportNSS/Get")]
        public ActionResult cvProductExportNSSGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvProductExportNSSManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvProductBatch/Get")]
        public ActionResult cvProductBatchGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvProductBatchManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvProductAvailability/Get")]
        public ActionResult cvProductAvailabilityGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvProductAvailabilityManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvProduct/Get")]
        public ActionResult cvProductGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvproductManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvPriorPOForProduct/Get")]
        public ActionResult cvPriorPOForProductGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvPriorPOForProductManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvPOReceiptsAssyNeeded/Get")]
        public ActionResult cvPOReceiptsAssyNeededGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvPOReceiptsAssyNeededManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvPOReceipt/Get")]
        public ActionResult cvPOReceiptGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvPOReceiptManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvPODetWithReceiptsAssyNeeded/Get")]
        public ActionResult cvPODetWithReceiptsAssyNeededGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvPODetWithReceiptsAssyNeededManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvPODetWhereUsed/Get")]
        public ActionResult cvPODetWhereUsedGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvPODetWhereUsedManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvOrderDetTranslation/Get")]
        public ActionResult cvOrderDetTranslationGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvOrderDetTranslationManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvOptionType/Get")]
        public ActionResult cvOptionTypeGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvOptionTypeManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvOptions/Get")]
        public ActionResult cvOptionsGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvOptionsManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvOptionGroup/Get")]
        public ActionResult cvOptionGroupGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvOptionGroupManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvNegativeLotLocationNAHS/Get")]
        public ActionResult cvNegativeLotLocationNAHSGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvNegativeLotLocationNAHSManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvNegativeLotLocation/Get")]
        public ActionResult cvNegativeLotLocationGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvNegativeLotLocationManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvLotSerialLocationSummary/Get")]
        public ActionResult cvLotSerialLocationSummaryGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvLotSerialLocationSummaryManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvLocationSummary/Get")]
        public ActionResult cvLocationSummaryGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvLocationSummaryManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvLinkProductSelector/Get")]
        public ActionResult cvLinkProductSelectorGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvLinkProductSelectorManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }   

        [HttpPost]
        [Route("/api/Full/cvLinkConfigXref/Get")]
        public ActionResult cvLinkConfigXrefGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvLinkConfigXrefManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvLinkConfigReports/Get")]
        public ActionResult cvLinkConfigReportsGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvLinkConfigLabelsManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvLinkConfigLabels/Get")]
        public ActionResult cvLinkConfigLabelsGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvLinkConfigLabelsManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvLinkConfigGuides/Get")]
        public ActionResult cvLinkConfigGuidesGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvLinkConfigGuidesManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvLinkConfigDocuments/Get")]
        public ActionResult cvLinkConfigDocumentsGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvLinkConfigDocumentsManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvLinkConfigDocumentFolders/Get")]
        public ActionResult cvLinkConfigDocumentFoldersGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvLinkConfigDocumentFoldersManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvLinkConfig/Get")]
        public ActionResult cvLinkConfigGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvLinkConfigManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvLastPOForProduct/Get")]
        public ActionResult cvLastPOForProductGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvLastPOForProductManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvIssueViewersParentAssembly/Get")]
        public ActionResult cvIssueViewersParentAssemblyGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvIssueViewersParentAssemblyManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvIssueViewersAssemblies/Get")]
        public ActionResult cvIssueViewersAssembliesGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvIssueViewersAssembliesManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvIssueViewers/Get")]
        public ActionResult cvIssueViewersGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvIssueViewersManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvIssuesForWarehouse/Get")]
        public ActionResult cvIssuesForWarehouseGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvIssuesForWarehouseManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvIssuesForMfg/Get")]
        public ActionResult cvIssuesForMfgGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvIssuesForMfgManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvIssueAssembly/Get")]
        public ActionResult cvIssueAssemblyGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvIssueAssemblyManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvIssue/Get")]
        public ActionResult cvIssueGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvIssueManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvINVTransferDetails/Get")]
        public ActionResult cvINVTransferDetailsGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvINVTransferDetailsManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvINVTransactionDetailCrystalControl/Get")]
        public ActionResult cvINVTransactionDetailCrystalControlGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvINVTransactionDetailCrystalControlManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvInvoiceBalance/Get")]
        public ActionResult cvInvoiceBalanceGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvInvoiceBalanceManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvInventoryTransfers/Get")]
        public ActionResult cvInventoryTransfersGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvInventoryTransfersManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvInventorySerialLotSummaryTransactions/Get")]
        public ActionResult cvInventorySerialLotSummaryTransactionsGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvInventorySerialLotSummaryTransactionsManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvIngredientClaimActivities/Get")]
        public ActionResult cvIngredientClaimActivitiesGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvIngredientClaimActivitiesManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvIncomingQCTemplate/Get")]
        public ActionResult cvIncomingQCTemplateGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvIncomingQCTemplateManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvIncomingInspectionBOM/Get")]
        public ActionResult cvIncomingInspectionBOMGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvIncomingInspectionBOMManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvCustomerContactCleanPhone/Get")]
        public ActionResult cvCustomerContactCleanPhoneGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvCustomerContactCleanPhoneManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvBorsightTransfersForAssemblies/Get")]
        public ActionResult cvBorsightTransfersForAssembliesGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvBorsightTransfersForAssembliesManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvAssemblyUnallocatedComponents/Get")]
        public ActionResult cvAssemblyUnallocatedComponentsGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvAssemblyUnallocatedComponentsManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvAssemblySessions/Get")]
        public ActionResult cvAssemblySessionsGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvAssemblySessionsManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvAssemblyProductLabel/Get")]
        public ActionResult cvAssemblyProductLabelGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvAssemblyProductLabelManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvAssemblyProductionReport/Get")]
        public ActionResult cvAssemblyProductionReportGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvAssemblyProductionReportManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvAssemblyProductionPassFail/Get")]
        public ActionResult cvAssemblyProductionPassFailGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvAssemblyProductionPassFailManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvAssemblyParentComponent/Get")]
        public ActionResult cvAssemblyParentComponentGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvAssemblyParentComponentManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvAssemblyParent/Get")]
        public ActionResult cvAssemblyParentGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvAssemblyParentManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvAssemblyOrdersExtended/Get")]
        public ActionResult cvAssemblyOrdersExtendedGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvAssemblyOrdersExtendedManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvAssemblyOrders/Get")]
        public ActionResult cvAssemblyOrdersGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvAssemblyOrdersManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvAssemblyOrderPackaging/Get")]
        public ActionResult cvAssemblyOrderPackagingGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvAssemblyOrderPackagingManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvAssemblyOrderMembers/Get")]
        public ActionResult cvAssemblyOrderMembersGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvAssemblyOrderMembersManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvAssemblyOrderHeader/Get")]
        public ActionResult cvAssemblyOrderHeaderGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvAssemblyOrderHeaderManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvAssemblyOrderDetailSummary/Get")]
        public ActionResult cvAssemblyOrderDetailSummaryGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvAssemblyOrderDetailSummaryManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvAssemblyOrderDetailStats/Get")]
        public ActionResult cvAssemblyOrderDetailStatsGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvAssemblyOrderDetailStatsManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvAssemblyOrderDetail/Get")]
        public ActionResult cvAssemblyOrderDetailGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvAssemblyOrderDetManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvAssemblyOrderDet/Get")]
        public ActionResult cvAssemblyOrderDetGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvAssemblyOrderDetManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvAssemblyComponentLotAvailability/Get")]
        public ActionResult cvAssemblyComponentLotAvailabilityGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvAssemblyComponentLotAvailabilityManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvAssemblyComponentAvailability/Get")]
        public ActionResult cvAssemblyComponentAvailabilityGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvAssemblyComponentAvailabilityManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvAccessGroupUsers/Get")]
        public ActionResult cvAccessGroupUsersGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvAccessGroupUsersManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvAccessGroup/Get")]
        public ActionResult cvAccessGroupGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_cvAccessGroupManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomField/Get")]
        public ActionResult CustomFieldGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomFeildManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomerView/Get")]
        public ActionResult CustomerViewGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomerViewManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomerTypeInfo/Get")]
        public ActionResult CustomerTypeInfoGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomerTypeInfoManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomerStatement/Get")]
        public ActionResult CustomerStatementGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomerStatementManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomerShipView/Get")]
        public ActionResult CustomerShipViewGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomerShipViewManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomerShipToInfo/Get")]
        public ActionResult CustomerShipToInfoGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomerShipToInfoManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomerShip/Get")]
        public ActionResult CustomerShipGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomerShipManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomerProduct/Get")]
        public ActionResult CustomerProductGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomerProductManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomerPaymentView/Get")]
        public ActionResult CustomerPaymentViewGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomerPaymentViewManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomerPaymentTotal/Get")]
        public ActionResult CustomerPaymentTotalGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomerPaymentTotalManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomerPaymentInvoiceTotal/Get")]
        public ActionResult CustomerPaymentInvoiceTotalGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomerPaymentInvoiceTotalManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomerPaymentInvoice/Get")]
        public ActionResult CustomerPaymentInvoiceGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomerPaymentInvoiceManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomerPaymentChargeTotal/Get")]
        public ActionResult CustomerPaymentChargeTotalGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomerPaymentChargeTotalManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomerPaymentAppliedTotal/Get")]
        public ActionResult CustomerPaymentAppliedTotalGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomerPaymentAppliedTotalManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomerPayment/Get")]
        public ActionResult CustomerPaymentGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomerPaymentManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomerMarketingListXref/Get")]
        public ActionResult CustomerMarketingListXrefGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomerMarketingListXrefManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomerInvoiceTotal/Get")]
        public ActionResult CustomerInvoiceTotalGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomerInvoiceTotalManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomerInfo/Get")]
        public ActionResult CustomerInfoGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomerInfoManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomerFullName/Get")]
        public ActionResult CustomerFullNameGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomerFullNameManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomerExport/Get")]
        public ActionResult CustomerExportGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomerExportManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/ProductComponent/Get")]
        public ActionResult ProductComponentGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_ProductComponentManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomerEmailAddressList/Get")]
        public ActionResult CustomerEmailAddressListGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomerEmailAddressListManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomerCreditStatus/Get")]
        public ActionResult CustomerCreditStatusGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomerCreditStatusManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomerContract/Get")]
        public ActionResult CustomerContractGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomerContractManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomerContact/Get")]
        public ActionResult CustomerContactGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomerContactDataAccess.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomerChargeTotal/Get")]
        public ActionResult CustomerChargeTotalGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomerChargeTotalDataAccess.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomerBalance/Get")]
        public ActionResult CustomerBalanceGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomerBalanceManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/Customer/Get")]
        public ActionResult CustomerGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomerManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CustomDataList/Get")]
        public ActionResult CustomDataListGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CustomDataListManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/Currency/Get")]
        public ActionResult CurrencyGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CurrencyManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CostLayers/Get")]
        public ActionResult CostLayers_Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CostLayersManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CostLayerReceipts/Get")]
        public ActionResult CostLayerReceipts_Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CostLayerReceiptsManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CvInventoryTransfersRepeater/Get")]
        public ActionResult CvInventoryTransfersRepeater_Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CvInventoryTransfersRepeaterManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CvAssemblyProductionRecord/Get")]
        public ActionResult CvAssemblyProductionRecord_Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CvAssemblyProductionRecordManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/cvAssemblyDocumentMembers/Get")]
        public ActionResult CvAssemblyDocumentMembers_Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CvAssemblyDocumentMembersManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CvAssemblyCustomerOrder/Get")]
        public ActionResult CvAssemblyCustomerOrder_Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CvAssemblyCustomerOrderManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CvAssemblies/Get")]
        public ActionResult CvAssembliesGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CvAssembliesManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/Access/Get")]
        public ActionResult AccessGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_AccessManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CvAssemblyDetails/Get")]
        public ActionResult CvAssemblyDetailsGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CvAssemblyDetailsManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/AccessPermission/Get")]
        public ActionResult AccessPermissionGet(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_AccessPermissionManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }


        [HttpPost]
        [Route("/api/Full/AccessPermissionMaster/Get")]
        public ActionResult AccessPermissionMaster_Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(__AccessPermissionMasterManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/Branch/Get")]
        public ActionResult Branch_Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_BranchManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/BusinessActivityHistory/Get")]
        public ActionResult BusinessActivityHistory_Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_BusinessActivityHistoryManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/BusinessActivity/Get")]
        public ActionResult BusinessActivity_Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_BusinessActivityManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/BusinessActivityRelatedItems/Get")]
        public ActionResult BusinessActivityRelatedItems_Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_BusinessActivityRelatedItemsManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/BusinessActivityTimeAndMaterials/Get")]
        public ActionResult BusinessActivityTimeAndMaterials_Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_BusinessActivityTimeAndMaterialsManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/Carrier/Get")]
        public ActionResult Carrier_Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CarrierManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CarrierBillingOptions/Get")]
        public ActionResult CarrierBillingOptions_Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CarrierBillingOptionsManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CarrierInsuranceOptions/Get")]
        public ActionResult CarrierInsuranceOptions_Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CarrierInsuranceOptionsManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CarrierService/Get")]
        public ActionResult CarrierService_Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CarrierServiceManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CarrierVoidOptions/Get")]
        public ActionResult CarrierVoidOptions_Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CarrierVoidOptionsManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/Charge/Get")]
        public ActionResult Charge_Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_ChargeManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/Class/Get")]
        public ActionResult Class_Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_ClassManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/ContractType/Get")]
        public ActionResult ContractType_Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_ContractTypeManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/CostLayerIssues/Get")]
        public ActionResult CostLayerIssues_Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_CostLayerIssues.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
