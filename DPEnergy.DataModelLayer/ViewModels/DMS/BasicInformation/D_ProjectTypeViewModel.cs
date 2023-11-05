using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.DMS.BasicInformation
{
    public class D_ProjectTypeViewModel
    {
        public string Id { get; set; }


        [Display(Name = "Project Type")]
        [StringLength(maximumLength: 30, MinimumLength = 2, ErrorMessage = "{0} باید حداقل 2 و حداکثر 10 کاراکتر باشد.")]
        public string ProjectType { get; set; }

        [Display(Name = "Persian Title")]
        public string ProjectTypePersian { get; set; }
    }

}
