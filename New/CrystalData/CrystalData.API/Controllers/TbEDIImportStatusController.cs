using AuthLayer.Utility;
using CrystalData.Manager.Interface;
using CrystalData.Models;
using EasyCrudLibrary.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CrystalData.API.Controllers
{
    public class TbEDIImportStatusController : ControllerBase
    {
        ITbEDIImportStatusManager _TbEDIImportStatusManager { get; set; }

        public TbEDIImportStatusController(ITbEDIImportStatusManager TbEDIImportStatusManager)
        {
            _TbEDIImportStatusManager = TbEDIImportStatusManager;
        }

        [HttpPost]
        [Route("/api/Full/TbEDIImportStatus/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbEDIImportStatusManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbEDIImportStatus/Add")]
        public ActionResult Add(tbEDIImportStatusModel model)
        {
            try
            {
                return Ok(_TbEDIImportStatusManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbEDIImportStatus/Update")]
        public ActionResult Update(Int32 PKIDEDIImportStatus, tbEDIImportStatusModel model)
        {
            try
            {
                return Ok(_TbEDIImportStatusManager.Update(PKIDEDIImportStatus, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbEDIImportStatus/HardDelete")]
        public ActionResult HardDelete(Int32 PKIDEDIImportStatus)
        {
            try
            {
                return Ok(_TbEDIImportStatusManager.HardDelete(PKIDEDIImportStatus));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
