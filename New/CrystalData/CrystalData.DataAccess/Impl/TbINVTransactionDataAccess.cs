﻿using AuthLayer.Models;
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
    public class TbINVTransactionDataAccess : ITbINVTransactionDataAccess
    {
        private string ConnectionString { get; set; }
        private CommonFunctions cf { get; set; }
        private IUserManager _UserManager { get; set; }

        public TbINVTransactionDataAccess(IHostingEnvironment env, IConfiguration configuration, IHttpContextAccessor httpContextAccessor, IUserManager UserManager)
        {
            try
            {
                cf = new CommonFunctions(configuration, env.ContentRootPath, httpContextAccessor);
                ConnectionString = cf.GetNewConnectionString();
                _UserManager = UserManager;
            }
            catch (Exception) { }
        }

        public List<tbINVTransactionModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList)
        {
            var _EC = new EasyCrud(ConnectionString);

            string WhereCondition = "";
            string FilterCondtion = DataAccessHelper.ConvertAdvanceFilterToConditionString(filtersList);
            if (!String.IsNullOrEmpty(FilterCondtion))
            {
                WhereCondition += " WHERE " + FilterCondtion;
            }

            var FinalReturn = _EC.GetList<tbINVTransactionModel>(page, itemsPerPage, orderBy, WhereCondition, null, GSEnums.WithInQuery.NoLock);
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

            var total = _EC.Count<tbINVTransactionModel>(WhereCondition, null, GSEnums.WithInQuery.NoLock);
            return total;
        }

        public string Add(tbINVTransactionModel model, bool AutoCommit = true, EasyCrud _EC = null)
        {
            if (!AutoCommit && _EC == null) { throw new Exception("When AutoCommit is False EasyCrud Object Needs to be passed"); }
            if (_EC == null) { _EC = new EasyCrud(ConnectionString); }
            var recs = _EC.Add(model, "GUIDINVTransaction", "PKIDINVTransaction", AutoCommit);
            return recs.ToString();
        }

        public bool Update(Guid GUIDINVTransaction, tbINVTransactionModel model, bool AutoCommit = true, EasyCrud _EC = null)
        {
            if (!AutoCommit && _EC == null) { throw new Exception("When AutoCommit is False EasyCrud Object Needs to be passed"); }
            if (_EC == null) { _EC = new EasyCrud(ConnectionString); }

            List<SqlParameter> Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@GUIDINVTransaction", GUIDINVTransaction));
            string WhereCondition = " WHERE GUIDINVTransaction = @GUIDINVTransaction ";

            var recs = _EC.Update(model, WhereCondition, Parameters, "GUIDINVTransaction, PKIDINVTransaction", AutoCommit);

            if (recs == null)
                return false;
            else
                return true;
        }

        public bool HardDelete(Guid GUIDINVTransaction, bool AutoCommit = true, EasyCrud _EC = null)
        {
            if (!AutoCommit && _EC == null) { throw new Exception("When AutoCommit is False EasyCrud Object Needs to be passed"); }
            if (_EC == null) { _EC = new EasyCrud(ConnectionString); }

            List<SqlParameter> Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@GUIDINVTransaction", GUIDINVTransaction));
            string WhereCondition = " WHERE GUIDINVTransaction = @GUIDINVTransaction ";

            var recs = _EC.Remove<tbINVRegisterModel>(WhereCondition, "GUIDINVTransaction", Parameters, AutoCommit);

            if (recs == null)
                return false;
            else
                return true;
        }
    }
}
