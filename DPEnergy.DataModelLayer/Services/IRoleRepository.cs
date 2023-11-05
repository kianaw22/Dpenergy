using System;
using System.Collections.Generic;
using System.Text;

namespace DPEnergy.DataModelLayer.Services
{
   public interface IRoleRepository
    {
        string GetRoleId(string userId);
       
    }
}
