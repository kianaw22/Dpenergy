using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.Personel
{
    public class P_InsuranceStatus
    {

        [Key]
        public string Id { get; set; }
        public string InsuranceStatus { get; set; }
    }
}
