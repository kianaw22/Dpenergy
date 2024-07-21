using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.Personel
{
    public class P_InstitutionName
    {
        [Key]
        public string Id { get; set; }
        public string InstitutionName { get; set; }
    }
}
