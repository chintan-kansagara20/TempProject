using AuthLayer.ActionFilters;
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
            IcvPODetWithReceiptsAssyNeededManager cvPODetWithReceiptsAssyNeededManager)

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
