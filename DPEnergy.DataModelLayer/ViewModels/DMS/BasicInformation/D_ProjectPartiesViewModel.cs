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
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0}")]
        public String Title { get; set; }

        [Display(Name = "Project Code")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0}")]
        public string ProjectCode { get; set; }

        [Display(Name = "Company Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0}")]
        public string CompanyName { get; set; }

        [Display(Name = "Role in Project")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0}")]
        public string RoleInProject { get; set; }

        [Display(Name = "Counter Party")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0}")]
        public string CounterParty { get; set; }

    }
}
