using AuthLayer.Models;
using AuthLayer.Utility;
using EasyCrudLibrary.Model;
using EasyCrudLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using CrystalData.DataAccess.Interface;
using CrystalData.Models;
using System.Data.SqlClient;
using AuthLayer.Mangers.Interface;

namespace CrystalData.DataAccess.Impl
{
    public class TbINVRegisterDataAccess : ITbINVRegisterDataAccess
    {
        private string ConnectionString { get; set; }
        private CommonFunctions cf { get; set; }
        private IUserManager _UserManager { get; set; }

        public TbINVRegisterDataAccess(IHostingEnvironment env, IConfiguration configuration, IHttpContextAccessor httpContextAccessor, IUserManager UserManager)
        {
            try
            {
                cf = new CommonFunctions(configuration, env.ContentRootPath, httpContextAccessor);
                ConnectionString = cf.GetNewConnectionString();
                _UserManager = UserManager;
            }
            catch (Exception) { }
        }

        public List<tbINVRegisterModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList)
        {
            var _EC = new EasyCrud(ConnectionString);

            string WhereCondition = "";
            string FilterCondtion = DataAccessHelper.ConvertAdvanceFilterToConditionString(filtersList);
            if (!String.IsNullOrEmpty(FilterCondtion))
            {
                WhereCondition += " WHERE " + FilterCondtion;
            }

            var FinalReturn = _EC.GetList<tbINVRegisterModel>(page, itemsPerPage, orderBy, WhereCondition, null, GSEnums.WithInQuery.NoLock);
            return FinalReturn;
        }

        public int GetTotal(List<AdvanceFilterByModel> filtersList)
        {
            var _EC = new EasyCrud(ConnectionString);

            string WhereCondition = "";
            string FilterCondtion = DataAccessHelper.ConvertAdvanceFilterToConditionString(filtersList);
            if (!String.IsNullOrEmpty(FilterCondtion))
            {
                WhereCondition += " WHERE " + FilterCondtion;
            }

            var total = _EC.Count<tbINVRegisterModel>(WhereCondition, null, GSEnums.WithInQuery.NoLock);
            return total;
        }

        public string Add(tbINVRegisterModel model, bool AutoCommit = true, EasyCrud _EC = null)
        {
            if (!AutoCommit && _EC == null) { throw new Exception("When AutoCommit is False EasyCrud Object Needs to be passed"); }
            if (_EC == null) { _EC = new EasyCrud(ConnectionString); }
            var recs = _EC.Add(model, "GUIDINVRegister", "GUIDINVRegister, PKIDINVRegister", AutoCommit);
            return recs.ToString();
        }

        public bool Update(Guid GUIDINVRegister, tbINVRegisterModel model, bool AutoCommit = true, EasyCrud _EC = null)
        {
            if (!AutoCommit && _EC == null) { throw new Exception("When AutoCommit is False EasyCrud Object Needs to be passed"); }
            if (_EC == null) { _EC = new EasyCrud(ConnectionString); }

            List<SqlParameter> Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@GUIDINVRegister", GUIDINVRegister));
            string WhereCondition = " WHERE GUIDINVRegister = @GUIDINVRegister ";

            var recs = _EC.Update(model, WhereCondition, Parameters, "GUIDINVRegister, PKIDINVRegister", AutoCommit);

            if (recs == null)
                return false;
            else
                return true;
        }

        public bool VoidRecord(Guid GUIDINVRegister, bool AutoCommit = true, EasyCrud _EC = null)
        {
            if (!AutoCommit && _EC == null) { throw new Exception("When AutoCommit is False EasyCrud Object Needs to be passed"); }
            if (_EC == null) { _EC = new EasyCrud(ConnectionString); }

            List<SqlParameter> Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@GUIDINVRegister", GUIDINVRegister));
            Parameters.Add(new SqlParameter("@VoidedDate", DateTime.UtcNow));
            Parameters.Add(new SqlParameter("@VoidedBy", _UserManager.GetCurrentUser().ID));
            string Query = " Update TbINVRegister SET VoidedDate = @VoidedDate, VoidedBy = @VoidedBy WHERE GUIDINVRegister = @GUIDINVRegister ";

            var recs = _EC.Query(Query, Parameters, AutoCommit, GSEnums.ExecuteType.ExecuteNonQuery);

            if (recs == null)
                return false;
            else
                return true;
        }

        public bool HardDelete(Guid GUIDINVRegister, bool AutoCommit = true, EasyCrud _EC = null)
        {
            if (!AutoCommit && _EC == null) { throw new Exception("When AutoCommit is False EasyCrud Object Needs to be passed"); }
            if (_EC == null) { _EC = new EasyCrud(ConnectionString); }

            List<SqlParameter> Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@GUIDINVRegister", GUIDINVRegister));
            string WhereCondition = " WHERE GUIDINVRegister = @GUIDINVRegister ";

            var recs = _EC.Remove<tbINVRegisterModel>(WhereCondition, "GUIDINVRegister", Parameters, AutoCommit);

            if (recs == null)
                return false;
            else
                return true;
        }
    }
}
