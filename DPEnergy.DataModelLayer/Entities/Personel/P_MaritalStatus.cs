using System;
using System.Collections.Generic;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.Personel
{
    public class P_MaritalStatus
    {
        [key]
        public string Id { get; set; }
        public string MaritalStatus { get; set; }
    }
}
