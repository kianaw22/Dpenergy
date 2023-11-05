using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.DMS.BasicInformation
{
    public class D_ProjectPartiesViewModel
    {
        
        public string Id { get; set; }

        [Display(Name = "Title")]
        [StringLength(maximumLength: 10, MinimumLength = 2, ErrorMessage = "{0} باید حداقل 2 و حداکثر 10 کاراکتر باشد.")]
        public String Title { get; set; }

        [Display(Name = "Project Code")]
        [StringLength(maximumLength: 10, MinimumLength = 4, ErrorMessage = "{0} باید حداقل 4 و حداکثر 10 کاراکتر باشد.")]
        public string ProjectCode { get; set; }

        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Display(Name = "Role in Project")]
        public string RoleInProject { get; set; }

        [Display(Name = "Counter Party")]
        public string CounterParty { get; set; }

    }
}
