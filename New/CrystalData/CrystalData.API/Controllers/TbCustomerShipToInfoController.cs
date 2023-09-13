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
    public class TbCustomerShipToInfoController : ControllerBase
    {
        ITbCustomerShipToInfoManager _TbCustomerShipToInfoManager { get; set; }

        public TbCustomerShipToInfoController(ITbCustomerShipToInfoManager TbCustomerShipToInfoManager)
        {
            _TbCustomerShipToInfoManager = TbCustomerShipToInfoManager;
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerShipToInfo/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbCustomerShipToInfoManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerShipToInfo/Add")]
        public ActionResult Add(tbCustomerShipToInfoModel model)
        {
            try
            {
                return Ok(_TbCustomerShipToInfoManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerShipToInfo/Update")]
        public ActionResult Update(Guid GUIDLocation, tbCustomerShipToInfoModel model)
        {
            try
            {
                return Ok(_TbCustomerShipToInfoManager.Update(GUIDLocation, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbCustomerShipToInfo/HardDelete")]
        public ActionResult HardDelete(Guid GUIDLocation)
        {
            try
            {
                return Ok(_TbCustomerShipToInfoManager.HardDelete(GUIDLocation));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
