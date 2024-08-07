﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.DMS.BasicInformation
{
    public class D_ProjectManagerViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Project Manager")]
        [StringLength(maximumLength:100, MinimumLength = 2, ErrorMessage = "{0} باید حداقل 2 و حداکثر 10 کاراکتر باشد.")]
        public string ProjectManager { get; set; }
    }
}
