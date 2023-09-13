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
    public class TbEDIPartnerTransactionController : ControllerBase
    {
        ITbEDIPartnerTransactionManager _TbEDIPartnerTransactionManager { get; set; }

        public TbEDIPartnerTransactionController(ITbEDIPartnerTransactionManager TbEDIPartnerTransactionManager)
        {
            _TbEDIPartnerTransactionManager = TbEDIPartnerTransactionManager;
        }

        [HttpPost]
        [Route("/api/Full/TbEDIPartnerTransaction/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbEDIPartnerTransactionManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbEDIPartnerTransaction/Add")]
        public ActionResult Add(tbEDIPartnerTransactionModel model)
        {
            try
            {
                return Ok(_TbEDIPartnerTransactionManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbEDIPartnerTransaction/Update")]
        public ActionResult Update(Guid GUIDPartnerTransaction, tbEDIPartnerTransactionModel model)
        {
            try
            {
                return Ok(_TbEDIPartnerTransactionManager.Update(GUIDPartnerTransaction, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbEDIPartnerTransaction/HardDelete")]
        public ActionResult HardDelete(Guid GUIDPartnerTransaction)
        {
            try
            {
                return Ok(_TbEDIPartnerTransactionManager.HardDelete(GUIDPartnerTransaction));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
