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
    public class TbBranchController : ControllerBase
    {
        ITbBranchManager _TbBranchManager { get; set; }

        public TbBranchController(ITbBranchManager TbBranchManager)
        {
            _TbBranchManager = TbBranchManager;
        }

        [HttpPost]
        [Route("/api/Full/TbBranch/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbBranchManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbBranch/Add")]
        public ActionResult Add(tbBranchModel model)
        {
            try
            {
                return Ok(_TbBranchManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbBranch/Update")]
        public ActionResult Update(Guid GUIDBranch, tbBranchModel model)
        {
            try
            {
                return Ok(_TbBranchManager.Update(GUIDBranch, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbBranch/HardDelete")]
        public ActionResult HardDelete(Guid GUIDBranch)
        {
            try
            {
                return Ok(_TbBranchManager.HardDelete(GUIDBranch));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
