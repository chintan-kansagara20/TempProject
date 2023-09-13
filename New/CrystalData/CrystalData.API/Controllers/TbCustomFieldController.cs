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
    public class TbCustomFieldController : ControllerBase
    {
        ITbCustomFieldManager _TbCustomFieldManager { get; set; }

        public TbCustomFieldController(ITbCustomFieldManager TbCustomFieldManager)
        {
            _TbCustomFieldManager = TbCustomFieldManager;
        }

        [HttpPost]
        [Route("/api/Full/TbCustomField/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbCustomFieldManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCustomField/Add")]
        public ActionResult Add(tbCustomFieldModel model)
        {
            try
            {
                return Ok(_TbCustomFieldManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCustomField/Update")]
        public ActionResult Update(string GUIDCustomField, tbCustomFieldModel model)
        {
            try
            {
                return Ok(_TbCustomFieldManager.Update(GUIDCustomField, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbCustomField/HardDelete")]
        public ActionResult HardDelete(string GUIDCustomField)
        {
            try
            {
                return Ok(_TbCustomFieldManager.HardDelete(GUIDCustomField));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
