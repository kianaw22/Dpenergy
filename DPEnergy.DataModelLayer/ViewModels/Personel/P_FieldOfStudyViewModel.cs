using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.Personel
{
    public class P_FieldOfStudyViewModel
    {
        public String Id { get; set; }

        [Display(Name = "رشته تحصیلی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} وارد نشده است.")]
        public String FieldofStudy { get; set; }
    }
}
