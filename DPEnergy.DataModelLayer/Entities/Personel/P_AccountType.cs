using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.Personel
{
    public class P_AccountType
    {
        [key]
        public string Id { get; set; }
      
        public string AccountType { get; set; }
    }
}
