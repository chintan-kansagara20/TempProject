using AuthLayer.ActionFilters;
using AuthLayer.Utility;
using CrystalData.Manager.Interface;
using CrystalData.Models;
using EasyCrudLibrary.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CrystalData.API.Controllers
{
    [ApiController]
    [FullAuthorization]
    public class TbAccessPermissionGroupController : ControllerBase
    {

        ITbAccessPermissionGroupManager _TbAccessPermissionGroupManager { get; set; }

        public TbAccessPermissionGroupController(ITbAccessPermissionGroupManager TbAccessPermissionGroupManager)
        {
            _TbAccessPermissionGroupManager = TbAccessPermissionGroupManager;
        }

        [HttpPost]
        [Route("/api/Full/TbAccessPermissionGroup/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbAccessPermissionGroupManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbAccessPermissionGroup/Add")]
        public ActionResult Add(tbAccessPermissionGroupModel model)
        {
            try
            {
                return Ok(_TbAccessPermissionGroupManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbAccessPermissionGroup/Update")]
        public ActionResult Update(string PermissionGroup, tbAccessPermissionGroupModel model)
        {
            try
            {
                return Ok(_TbAccessPermissionGroupManager.Update(PermissionGroup, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbAccessPermissionGroup/HardDelete")]
        public ActionResult HardDelete(string PermissionGroup)
        {
            try
            {
                return Ok(_TbAccessPermissionGroupManager.HardDelete(PermissionGroup));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
