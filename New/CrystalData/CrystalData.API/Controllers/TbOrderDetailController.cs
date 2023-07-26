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
    public class TbOrderDetailController : ControllerBase
    {
        ITbOrderDetailManager _TbOrderDetailManager { get; set; }

        public TbOrderDetailController(ITbOrderDetailManager TbOrderDetailManager)
        {
            _TbOrderDetailManager = TbOrderDetailManager;
        }

        [HttpPost]
        [Route("/api/Full/TbOrderDetail/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbOrderDetailManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbOrderDetail/Add")]
        public ActionResult Add(tbOrderDetailModel model)
        {
            try
            {
                return Ok(_TbOrderDetailManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbOrderDetail/Update")]
        public ActionResult Update(Guid GUIDOrderDetail, tbOrderDetailModel model)
        {
            try
            {
                return Ok(_TbOrderDetailManager.Update(GUIDOrderDetail, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbOrderDetail/HardDelete")]
        public ActionResult HardDelete(Guid GUIDOrderDetail)
        {
            try
            {
                return Ok(_TbOrderDetailManager.HardDelete(GUIDOrderDetail));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
