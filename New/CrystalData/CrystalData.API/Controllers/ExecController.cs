using AuthLayer.ActionFilters;
using AuthLayer.Utility;
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
        public ExecController(ICvAssembliesManager cvAssembliesManager, IAccessManager AccessManager, ICvAssemblyDetailsManager CvAssemblyDetailsManager, IAccessPermissionManager accessPermissionManager, IAccessPermissionMasterManager accessPermissionMasterManager, IBranchManager branchManager,IBusinessActivityHistoryManager businessActivityHistoryManager, IBusinessActivityManager businessActivityManager, IBusinessActivityRelatedItemsManager businessActivityRelatedItemsManager, IBusinessActivityTimeAndMaterialsManager businessActivityTimeAndMaterialsManager, ICarrierManager carrierManager, ICarrierBillingOptionsManager carrierBillingOptionsManager, ICarrierInsuranceOptionsManager carrierInsuranceOptionsManager)
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
    }
}
