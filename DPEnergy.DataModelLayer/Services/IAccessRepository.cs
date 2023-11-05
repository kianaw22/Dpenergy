using DPEnergy.DataModelLayer.ViewModels.Admin;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPEnergy.DataModelLayer.Services
{
    public interface IAccessRepository
    {
        public List<NameAndPersonelCodeViewModel> GetNameFromPersonelCode();
    }
}
