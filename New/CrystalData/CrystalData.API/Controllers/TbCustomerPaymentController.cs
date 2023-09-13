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
    public class TbCustomerPaymentController : ControllerBase
    {
        ITbCustomerPaymentManager _TbCustomerPaymentManager { get; set; }

        public TbCustomerPaymentController(ITbCustomerPaymentManager TbCustomerPaymentManager)
        {
            _TbCustomerPaymentManager = TbCustomerPaymentManager;
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerPayment/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbCustomerPaymentManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerPayment/Add")]
        public ActionResult Add(tbCustomerPaymentModel model)
        {
            try
            {
                return Ok(_TbCustomerPaymentManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerPayment/Update")]
        public ActionResult Update(Guid GUIDCustomerPayment, tbCustomerPaymentModel model)
        {
            try
            {
                return Ok(_TbCustomerPaymentManager.Update(GUIDCustomerPayment, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbCustomerPayment/HardDelete")]
        public ActionResult HardDelete(Guid GUIDCustomerPayment)
        {
            try
            {
                return Ok(_TbCustomerPaymentManager.HardDelete(GUIDCustomerPayment));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
