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
    public class TbCurrencyController : ControllerBase
    {
        ITbCurrencyManager _TbCurrencyManager { get; set; }

        public TbCurrencyController(ITbCurrencyManager TbCurrencyManager)
        {
            _TbCurrencyManager = TbCurrencyManager;
        }

        [HttpPost]
        [Route("/api/Full/TbCurrency/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbCurrencyManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCurrency/Add")]
        public ActionResult Add(tbCurrencyModel model)
        {
            try
            {
                return Ok(_TbCurrencyManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCurrency/Update")]
        public ActionResult Update(Guid GUIDCurrency, tbCurrencyModel model)
        {
            try
            {
                return Ok(_TbCurrencyManager.Update(GUIDCurrency, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbCurrency/HardDelete")]
        public ActionResult HardDelete(Guid GUIDCurrency)
        {
            try
            {
                return Ok(_TbCurrencyManager.HardDelete(GUIDCurrency));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
