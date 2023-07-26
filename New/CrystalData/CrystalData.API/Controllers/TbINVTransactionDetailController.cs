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
    public class TbINVTransactionDetailController : ControllerBase
    {
        ITbINVTransactionDetailManager _TbINVTransactionDetail { get; set; }

        public TbINVTransactionDetailController(ITbINVTransactionDetailManager TbINVTransactionDetail)
        {
            _TbINVTransactionDetail = TbINVTransactionDetail;
        }

        [HttpPost]
        [Route("/api/Full/TbINVTransactionDetail/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbINVTransactionDetail.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbINVTransactionDetail/Add")]
        public ActionResult Add(tbINVTransactionDetailModel model)
        {
            try
            {
                return Ok(_TbINVTransactionDetail.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbINVTransactionDetail/Update")]
        public ActionResult Update(Guid GUIDINVTransactionDetail, tbINVTransactionDetailModel model)
        {
            try
            {
                return Ok(_TbINVTransactionDetail.Update(GUIDINVTransactionDetail, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }


        [HttpDelete]
        [Route("/api/Full/TbINVTransactionDetail/HardDelete")]
        public ActionResult HardDelete(Guid GUIDINVTransactionDetail)
        {
            try
            {
                return Ok(_TbINVTransactionDetail.HardDelete(GUIDINVTransactionDetail));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
