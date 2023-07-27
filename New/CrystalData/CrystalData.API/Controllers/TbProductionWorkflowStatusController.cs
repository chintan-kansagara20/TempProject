using AuthLayer.ActionFilters;
using AuthLayer.Utility;
using CrystalData.Manager.Impl;
using CrystalData.Manager.Interface;
using CrystalData.Models;
using EasyCrudLibrary.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CrystalData.API.Controllers
{
    [ApiController]
    [FullAuthorization]
    public class TbProductionWorkflowStatusController : ControllerBase
    {
        ITbProductionWorkflowStatusManager _TbProductionWorkflowStatusManager { get; set; }

        public TbProductionWorkflowStatusController(ITbProductionWorkflowStatusManager TbProductionWorkflowStatusManager)
        {
            _TbProductionWorkflowStatusManager = TbProductionWorkflowStatusManager;
        }

        [HttpPost]
        [Route("/api/Full/TbProductionWorkflowStatus/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbProductionWorkflowStatusManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbProductionWorkflowStatus/Add")]
        public ActionResult Add(tbProductionWorkflowStatusModel model)
        {
            try
            {
                return Ok(_TbProductionWorkflowStatusManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbProductionWorkflowStatus/Update")]
        public ActionResult Update(Guid GUIDProductionWorkflowStatus, tbProductionWorkflowStatusModel model)
        {
            try
            {
                return Ok(_TbProductionWorkflowStatusManager.Update(GUIDProductionWorkflowStatus, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbProductionWorkflowStatus/HardDelete")]
        public ActionResult HardDelete(Guid GUIDProductionWorkflowStatus)
        {
            try
            {
                return Ok(_TbProductionWorkflowStatusManager.HardDelete(GUIDProductionWorkflowStatus));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
