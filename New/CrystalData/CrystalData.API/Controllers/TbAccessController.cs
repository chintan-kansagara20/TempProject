using AuthLayer.ActionFilters;
using AuthLayer.Utility;
using CrystalData.Manager.Impl;
using CrystalData.Manager.Interface;
using CrystalData.Models;
using EasyCrudLibrary.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CrystalData.API.Controllers
{
    [ApiController]
    [FullAuthorization]
    public class TbAccessController : ControllerBase
    {
        ITbAccessManager _TbAccessManager { get; set; }

        public TbAccessController(ITbAccessManager TbAccessManager)
        {
            _TbAccessManager = TbAccessManager;
        }

        [HttpPost]
        [Route("/api/Full/TbAccess/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbAccessManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbAccess/Add")]
        public ActionResult Add(tbAccessModel model)
        {
            try
            {
                return Ok(_TbAccessManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbAccess/Update")]
        public ActionResult Update(Guid GUIDAccess, tbAccessModel model)
        {
            try
            {
                return Ok(_TbAccessManager.Update(GUIDAccess, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbAccess/HardDelete")]
        public ActionResult HardDelete(Guid GUIDAccess)
        {
            try
            {
                return Ok(_TbAccessManager.HardDelete(GUIDAccess));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
