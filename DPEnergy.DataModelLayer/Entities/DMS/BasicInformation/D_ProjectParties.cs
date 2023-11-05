using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.DMS.BasicInformation
{
    public class D_ProjectParties
    {
        [Key]
        public string Id { get; set; }
        public String Title { get; set; }
        public string ProjectCode { get; set; }
        public string CompanyName { get; set; }
        public string RoleInProject { get; set; }
        public string CounterParty { get; set; }
        
    }
}
