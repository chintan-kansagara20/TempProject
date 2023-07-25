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
    public class ExecController : ControllerBase
    {
        ICvAssembliesManager _CvAssembliesManager { get; set; }
        IAccessManager _AccessManager { get; set; }
        IAccessPermissionManager _AccessPermissionManager { get; set; }
        public ExecController(ICvAssembliesManager cvAssembliesManager, IAccessManager AccessManager, IAccessPermissionManager accessPermissionManager)
        {
            _CvAssembliesManager = cvAssembliesManager;
            _AccessManager = AccessManager;
            _AccessPermissionManager = accessPermissionManager;
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
    }
}
