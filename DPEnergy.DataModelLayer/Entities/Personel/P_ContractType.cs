using System;
using System.Collections.Generic;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.Personel
{
    public class P_ContractType
    {
        [key]
        public string Id { get; set; }
        public string ContractType { get; set; }
    }
}
