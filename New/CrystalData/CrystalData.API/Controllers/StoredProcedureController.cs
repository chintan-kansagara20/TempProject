using AuthLayer.ActionFilters;
using AuthLayer.Utility;
using CrystalData.Manager.Interface;
using EasyCrudLibrary.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CrystalData.API.Controllers
{
    [ApiController]
    [FullAuthorization]
    public class StoredProcedureController : ControllerBase
    {
        IStoredProcedureManager _StoredProcedureManager { get; set; }

        public StoredProcedureController(IStoredProcedureManager StoredProcedureManager)
        {
            _StoredProcedureManager = StoredProcedureManager;
        }

        [HttpGet]
        [Route("/api/StoredProcedure/GetNextNumber")]
        public ActionResult GetNextNumber(string NumberType)
        {
            try
            {
                return Ok(_StoredProcedureManager.GetNextNumber(NumberType));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse(ResponseCode.ERROR, ex.Message, JsonConvert.SerializeObject(ex)));
            }
        }
    }
}
