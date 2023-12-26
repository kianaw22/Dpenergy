using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.DMS.BasicInformation
{
    public class D_ContractorViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Company Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0}")]
        public string CompanyName { get; set; }

        [Display(Name = "Manager Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0}")]
        public string ManagerName { get; set; }

        [Display(Name = "Company Phone")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0}")]
        public string CompanyPhone { get; set; }
        
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Fax")]
        public string Fax { get; set; }

        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [Display(Name = "CompanyType")]
        public string CompanyType { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

    }
}
