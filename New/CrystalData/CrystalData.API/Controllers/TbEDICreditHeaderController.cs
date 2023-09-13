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
    public class TbEDICreditHeaderController : ControllerBase
    {
        ITbEDICreditHeaderManager _TbEDICreditHeaderManager { get; set; }

        public TbEDICreditHeaderController(ITbEDICreditHeaderManager TbEDICreditHeaderManager)
        {
            _TbEDICreditHeaderManager = TbEDICreditHeaderManager;
        }

        [HttpPost]
        [Route("/api/Full/TbEDICreditHeader/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbEDICreditHeaderManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbEDICreditHeader/Add")]
        public ActionResult Add(tbEDICreditHeaderModel model)
        {
            try
            {
                return Ok(_TbEDICreditHeaderManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbEDICreditHeader/Update")]
        public ActionResult Update(Int32 PKIDEDICreditHeader, tbEDICreditHeaderModel model)
        {
            try
            {
                return Ok(_TbEDICreditHeaderManager.Update(PKIDEDICreditHeader, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbEDICreditHeader/HardDelete")]
        public ActionResult HardDelete(Int32 PKIDEDICreditHeader)
        {
            try
            {
                return Ok(_TbEDICreditHeaderManager.HardDelete(PKIDEDICreditHeader));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
