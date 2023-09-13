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
    public class TbCustomerNotesController : ControllerBase
    {
        ITbCustomerNotesManager _TbCustomerNotesManager { get; set; }

        public TbCustomerNotesController(ITbCustomerNotesManager TbCustomerNotesManager)
        {
            _TbCustomerNotesManager = TbCustomerNotesManager;
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerNotes/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbCustomerNotesManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerNotes/Add")]
        public ActionResult Add(tbCustomerNotesModel model)
        {
            try
            {
                return Ok(_TbCustomerNotesManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerNotes/Update")]
        public ActionResult Update(Int32 PKIDCustomerNotes, tbCustomerNotesModel model)
        {
            try
            {
                return Ok(_TbCustomerNotesManager.Update(PKIDCustomerNotes, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbCustomerNotes/HardDelete")]
        public ActionResult HardDelete(Int32 PKIDCustomerNotes)
        {
            try
            {
                return Ok(_TbCustomerNotesManager.HardDelete(PKIDCustomerNotes));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
