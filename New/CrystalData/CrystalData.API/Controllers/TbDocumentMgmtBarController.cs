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
    public class TbDocumentMgmtBarController : ControllerBase
    {
        ITbDocumentMgmtBarManager _TbDocumentMgmtBarManager { get; set; }

        public TbDocumentMgmtBarController(ITbDocumentMgmtBarManager TbDocumentMgmtBarManager)
        {
            _TbDocumentMgmtBarManager = TbDocumentMgmtBarManager;
        }

        [HttpPost]
        [Route("/api/Full/TbDocumentMgmtBar/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbDocumentMgmtBarManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbDocumentMgmtBar/Add")]
        public ActionResult Add(tbDocumentMgmtBarModel model)
        {
            try
            {
                return Ok(_TbDocumentMgmtBarManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbDocumentMgmtBar/Update")]
        public ActionResult Update(Guid GUIDDocumentMgmtBar, tbDocumentMgmtBarModel model)
        {
            try
            {
                return Ok(_TbDocumentMgmtBarManager.Update(GUIDDocumentMgmtBar, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbDocumentMgmtBar/HardDelete")]
        public ActionResult HardDelete(Guid GUIDDocumentMgmtBar)
        {
            try
            {
                return Ok(_TbDocumentMgmtBarManager.HardDelete(GUIDDocumentMgmtBar));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
