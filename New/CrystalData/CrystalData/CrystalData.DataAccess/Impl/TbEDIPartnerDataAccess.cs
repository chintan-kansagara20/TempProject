﻿using AuthLayer.Mangers.Interface;
using AuthLayer.Utility;
using CrystalData.DataAccess.Interface;
using CrystalData.Models;
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
using System.Data.SqlClient;

namespace CrystalData.DataAccess.Impl
{
    public class TbEDIPartnerDataAccess : ITbEDIPartnerDataAccess
    {
        private string ConnectionString { get; set; }
        private CommonFunctions cf { get; set; }
        private IUserManager _UserManager { get; set; }

        public TbEDIPartnerDataAccess(IHostingEnvironment env, IConfiguration configuration, IHttpContextAccessor httpContextAccessor, IUserManager UserManager)
        {
            try
            {
                cf = new CommonFunctions(configuration, env.ContentRootPath, httpContextAccessor);
                ConnectionString = cf.GetNewConnectionString();
                _UserManager = UserManager;
            }
            catch (Exception) { }
        }

        public List<tbEDIPartnerModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList)
        {
            var _EC = new EasyCrud(ConnectionString);

            string WhereCondition = "";
            string FilterCondtion = DataAccessHelper.ConvertAdvanceFilterToConditionString(filtersList);
            if (!String.IsNullOrEmpty(FilterCondtion))
            {
                WhereCondition += " WHERE " + FilterCondtion;
            }

            var FinalReturn = _EC.GetList<tbEDIPartnerModel>(page, itemsPerPage, orderBy, WhereCondition, null, GSEnums.WithInQuery.NoLock);
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

            var total = _EC.Count<tbEDIPartnerModel>(WhereCondition, null, GSEnums.WithInQuery.NoLock);
            return total;
        }

        public string Add(tbEDIPartnerModel model, bool AutoCommit = true, EasyCrud _EC = null)
        {
            if (!AutoCommit && _EC == null) { throw new Exception("When AutoCommit is False EasyCrud Object Needs to be passed"); }
            if (_EC == null) { _EC = new EasyCrud(ConnectionString); }
            var recs = _EC.Add(model, "GUIDPartner", "", AutoCommit);
            return recs.ToString();
        }

        public bool Update(Guid GUIDPartner, tbEDIPartnerModel model, bool AutoCommit = true, EasyCrud _EC = null)
        {
            if (!AutoCommit && _EC == null) { throw new Exception("When AutoCommit is False EasyCrud Object Needs to be passed"); }
            if (_EC == null) { _EC = new EasyCrud(ConnectionString); }

            List<SqlParameter> Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@GUIDPartner", GUIDPartner));
            string WhereCondition = " WHERE GUIDPartner = @GUIDPartner ";

            var recs = _EC.Update(model, WhereCondition, Parameters, "GUIDPartner", AutoCommit);

            if (recs == null)
                return false;
            else
                return true;
        }

        public bool HardDelete(Guid GUIDPartner, bool AutoCommit = true, EasyCrud _EC = null)
        {
            if (!AutoCommit && _EC == null) { throw new Exception("When AutoCommit is False EasyCrud Object Needs to be passed"); }
            if (_EC == null) { _EC = new EasyCrud(ConnectionString); }

            List<SqlParameter> Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@GUIDPartner", GUIDPartner));
            string WhereCondition = " WHERE GUIDPartner = @GUIDPartner ";

            var recs = _EC.Remove<tbEDIPartnerModel>(WhereCondition, "GUIDPartner", Parameters, AutoCommit);

            if (recs == null)
                return false;
            else
                return true;
        }
    }
}
