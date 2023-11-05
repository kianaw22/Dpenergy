using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.DMS.BasicInformation
{
    public class D_Contractor
    {
        [Key]
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string ManagerName { get; set; }
        public string CompanyPhone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string PostalCode { get; set; }
        public string CompanyType { get; set; }
        public string Address { get; set; }


    }
}
