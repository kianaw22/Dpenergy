using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels
{
    public class P_CompanyViewModel
    {
        public string Id { get; set; }
        [Display(Name = "نام شهر")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} وارد نشده است.")]
        [StringLength(maximumLength: 100, MinimumLength = 2, ErrorMessage = "{0} باید حداقل 2 و حداکثر 100 کاراکتر باشد.")]
        [RegularExpression(@"^[^\\/:*;,<>\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده نکنید.")]
        public String CompanyName { get; set; }
    }
}
