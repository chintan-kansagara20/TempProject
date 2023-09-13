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
    public class TbActivityLogController : ControllerBase
    {
        ITbActivityLogManager _TbActivityLogManager { get; set; }

        public TbActivityLogController(ITbActivityLogManager TbActivityLogManager)
        {
            _TbActivityLogManager = TbActivityLogManager;
        }

        [HttpPost]
        [Route("/api/Full/TbActivityLog/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbActivityLogManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbActivityLog/Add")]
        public ActionResult Add(tbActivityLogModel model)
        {
            try
            {
                return Ok(_TbActivityLogManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbActivityLog/Update")]
        public ActionResult Update(Int32 PK, tbActivityLogModel model)
        {
            try
            {
                return Ok(_TbActivityLogManager.Update(PK, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbActivityLog/HardDelete")]
        public ActionResult HardDelete(Int32 PK)
        {
            try
            {
                return Ok(_TbActivityLogManager.HardDelete(PK));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
