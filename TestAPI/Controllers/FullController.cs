using AuthLayer.Utility;
using EasyCrudLibrary.Model;
using ManagersLayer.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Newtonsoft.Json;

namespace TestAPI.Controllers
{
    [ApiController]
    public class FullController : ControllerBase
    {
        ICvAssembliesManager _CvAssembliesManager { get; set; }
        ICvAssemblyCustomerOrderManager _CvAssemblyCustomerOrderManager { get; set; }
        ICvAssemblyDocumentMembersManager _CvAssemblyDocumentMembersManager { get; set; }
        ICvAssemblyProductionRecordManager _CvAssemblyProductionRecordManager { get;set; }
        ICvInventoryTransfersRepeaterManager _CvInventoryTransfersRepeaterManager { get; set; }
        IAccessManager _AccessManager { get; set; }
        IAccessPermissionManager _AccessPermissionManager { get; set; }
        IAccessPermissionMasterManager __AccessPermissionMasterManager { get; set; }
        IBranchManager _BranchManager { get; set; }
        IBusinessActivityManager _BusinessActivityManager { get; set; }
        IBusinessActivityHistoryManager _BusinessActivityHistoryManager { get; set; }
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
        public FullController(ICvAssembliesManager cvAssembliesManager, ICvAssemblyCustomerOrderManager CvAssemblyCustomerOrderManager, IAccessManager AccessManager, ICvAssemblyDocumentMembersManager cvAssemblyDocumentMembersManager, ICvAssemblyProductionRecordManager cvAssemblyProductionRecordManager, ICvInventoryTransfersRepeaterManager cvInventoryTransfersRepeaterManager, IAccessPermissionManager accessPermissionManager, IAccessPermissionMasterManager accessPermissionMasterManager, IBranchManager branchManager, IBusinessActivityManager businessActivityManager, IBusinessActivityHistoryManager businessActivityHistoryManager, IBusinessActivityRelatedItemsManager businessActivityRelatedItemsManager, IBusinessActivityTimeAndMaterialsManager businessActivityTimeAndMaterialsManager, ICarrierManager carrierManager, ICarrierBillingOptionsManager carrierBillingOptionsManager, ICarrierInsuranceOptionsManager carrierInsuranceOptionsManager, ICarrierServiceManager carrierServiceManager, ICarrierVoidOptionsManager carrierVoidOptionsManager, IChargeManager chargeManager, IClassManager classManager, IContractTypeManager contractTypeManager, ICostLayerIssuesManager costLayerIssues)
        {
            _CvAssembliesManager = cvAssembliesManager;
            _CvAssemblyCustomerOrderManager = CvAssemblyCustomerOrderManager;
            _CvAssemblyDocumentMembersManager = cvAssemblyDocumentMembersManager;
            _CvAssemblyProductionRecordManager = cvAssemblyProductionRecordManager;
            _CvInventoryTransfersRepeaterManager = cvInventoryTransfersRepeaterManager;
            _AccessManager = AccessManager;
            _AccessPermissionManager = accessPermissionManager;
            __AccessPermissionMasterManager = accessPermissionMasterManager;
            _BranchManager = branchManager;
            _BusinessActivityManager = businessActivityManager;
            _BusinessActivityHistoryManager = businessActivityHistoryManager;
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
        }

        [HttpPost]
        [Route("/api/Full/CvAssemblies/Get")]
        public ActionResult CvAssemblies_Get(FullGetModel model)
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
        [Route("/api/Full/Access/Get")]
        public ActionResult Access_Get(FullGetModel model)
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
        [Route("/api/Full/AccessPermission/Get")]
        public ActionResult AccessPermission_Get(FullGetModel model)
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
