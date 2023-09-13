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
    public class TbDocumentController : ControllerBase
    {
        ITbDocumentManager _TbDocumentManager { get; set; }

        public TbDocumentController(ITbDocumentManager TbDocumentManager)
        {
            _TbDocumentManager = TbDocumentManager;
        }

        [HttpPost]
        [Route("/api/Full/TbDocument/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbDocumentManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbDocument/Add")]
        public ActionResult Add(tbDocumentModel model)
        {
            try
            {
                return Ok(_TbDocumentManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbDocument/Update")]
        public ActionResult Update(Guid GUIDDocument, tbDocumentModel model)
        {
            try
            {
                return Ok(_TbDocumentManager.Update(GUIDDocument, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbDocument/HardDelete")]
        public ActionResult HardDelete(Guid GUIDDocument)
        {
            try
            {
                return Ok(_TbDocumentManager.HardDelete(GUIDDocument));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
