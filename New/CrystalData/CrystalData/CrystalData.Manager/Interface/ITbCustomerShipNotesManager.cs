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
    public interface ITbCustomerShipNotesManager
    {
        APIResponse Get(int page, int itemsPerPage, List<OrderByModel> orderBy, List<AdvanceFilterByModel> filtersList);
        APIResponse Insert(tbCustomerShipNotesModel model);
        APIResponse Update(Guid GUIDLocation, tbCustomerShipNotesModel model);
        APIResponse HardDelete(Guid GUIDLocation);
    }
}
