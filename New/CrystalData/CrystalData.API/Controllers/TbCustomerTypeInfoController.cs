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
    public class TbCustomerTypeInfoController : Controller
    {
        ITbCustomerTypeInfoManager _TbCustomerTypeInfoManager { get; set; }

        public TbCustomerTypeInfoController(ITbCustomerTypeInfoManager TbCustomerTypeInfoManager)
        {
            _TbCustomerTypeInfoManager = TbCustomerTypeInfoManager;
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerTypeInfo/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbCustomerTypeInfoManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerTypeInfo/Add")]
        public ActionResult Add(tbCustomerTypeInfoModel model)
        {
            try
            {
                return Ok(_TbCustomerTypeInfoManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerTypeInfo/Update")]
        public ActionResult Update(Guid GUIDCustomerType, tbCustomerTypeInfoModel model)
        {
            try
            {
                return Ok(_TbCustomerTypeInfoManager.Update(GUIDCustomerType, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbCustomerTypeInfo/HardDelete")]
        public ActionResult HardDelete(Guid GUIDCustomerType)
        {
            try
            {
                return Ok(_TbCustomerTypeInfoManager.HardDelete(GUIDCustomerType));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
