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
    public class TbCustomerMarketingListXrefController : ControllerBase
    {
        ITbCustomerMarketingListXrefManager _TbCustomerMarketingListXrefManager { get; set; }

        public TbCustomerMarketingListXrefController(ITbCustomerMarketingListXrefManager TbCustomerMarketingListXrefManager)
        {
            _TbCustomerMarketingListXrefManager = TbCustomerMarketingListXrefManager;
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerMarketingListXref/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbCustomerMarketingListXrefManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerMarketingListXref/Add")]
        public ActionResult Add(tbCustomerMarketingListXrefModel model)
        {
            try
            {
                return Ok(_TbCustomerMarketingListXrefManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerMarketingListXref/Update")]
        public ActionResult Update(Guid GUIDListXref, tbCustomerMarketingListXrefModel model)
        {
            try
            {
                return Ok(_TbCustomerMarketingListXrefManager.Update(GUIDListXref, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbCustomerMarketingListXref/HardDelete")]
        public ActionResult HardDelete(Guid GUIDListXref)
        {
            try
            {
                return Ok(_TbCustomerMarketingListXrefManager.HardDelete(GUIDListXref));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
