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
    public class TbWarehouseController : ControllerBase
    {
        ITbWarehouseManager _TbWarehouseManager { get; set; }

        public TbWarehouseController(ITbWarehouseManager TbWarehouseManager)
        {
            _TbWarehouseManager = TbWarehouseManager;
        }

        [HttpPost]
        [Route("/api/Full/TbWarehouse/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbWarehouseManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbWarehouse/Add")]
        public ActionResult Add(tbWarehouseModel model)
        {
            try
            {
                return Ok(_TbWarehouseManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbWarehouse/Update")]
        public ActionResult Update(Guid GUIDWarehouse, tbWarehouseModel model)
        {
            try
            {
                return Ok(_TbWarehouseManager.Update(GUIDWarehouse, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbWarehouse/HardDelete")]
        public ActionResult HardDelete(Guid GUIDWarehouse)
        {
            try
            {
                return Ok(_TbWarehouseManager.HardDelete(GUIDWarehouse));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
