﻿using AuthLayer.Utility;
using DataAccessLayer.Interface;
using EasyCrudLibrary.Model;
using EasyCrudLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace DataAccessLayer.Impl
{
    public class CarrierServiceDataAccess : ICarrierServiceDataAccess
    {
        private string ConnectionString { get; set; }
        private CommonFunctions cf { get; set; }

        public CarrierServiceDataAccess(IHostingEnvironment env, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            try
            {
                cf = new CommonFunctions(configuration, env.ContentRootPath, httpContextAccessor);
                //ConnectionString = _cf.GetNewConnectionString();
                ConnectionString = "Server=dev2302.crystalsystems.work;Database=Acctivate$NAHSdev0306;User Id=sa;Password=ACCTivate!MSSQL;TrustServerCertificate=True;";
            }
            catch (Exception) { }
        }

        public List<CarrierServiceModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList)
        {
            var _EC = new EasyCrud(ConnectionString);

            string WhereCondition = "";
            string FilterCondtion = DataAccessHelper.ConvertAdvanceFilterToConditionString(filtersList);
            if (!String.IsNullOrEmpty(FilterCondtion))
            {
                WhereCondition += " WHERE " + FilterCondtion;
            }

            var FinalReturn = _EC.GetList<CarrierServiceModel>(page, itemsPerPage, orderBy, WhereCondition, null, GSEnums.WithInQuery.NoLock);
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

            var total = _EC.Count<CarrierServiceModel>(WhereCondition, null, GSEnums.WithInQuery.NoLock);
            return total;
        }
    }
}
