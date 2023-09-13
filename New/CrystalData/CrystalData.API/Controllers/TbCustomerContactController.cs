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
    public class TbCustomerContactController : ControllerBase
    {
        ITbCustomerContactManager _TbCustomerContactManager { get; set; }

        public TbCustomerContactController(ITbCustomerContactManager TbCustomerContactManager)
        {
            _TbCustomerContactManager = TbCustomerContactManager;
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerContact/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbCustomerContactManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerContact/Add")]
        public ActionResult Add(tbCustomerContactModel model)
        {
            try
            {
                return Ok(_TbCustomerContactManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerContact/Update")]
        public ActionResult Update(Guid GUIDCustomerContact, tbCustomerContactModel model)
        {
            try
            {
                return Ok(_TbCustomerContactManager.Update(GUIDCustomerContact, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbCustomerContact/HardDelete")]
        public ActionResult HardDelete(Guid GUIDCustomerContact)
        {
            try
            {
                return Ok(_TbCustomerContactManager.HardDelete(GUIDCustomerContact));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
