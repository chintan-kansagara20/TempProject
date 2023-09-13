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
    public class TbCustomerController : ControllerBase
    {
        ITbCustomerManager _TbCustomerManager { get; set; }

        public TbCustomerController(ITbCustomerManager TbCustomerManager)
        {
            _TbCustomerManager = TbCustomerManager;
        }

        [HttpPost]
        [Route("/api/Full/TbCustomer/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbCustomerManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCustomer/Add")]
        public ActionResult Add(tbCustomerModel model)
        {
            try
            {
                return Ok(_TbCustomerManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCustomer/Update")]
        public ActionResult Update(Guid GUIDCustomer, tbCustomerModel model)
        {
            try
            {
                return Ok(_TbCustomerManager.Update(GUIDCustomer, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbCustomer/HardDelete")]
        public ActionResult HardDelete(Guid GUIDCustomer)
        {
            try
            {
                return Ok(_TbCustomerManager.HardDelete(GUIDCustomer));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
