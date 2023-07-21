﻿using AuthLayer.Utility;
using DataAccessLayer.Interface;
using EasyCrudLibrary.Model;
using EasyCrudLibrary;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Models;

namespace DataAccessLayer.Impl
{
    public class CvAssemblyDocumentMembersDataAccess : ICvAssemblyDocumentMembersDataAccess
    {
        private string ConnectionString { get; set; }

        private CommonFunctions cf { get; set; }
        public CvAssemblyDocumentMembersDataAccess(IHostingEnvironment env, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            try
            {
                cf = new CommonFunctions(configuration, env.ContentRootPath, httpContextAccessor);
                //ConnectionString = _cf.GetNewConnectionString();
                ConnectionString = "Server=dev2302.crystalsystems.work;Database=Acctivate$NAHSdev0306;User Id=sa;Password=ACCTivate!MSSQL;TrustServerCertificate=True;";
            }
            catch (Exception) { }
        }

        public List<cvAssemblyDocumentMembersModel> Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList)
        {
            var _EC = new EasyCrud(ConnectionString);

            string WhereCondition = "";
            string FilterCondtion = DataAccessHelper.ConvertAdvanceFilterToConditionString(filtersList);
            if (!String.IsNullOrEmpty(FilterCondtion))
            {
                WhereCondition += " WHERE " + FilterCondtion;
            }

            var FinalReturn = _EC.GetList<cvAssemblyDocumentMembersModel>(page, itemsPerPage, orderBy, WhereCondition, null, GSEnums.WithInQuery.NoLock);
            return FinalReturn;
        }

        public int GetTotal(List<AdvanceFilterByModel> filtersList)
        {
            throw new NotImplementedException();
        }
    }
}
