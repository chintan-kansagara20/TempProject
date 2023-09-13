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
    public class TbEDIOrderDetailExController : ControllerBase
    {
        ITbEDIOrderDetailExManager _TbEDIOrderDetailExManager { get; set; }

        public TbEDIOrderDetailExController(ITbEDIOrderDetailExManager TbEDIOrderDetailExManager)
        {
            _TbEDIOrderDetailExManager = TbEDIOrderDetailExManager;
        }

        [HttpPost]
        [Route("/api/Full/TbEDIOrderDetailEx/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbEDIOrderDetailExManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbEDIOrderDetailEx/Add")]
        public ActionResult Add(tbEDIOrderDetailExModel model)
        {
            try
            {
                return Ok(_TbEDIOrderDetailExManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbEDIOrderDetailEx/Update")]
        public ActionResult Update(Guid GUIDOrderDetail, tbEDIOrderDetailExModel model)
        {
            try
            {
                return Ok(_TbEDIOrderDetailExManager.Update(GUIDOrderDetail, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbEDIOrderDetailEx/HardDelete")]
        public ActionResult HardDelete(Guid GUIDOrderDetail)
        {
            try
            {
                return Ok(_TbEDIOrderDetailExManager.HardDelete(GUIDOrderDetail));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
