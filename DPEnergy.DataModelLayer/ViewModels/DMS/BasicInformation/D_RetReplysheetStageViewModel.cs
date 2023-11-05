﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.DMS.BasicInformation
{
    public class D_RetReplysheetStageViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Project Code")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} وارد نشده است.")]
        [StringLength(maximumLength: 6, MinimumLength = 4, ErrorMessage = "    باید {0} حدافل 2 کاراکتر و حداکثر 10 کاراکنر باشد.")]
        public string ProjectCode { get; set; }


        [Display(Name = "Stage")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} وارد نشده است.")]
        [StringLength(maximumLength: 10, MinimumLength = 1, ErrorMessage = "    باید {0} حدافل 1 کاراکتر و حداکثر 10 کاراکنر باشد.")]
        public string Stage { get; set; }


        [Display(Name = "Description")]
        public string Description { get; set; }


        [Display(Name = "Creator")]
        public string Creator { get; set; }

        [Display(Name = "Order")]
        public int? Order { get; set; }

        [Display(Name = "CreationDate")]
        public DateTime? CreationDate { get; set; }

        [Display(Name = "Modifier")]
        public string Modifier { get; set; }

        [Display(Name = "ModificationDate")]
        public DateTime? ModificationDate { get; set; }
    }
}
