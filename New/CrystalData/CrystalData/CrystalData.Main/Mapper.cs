using AuthLayer.Mangers.Interface;
using AuthLayer.Utility;
using CrystalData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Main
{
    public class Mapper
    {
        public IUserManager _UserManager { get; set; }
        Mapper(IUserManager UserManager)
        {
            _UserManager = UserManager;
        }

        public tbINVRegisterModel Map(tbINVRegisterViewModel viewModel, bool IsVoided = false, bool IsUpdated = false)
        {
            var model = new tbINVRegisterModel();
            model.RegNumber = viewModel.RegNumber;
            model.RegDate = viewModel.RegDate;
            model.TransactionDate = viewModel.TransactionDate;
            model.Source = viewModel.Source;
            model.OpenedBy = viewModel.OpenedBy;
            model.Description = viewModel.Description;
            model.Amount = viewModel.Amount;
            model.PostedToINV = viewModel.PostedToINV;
            model.PostedToINVBy = viewModel.PostedToINVBy;
            model.DatePostedToINV = viewModel.DatePostedToINV;
            model.PostedToGL = viewModel.PostedToGL;
            model.PostedToGLBy = viewModel.PostedToGLBy;
            model.DatePostedToGL = viewModel.DatePostedToGL;
            model.PostedToAP = viewModel.PostedToAP;
            model.PostedToAPBy = viewModel.PostedToAPBy;
            model.DatePostedToAP = viewModel.DatePostedToAP;
            model.Note = viewModel.Note;
            model.GLTransactionBatch = viewModel.GLTransactionBatch;
            model.TransactionPeriod = viewModel.TransactionPeriod;
            model.TransactionYear = viewModel.TransactionYear;
            model.ParentRegNumber = viewModel.ParentRegNumber;
            model.GUIDLandedCostPODetail = viewModel.GUIDLandedCostPODetail;
            model.GUIDOrder = viewModel.GUIDOrder;

            model.VoidedDate = null;
            model.VoidedBy = null;
            model.UpdatedDate = null;
            model.UpdatedBy = null;
            model.PKIDINVRegister = 0;
            model.GUIDINVRegister = Guid.NewGuid();

            if (IsVoided)
            {
                model.VoidedDate = DateTime.UtcNow;
                model.VoidedBy = _UserManager.GetCurrentUser().ID;
            }

            if (IsUpdated)
            {
                model.UpdatedDate = DateTime.UtcNow;
                model.UpdatedBy = _UserManager.GetCurrentUser().ID;
            }

            return model;
        }
    }
}
