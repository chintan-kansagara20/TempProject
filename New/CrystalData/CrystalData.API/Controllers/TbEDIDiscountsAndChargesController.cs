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
    public class TbEDIDiscountsAndChargesController : ControllerBase
    {
        ITbEDIDiscountsAndChargesManager _TbEDIDiscountsAndChargesManager { get; set; }

        public TbEDIDiscountsAndChargesController(ITbEDIDiscountsAndChargesManager TbEDIDiscountsAndChargesManager)
        {
            _TbEDIDiscountsAndChargesManager = TbEDIDiscountsAndChargesManager;
        }

        [HttpPost]
        [Route("/api/Full/TbEDIDiscountsAndCharges/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbEDIDiscountsAndChargesManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbEDIDiscountsAndCharges/Add")]
        public ActionResult Add(tbEDIDiscountsAndChargesModel model)
        {
            try
            {
                return Ok(_TbEDIDiscountsAndChargesManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbEDIDiscountsAndCharges/Update")]
        public ActionResult Update(Guid GUIDDiscountsAndCharges, tbEDIDiscountsAndChargesModel model)
        {
            try
            {
                return Ok(_TbEDIDiscountsAndChargesManager.Update(GUIDDiscountsAndCharges, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbEDIDiscountsAndCharges/HardDelete")]
        public ActionResult HardDelete(Guid GUIDDiscountsAndCharges)
        {
            try
            {
                return Ok(_TbEDIDiscountsAndChargesManager.HardDelete(GUIDDiscountsAndCharges));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
