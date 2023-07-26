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
    public class TbINVLotSerialController : ControllerBase
    {
        ITbINVLotSerialManager _TbINVLotSerialManager { get; set; }

        public TbINVLotSerialController(ITbINVLotSerialManager TbINVLotSerialManager)
        {
            _TbINVLotSerialManager = TbINVLotSerialManager;
        }

        [HttpPost]
        [Route("/api/Full/TbINVLotSerial/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbINVLotSerialManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbINVLotSerial/Add")]
        public ActionResult Add(tbINVLotSerialModel model)
        {
            try
            {
                return Ok(_TbINVLotSerialManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbINVLotSerial/Update")]
        public ActionResult Update(Guid GUIDINVLotSerial, tbINVLotSerialModel model)
        {
            try
            {
                return Ok(_TbINVLotSerialManager.Update(GUIDINVLotSerial, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }


        [HttpDelete]
        [Route("/api/Full/TbINVLotSerial/HardDelete")]
        public ActionResult HardDelete(Guid GUIDINVLotSerial)
        {
            try
            {
                return Ok(_TbINVLotSerialManager.HardDelete(GUIDINVLotSerial));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
