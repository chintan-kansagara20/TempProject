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
    public class TbChargeController : ControllerBase
    {
        ItbChargeManager _tbChargeManager { get; set; }

        public TbChargeController(ItbChargeManager tbChargeManager)
        {
            _tbChargeManager = tbChargeManager;
        }

        [HttpPost]
        [Route("/api/Full/TbCharge/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_tbChargeManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCharge/Add")]
        public ActionResult Add(tbChargeModel model)
        {
            try
            {
                return Ok(_tbChargeManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCharge/Update")]
        public ActionResult Update(Guid GUIDCharge, tbChargeModel model)
        {
            try
            {
                return Ok(_tbChargeManager.Update(GUIDCharge, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbCharge/HardDelete")]
        public ActionResult HardDelete(Guid GUIDCharge)
        {
            try
            {
                return Ok(_tbChargeManager.HardDelete(GUIDCharge));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
