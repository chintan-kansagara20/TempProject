using AuthLayer.ActionFilters;
using AuthLayer.Utility;
using CrystalData.Manager.Impl;
using CrystalData.Manager.Interface;
using CrystalData.Models;
using EasyCrudLibrary.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CrystalData.API.Controllers
{
    [ApiController]
    [FullAuthorization]
    public class TbCustomerContractController : ControllerBase
    {
        ITbCustomerContractManager _TbCustomerContractManager { get; set; }

        public TbCustomerContractController(ITbCustomerContractManager TbCustomerContractManager)
        {
            _TbCustomerContractManager = TbCustomerContractManager;
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerContract/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbCustomerContractManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerContract/Add")]
        public ActionResult Add(tbCustomerContractModel model)
        {
            try
            {
                return Ok(_TbCustomerContractManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbCustomerContract/Update")]
        public ActionResult Update(Guid GUIDCustomerContract, tbCustomerContractModel model)
        {
            try
            {
                return Ok(_TbCustomerContractManager.Update(GUIDCustomerContract, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbCustomerContract/HardDelete")]
        public ActionResult HardDelete(Guid GUIDCustomerContract)
        {
            try
            {
                return Ok(_TbCustomerContractManager.HardDelete(GUIDCustomerContract));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
