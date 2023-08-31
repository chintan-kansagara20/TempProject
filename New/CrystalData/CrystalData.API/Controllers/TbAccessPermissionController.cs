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
    public class TbAccessPermissionController : ControllerBase
    {
       ITbAccessPermissionManager _TbAccessPermissionManager { get; set; }

        public TbAccessPermissionController(ITbAccessPermissionManager TbAccessPermissionManager)
        {
            _TbAccessPermissionManager = TbAccessPermissionManager;
        }

        [HttpPost]
        [Route("/api/Full/TbAccessPermission/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbAccessPermissionManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbAccessPermission/Add")]
        public ActionResult Add(tbAccessPermissionModel model)
        {
            try
            {
                return Ok(_TbAccessPermissionManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbAccessPermission/Update")]
        public ActionResult Update(Guid GUIDAccessPermission, tbAccessPermissionModel model)
        {
            try
            {
                return Ok(_TbAccessPermissionManager.Update(GUIDAccessPermission, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbAccessPermission/HardDelete")]
        public ActionResult HardDelete(Guid GUIDAccessPermission)
        {
            try
            {
                return Ok(_TbAccessPermissionManager.HardDelete(GUIDAccessPermission));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
