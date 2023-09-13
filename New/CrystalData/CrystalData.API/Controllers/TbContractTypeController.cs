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
    public class TbContractTypeController : ControllerBase
    {
        ITbContractTypeManager _TbContractTypeManager { get; set; }

        public TbContractTypeController(ITbContractTypeManager TbContractTypeManager)
        {
            _TbContractTypeManager = TbContractTypeManager;
        }

        [HttpPost]
        [Route("/api/Full/TbContractType/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbContractTypeManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbContractType/Add")]
        public ActionResult Add(tbContractTypeModel model)
        {
            try
            {
                return Ok(_TbContractTypeManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbContractType/Update")]
        public ActionResult Update(Guid GUIDContractType, tbContractTypeModel model)
        {
            try
            {
                return Ok(_TbContractTypeManager.Update(GUIDContractType, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbContractType/HardDelete")]
        public ActionResult HardDelete(Guid GUIDContractType)
        {
            try
            {
                return Ok(_TbContractTypeManager.HardDelete(GUIDContractType));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
