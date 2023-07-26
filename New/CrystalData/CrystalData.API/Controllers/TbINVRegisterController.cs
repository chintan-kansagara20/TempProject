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
    public class TbINVRegisterController : ControllerBase
    {
        ITbINVRegisterManager _TbINVRegisterManager { get; set; }

        public TbINVRegisterController(ITbINVRegisterManager TbINVRegisterManager)
        {
            _TbINVRegisterManager = TbINVRegisterManager;
        }

        [HttpPost]
        [Route("/api/Full/TbINVRegister/Get")]
        public ActionResult Get(FullGetModel model)
        {
            try
            {
                if (model.orderBy == null) { model.orderBy = new List<OrderByModel>(); }
                if (model.filtersList == null) { model.filtersList = new List<AdvanceFilterByModel>(); }
                return Ok(_TbINVRegisterManager.Get(model.page, model.itemsPerPage, model.orderBy, model.filtersList));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbINVRegister/Add")]
        public ActionResult Add(tbINVRegisterModel model)
        {
            try
            {
                return Ok(_TbINVRegisterManager.Insert(model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpPost]
        [Route("/api/Full/TbINVRegister/Update")]
        public ActionResult Update(Guid GUIDINVRegister, tbINVRegisterModel model)
        {
            try
            {
                return Ok(_TbINVRegisterManager.Update(GUIDINVRegister, model));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }

        [HttpDelete]
        [Route("/api/Full/TbINVRegister/Delete")]
        public ActionResult Delete(Guid GUIDINVRegister)
        {
            try
            {
                return Ok(_TbINVRegisterManager.Delete(GUIDINVRegister));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }


        [HttpDelete]
        [Route("/api/Full/TbINVRegister/HardDelete")]
        public ActionResult HardDelete(Guid GUIDINVRegister)
        {
            try
            {
                return Ok(_TbINVRegisterManager.HardDelete(GUIDINVRegister));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
