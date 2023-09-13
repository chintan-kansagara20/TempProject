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
    public class TbCustomerPaymentInvoiceController : ControllerBase
    {
        ITbCustomerPaymentInvoiceManager _TbCustomerPaymentInvoiceManager { get; set; }

        public TbCustomerPaymentInvoiceController(ITbCustomerPaymentInvoiceManager TbCustomerPaymentInvoiceManager)
        {
            _TbCustomerPaymentInvoiceManager = TbCustomerPaymentInvoiceManager;
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerPaymentInvoice/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbCustomerPaymentInvoiceManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerPaymentInvoice/Add")]
        public ActionResult Add(tbCustomerPaymentInvoiceModel model)
        {
            try
            {
                return Ok(_TbCustomerPaymentInvoiceManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerPaymentInvoice/Update")]
        public ActionResult Update(Guid GUIDCustomerPaymentInvoice, tbCustomerPaymentInvoiceModel model)
        {
            try
            {
                return Ok(_TbCustomerPaymentInvoiceManager.Update(GUIDCustomerPaymentInvoice, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbCustomerPaymentInvoice/HardDelete")]
        public ActionResult HardDelete(Guid GUIDCustomerPaymentInvoice)
        {
            try
            {
                return Ok(_TbCustomerPaymentInvoiceManager.HardDelete(GUIDCustomerPaymentInvoice));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
