using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities
{
    public class P_Company
    {
        [Key]
        public string Id { get; set; }
        public string CompanyName { get; set; }

    }
}
