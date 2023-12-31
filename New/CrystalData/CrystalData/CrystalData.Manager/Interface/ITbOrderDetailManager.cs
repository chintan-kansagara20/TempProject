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
    public interface ITbOrderDetailManager
    {
        APIResponse Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        APIResponse Insert(tbOrderDetailModel model);
        APIResponse Update(Guid GUIDOrderDetail, tbOrderDetailModel model);
        APIResponse HardDelete(Guid GUIDOrderDetail);
    }
}
