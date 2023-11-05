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
        [StringLength(maximumLength: 50, MinimumLength = 4, ErrorMessage = "{0} باید حداقل 4 و حداکثر 10 کاراکتر باشد.")]
        public string CompanyName { get; set; }

        [Display(Name = "Manager Name")]
        [StringLength(maximumLength: 50, MinimumLength =2 , ErrorMessage = "{0} باید حداقل 2 و حداکثر 10 کاراکتر باشد.")]
        public string ManagerName { get; set; }

        [Display(Name = "Company Phone")]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "{0} باید حداقل 4 و حداکثر 10 کاراکتر باشد.")]
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
