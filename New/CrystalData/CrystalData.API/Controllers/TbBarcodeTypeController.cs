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
    public class TbBarcodeTypeController : ControllerBase
    {
        ITbBarcodeTypeManager _TbBarcodeTypeManager { get; set; }

        public TbBarcodeTypeController(ITbBarcodeTypeManager TbBarcodeTypeManager)
        {
            _TbBarcodeTypeManager = TbBarcodeTypeManager;
        }

        [HttpPost]
        [Route("/api/Full/TbBarcodeType/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbBarcodeTypeManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbBarcodeType/Add")]
        public ActionResult Add(tbBarcodeTypeModel model)
        {
            try
            {
                return Ok(_TbBarcodeTypeManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbBarcodeType/Update")]
        public ActionResult Update(string BarcodeTypeID, tbBarcodeTypeModel model)
        {
            try
            {
                return Ok(_TbBarcodeTypeManager.Update(BarcodeTypeID, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbBarcodeType/HardDelete")]
        public ActionResult HardDelete(string BarcodeTypeID)
        {
            try
            {
                return Ok(_TbBarcodeTypeManager.HardDelete(BarcodeTypeID));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
