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
    public class TbCustomerInfoController : ControllerBase
    {
        ITbCustomerInfoManager _TbCustomerInfoManager { get; set; }

        public TbCustomerInfoController(ITbCustomerInfoManager TbCustomerInfoManager)
        {
            _TbCustomerInfoManager = TbCustomerInfoManager;
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerInfo/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbCustomerInfoManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerInfo/Add")]
        public ActionResult Add(tbCustomerInfoModel model)
        {
            try
            {
                return Ok(_TbCustomerInfoManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerInfo/Update")]
        public ActionResult Update(Guid GUIDCustomer, tbCustomerInfoModel model)
        {
            try
            {
                return Ok(_TbCustomerInfoManager.Update(GUIDCustomer, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbCustomerInfo/HardDelete")]
        public ActionResult HardDelete(Guid GUIDCustomer)
        {
            try
            {
                return Ok(_TbCustomerInfoManager.HardDelete(GUIDCustomer));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
