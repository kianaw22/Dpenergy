﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.DMS.BasicInformation
{
    public class D_PaperSizeViewModel
    {
        public string Id { get; set; }

        [Display(Name = "TypeOfPaper")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} وارد نشده است.")]
        [StringLength(maximumLength: 10, MinimumLength = 1, ErrorMessage = "    باید {0} حدافل 1 کاراکتر و حداکثر 10 کاراکنر باشد.")]
        public string TypeOfPaper { get; set; }

        [Display(Name = "Measurment")]
        public string? Measurment { get; set; }


        [Display(Name = "Creator")]
        public string Creator { get; set; }

        [Display(Name = "CreationDate")]
        public DateTime? CreationDate { get; set; }

        [Display(Name = "Modifier")]
        public string Modifier { get; set; }

        [Display(Name = "ModificationDate")]
        public DateTime? ModificationDate { get; set; }
    }
}
