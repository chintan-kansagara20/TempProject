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
    public class TbEDIImportLogManagerController : ControllerBase
    {
        ITbEDIImportLogManager _TbEDIImportLogManager { get; set; }

        public TbEDIImportLogManagerController(ITbEDIImportLogManager TbEDIImportLogManager)
        {
            _TbEDIImportLogManager = TbEDIImportLogManager;
        }

        [HttpPost]
        [Route("/api/Full/TbEDIImportLog/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbEDIImportLogManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbEDIImportLog/Add")]
        public ActionResult Add(tbEDIImportLogModel model)
        {
            try
            {
                return Ok(_TbEDIImportLogManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbEDIImportLog/Update")]
        public ActionResult Update(Int32 PKIDEDIImportLog, tbEDIImportLogModel model)
        {
            try
            {
                return Ok(_TbEDIImportLogManager.Update(PKIDEDIImportLog, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbEDIImportLog/HardDelete")]
        public ActionResult HardDelete(Int32 PKIDEDIImportLog)
        {
            try
            {
                return Ok(_TbEDIImportLogManager.HardDelete(PKIDEDIImportLog));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
