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
    public class TbEDICreditDetailController : ControllerBase
    {
        ITbEDICreditDetailManager _TbEDICreditDetailManager { get; set; }

        public TbEDICreditDetailController(ITbEDICreditDetailManager TbEDICreditDetailManager)
        {
            _TbEDICreditDetailManager = TbEDICreditDetailManager;
        }

        [HttpPost]
        [Route("/api/Full/TbEDICreditDetail/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbEDICreditDetailManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbEDICreditDetail/Add")]
        public ActionResult Add(tbEDICreditDetailModel model)
        {
            try
            {
                return Ok(_TbEDICreditDetailManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbEDICreditDetail/Update")]
        public ActionResult Update(Int32 PKIDEDICreditDetail, tbEDICreditDetailModel model)
        {
            try
            {
                return Ok(_TbEDICreditDetailManager.Update(PKIDEDICreditDetail, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbEDICreditDetail/HardDelete")]
        public ActionResult HardDelete(Int32 PKIDEDICreditDetail)
        {
            try
            {
                return Ok(_TbEDICreditDetailManager.HardDelete(PKIDEDICreditDetail));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
