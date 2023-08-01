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
    public class TbProductComponentController : ControllerBase
    {
        ITbProductComponentManager _TbProductComponentManager { get; set; }

        public TbProductComponentController(ITbProductComponentManager TbProductComponentManager)
        {
            _TbProductComponentManager = TbProductComponentManager;
        }

        [HttpPost]
        [Route("/api/Full/TbProductComponent/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbProductComponentManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbProductComponent/Add")]
        public ActionResult Add(tbProductComponentModel model)
        {
            try
            {
                return Ok(_TbProductComponentManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbProductComponent/Update")]
        public ActionResult Update(Guid GUIDProductComponent, tbProductComponentModel model)
        {
            try
            {
                return Ok(_TbProductComponentManager.Update(GUIDProductComponent, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbProductComponent/HardDelete")]
        public ActionResult HardDelete(Guid GUIDProductComponent)
        {
            try
            {
                return Ok(_TbProductComponentManager.HardDelete(GUIDProductComponent));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
