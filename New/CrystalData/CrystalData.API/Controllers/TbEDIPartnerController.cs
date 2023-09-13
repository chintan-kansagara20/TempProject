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
    public class TbEDIPartnerController : ControllerBase
    {
        ITbEDIPartnerManager _TbEDIPartnerManager { get; set; }

        public TbEDIPartnerController(ITbEDIPartnerManager TbEDIPartnerManager)
        {
            _TbEDIPartnerManager = TbEDIPartnerManager;
        }

        [HttpPost]
        [Route("/api/Full/TbEDIPartner/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbEDIPartnerManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbEDIPartner/Add")]
        public ActionResult Add(tbEDIPartnerModel model)
        {
            try
            {
                return Ok(_TbEDIPartnerManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbEDIPartner/Update")]
        public ActionResult Update(Guid GUIDPartner, tbEDIPartnerModel model)
        {
            try
            {
                return Ok(_TbEDIPartnerManager.Update(GUIDPartner, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbEDIPartner/HardDelete")]
        public ActionResult HardDelete(Guid GUIDPartner)
        {
            try
            {
                return Ok(_TbEDIPartnerManager.HardDelete(GUIDPartner));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
