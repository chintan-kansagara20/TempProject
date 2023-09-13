﻿using AuthLayer.Utility;
using CrystalData.Models;
using EasyCrudLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Manager.Interface
{
    public interface ITbCustomerContractManager
    {
        APIResponse Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        APIResponse Insert(tbCustomerContractModel model);
        APIResponse Update(Guid GUIDCustomerContract, tbCustomerContractModel model);
        APIResponse HardDelete(Guid GUIDCustomerContract);
    }
}
