using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels
{
    public class DepartmentViewModel
    {
        public string Id { get; set; }

        [Display(Name = "کد دپارتمان")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} وارد نشده است.")]
        public string DepartmentCode { get; set; }

        [Display(Name = "نام دپارتمان")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} وارد نشده است.")]
        [StringLength(maximumLength: 100, MinimumLength =2, ErrorMessage = "{0} باید حداقل 2 و حداکثر 100 کاراکتر باشد.")]
        [RegularExpression(@"^[^\\/:*;,<>\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده نکنید.")]
        public String DepartmentName { get; set; }

        [Display(Name = "مخفف دپارتمان")]
        public String DepartmentMokhafaf { get; set; }
        [Display(Name = "نام فارسی دپارتمان")]
        public String DepaertmentPersianName { get; set; }
    }
}
