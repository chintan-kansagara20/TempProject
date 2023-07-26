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
    public class TbINVTransactionController : ControllerBase
    {
        ITbINVTransactionManager _TbINVTransactionManager { get; set; }

        public TbINVTransactionController(ITbINVTransactionManager TbINVTransactionManager)
        {
            _TbINVTransactionManager = TbINVTransactionManager;
        }

        [HttpPost]
        [Route("/api/Full/TbINVTransaction/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbINVTransactionManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbINVTransaction/Add")]
        public ActionResult Add(tbINVTransactionModel model)
        {
            try
            {
                return Ok(_TbINVTransactionManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbINVTransaction/Update")]
        public ActionResult Update(Guid GUIDINVTransaction, tbINVTransactionModel model)
        {
            try
            {
                return Ok(_TbINVTransactionManager.Update(GUIDINVTransaction, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }


        [HttpDelete]
        [Route("/api/Full/TbINVTransaction/HardDelete")]
        public ActionResult HardDelete(Guid GUIDINVTransaction)
        {
            try
            {
                return Ok(_TbINVTransactionManager.HardDelete(GUIDINVTransaction));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
