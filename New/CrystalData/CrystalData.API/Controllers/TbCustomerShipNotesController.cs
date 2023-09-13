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
    public class TbCustomerShipNotesController : ControllerBase
    {
        ITbCustomerShipNotesManager _TbCustomerShipNotesManager { get; set; }

        public TbCustomerShipNotesController(ITbCustomerShipNotesManager TbCustomerShipNotesManager)
        {
            _TbCustomerShipNotesManager = TbCustomerShipNotesManager;
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerShipNotes/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbCustomerShipNotesManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerShipNotes/Add")]
        public ActionResult Add(tbCustomerShipNotesModel model)
        {
            try
            {
                return Ok(_TbCustomerShipNotesManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerShipNotes/Update")]
        public ActionResult Update(Guid GUIDLocation, tbCustomerShipNotesModel model)
        {
            try
            {
                return Ok(_TbCustomerShipNotesManager.Update(GUIDLocation, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbCustomerShipNotes/HardDelete")]
        public ActionResult HardDelete(Guid GUIDLocation)
        {
            try
            {
                return Ok(_TbCustomerShipNotesManager.HardDelete(GUIDLocation));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
