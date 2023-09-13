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
    public class TbCustomerShipController : ControllerBase
    {
        ITbCustomerShipManager _TbCustomerShipManager { get; set; }

        public TbCustomerShipController(ITbCustomerShipManager TbCustomerShipManager)
        {
            _TbCustomerShipManager = TbCustomerShipManager;
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerShip/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbCustomerShipManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerShip/Add")]
        public ActionResult Add(tbCustomerShipModel model)
        {
            try
            {
                return Ok(_TbCustomerShipManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerShip/Update")]
        public ActionResult Update(Guid GUIDLocation, tbCustomerShipModel model)
        {
            try
            {
                return Ok(_TbCustomerShipManager.Update(GUIDLocation, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbCustomerShip/HardDelete")]
        public ActionResult HardDelete(Guid GUIDLocation)
        {
            try
            {
                return Ok(_TbCustomerShipManager.HardDelete(GUIDLocation));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
