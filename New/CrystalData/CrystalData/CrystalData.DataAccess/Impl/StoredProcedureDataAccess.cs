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
using System.Data;

namespace CrystalData.DataAccess.Impl
{
    public class StoredProcedureDataAccess : IStoredProcedureDataAccess
    {
        private string ConnectionString { get; set; }
        private CommonFunctions cf { get; set; }

        public StoredProcedureDataAccess(IHostingEnvironment env, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            try
            {
                cf = new CommonFunctions(configuration, env.ContentRootPath, httpContextAccessor);
                ConnectionString = cf.GetNewConnectionString();
            }
            catch (Exception) { }
        }

        public int GetNextNumber(string NumberType)
        {
            var _EC = new EasyCrud(ConnectionString);
            int NextNumber = 0;
            string Query = "GetNextNumber";
            List<SqlParameter> Parameters = new List<SqlParameter>();
            var NumberTypeParameter = new SqlParameter("@NumberType", NumberType);
            var NextNumberParameter = new SqlParameter("@NextNumber", NextNumber);
            NextNumberParameter.Direction = ParameterDirection.Output;
            Parameters.Add(NextNumberParameter);
            Parameters.Add(NumberTypeParameter);
            var result = _EC.Query(Query, Parameters,true,GSEnums.ExecuteType.ExecuteReader,CommandType.StoredProcedure,true);

            SqlCommand cmd = result.Command;
            var NextNumberIndex = cmd.Parameters.IndexOf(NextNumberParameter);
            var NextNumberObject = cmd.Parameters[NextNumberIndex].SqlValue;
            NextNumber = CommonFunctions.ToDynamic(NextNumberObject).Value;
            return NextNumber;
        }
    }
}
