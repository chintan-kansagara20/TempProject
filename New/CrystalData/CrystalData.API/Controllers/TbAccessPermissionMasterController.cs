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
    public class TbAccessPermissionMasterController : ControllerBase
    {
        ITbAccessPermissionMasterManager _TbAccessPermissionMasterManager { get; set; }

        public TbAccessPermissionMasterController(ITbAccessPermissionMasterManager TbAccessPermissionMasterManager)
        {
            _TbAccessPermissionMasterManager = TbAccessPermissionMasterManager;
        }

        [HttpPost]
        [Route("/api/Full/TbAccessPermissionMaster/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbAccessPermissionMasterManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbAccessPermissionMaster/Add")]
        public ActionResult Add(tbAccessPermissionMasterModel model)
        {
            try
            {
                return Ok(_TbAccessPermissionMasterManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbAccessPermissionMaster/Update")]
        public ActionResult Update(string Permission, tbAccessPermissionMasterModel model)
        {
            try
            {
                return Ok(_TbAccessPermissionMasterManager.Update(Permission, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbAccessPermissionMaster/HardDelete")]
        public ActionResult HardDelete(string Permission)
        {
            try
            {
                return Ok(_TbAccessPermissionMasterManager.HardDelete(Permission));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
