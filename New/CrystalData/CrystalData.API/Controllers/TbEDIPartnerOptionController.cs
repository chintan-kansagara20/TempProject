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
    public class TbEDIPartnerOptionController : ControllerBase
    {
        ITbEDIPartnerOptionManager _TbEDIPartnerOptionManager { get; set; }

        public TbEDIPartnerOptionController(ITbEDIPartnerOptionManager TbEDIPartnerOptionManager)
        {
            _TbEDIPartnerOptionManager = TbEDIPartnerOptionManager;
        }

        [HttpPost]
        [Route("/api/Full/TbEDIPartnerOption/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbEDIPartnerOptionManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbEDIPartnerOption/Add")]
        public ActionResult Add(tbEDIPartnerOptionModel model)
        {
            try
            {
                return Ok(_TbEDIPartnerOptionManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbEDIPartnerOption/Update")]
        public ActionResult Update(Guid GUIDPartnerOption, tbEDIPartnerOptionModel model)
        {
            try
            {
                return Ok(_TbEDIPartnerOptionManager.Update(GUIDPartnerOption, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbEDIPartnerOption/HardDelete")]
        public ActionResult HardDelete(Guid GUIDPartnerOption)
        {
            try
            {
                return Ok(_TbEDIPartnerOptionManager.HardDelete(GUIDPartnerOption));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
