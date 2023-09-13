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
    public class TbEDIOrdersExController : ControllerBase
    {
        ITbEDIOrdersExManager _TbEDIOrdersExManager { get; set; }

        public TbEDIOrdersExController(ITbEDIOrdersExManager TbEDIOrdersExManager)
        {
            _TbEDIOrdersExManager = TbEDIOrdersExManager;
        }

        [HttpPost]
        [Route("/api/Full/TbEDIOrdersEx/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbEDIOrdersExManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbEDIOrdersEx/Add")]
        public ActionResult Add(tbEDIOrdersExModel model)
        {
            try
            {
                return Ok(_TbEDIOrdersExManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbEDIOrdersEx/Update")]
        public ActionResult Update(Guid GUIDOrder, tbEDIOrdersExModel model)
        {
            try
            {
                return Ok(_TbEDIOrdersExManager.Update(GUIDOrder, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbEDIOrdersEx/HardDelete")]
        public ActionResult HardDelete(Guid GUIDOrder)
        {
            try
            {
                return Ok(_TbEDIOrdersExManager.HardDelete(GUIDOrder));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
