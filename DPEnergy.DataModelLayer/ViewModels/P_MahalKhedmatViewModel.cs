using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels
{
    public class P_MahalKhedmatViewModel
    {
        public String Id { get; set; }
        [Display(Name = "نام محل خدمت")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} وارد نشده است.")]
        [StringLength(maximumLength: 100, MinimumLength = 2, ErrorMessage = "{0} باید حداقل 2 و حداکثر 100 کاراکتر باشد.")]
        [RegularExpression(@"^[^\\/:*;,<>\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده نکنید.")]
        public String MahalKhedmatName { get; set; }
    }
}
