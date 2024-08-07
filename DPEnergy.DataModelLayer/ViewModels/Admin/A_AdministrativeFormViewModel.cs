﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.Admin
{
    public class A_AdministrativeFormViewModel
    {
        public int AdministrativeFormID { get; set; }


        public bool AdministrativeFormType { get; set; }

        [Display(Name = "عنوان نامه")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "عنوان نامه وارد نشده است")]
        public string AdministrativeFormTitle { get; set; }

        [Display(Name = "متن نامه")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "متن نامه وارد نشده است")]
        public string AdministrativeFormContent { get; set; }
        public string UserID { get; set; }
    }
}
