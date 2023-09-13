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
    public class TbCarrierController : ControllerBase
    {
        ITbCarrierManager _TbCarrierManager { get; set; }

        public TbCarrierController(ITbCarrierManager TbCarrierManager)
        {
            _TbCarrierManager = TbCarrierManager;
        }

        [HttpPost]
        [Route("/api/Full/TbCarrier/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbCarrierManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCarrier/Add")]
        public ActionResult Add(tbCarrierModel model)
        {
            try
            {
                return Ok(_TbCarrierManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCarrier/Update")]
        public ActionResult Update(string Carrier, tbCarrierModel model)
        {
            try
            {
                return Ok(_TbCarrierManager.Update(Carrier, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbCarrier/HardDelete")]
        public ActionResult HardDelete(string Carrier)
        {
            try
            {
                return Ok(_TbCarrierManager.HardDelete(Carrier));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
