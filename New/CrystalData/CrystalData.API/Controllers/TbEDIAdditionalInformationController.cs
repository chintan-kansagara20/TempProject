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
    public class TbEDIAdditionalInformationController : ControllerBase
    {
        ITbEDIAdditionalInformationManager _TbEDIAdditionalInformationManager { get; set; }

        public TbEDIAdditionalInformationController(ITbEDIAdditionalInformationManager TbEDIAdditionalInformationManager)
        {
            _TbEDIAdditionalInformationManager = TbEDIAdditionalInformationManager;
        }

        [HttpPost]
        [Route("/api/Full/TbEDIAdditionalInformation/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbEDIAdditionalInformationManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbEDIAdditionalInformation/Add")]
        public ActionResult Add(tbEDIAdditionalInformationModel model)
        {
            try
            {
                return Ok(_TbEDIAdditionalInformationManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbEDIAdditionalInformation/Update")]
        public ActionResult Update(Guid GUIDAdditionalInformation, tbEDIAdditionalInformationModel model)
        {
            try
            {
                return Ok(_TbEDIAdditionalInformationManager.Update(GUIDAdditionalInformation, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbEDIAdditionalInformation/HardDelete")]
        public ActionResult HardDelete(Guid GUIDAdditionalInformation)
        {
            try
            {
                return Ok(_TbEDIAdditionalInformationManager.HardDelete(GUIDAdditionalInformation));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
