using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels
{
    public class PersonelViewModel
    {

        [Display(Name = "کد پرسنلی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} وارد نشده است.")]
      //  [StringLength(maximumLength: 10, MinimumLength = 2, ErrorMessage = "{0} باید حداقل 4 کاراکنر باشد.")]
        public string PersonelCode { get; set; }

        [Display(Name = "نام")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} وارد نشده است.")]
       // [StringLength(maximumLength: 100, MinimumLength = 2, ErrorMessage = "{0} باید حداقل 2 و حداکثر 100 کاراکتر باشد.")]
        [RegularExpression(@"^[^\\/:*;,<>\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده نکنید.")]
        public string FirstName { get; set; }

        [Display(Name = " نام خانوادگی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} وارد نشده است.")]
       // [StringLength(maximumLength: 100, MinimumLength = 2, ErrorMessage = "{0} باید حداقل 2 و حداکثر 100 کاراکتر باشد.")]
        [RegularExpression(@"^[^\\/:*;,<>\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده نکنید.")]
        public string LastName { get; set; }

        [Display(Name = "کد حسابداری")]
     
        public string HesabDariCode { get; set; }

        [Display(Name = "نام پدر")]
        public string Father { get; set; }

        [Display(Name = "جنسیت")]
        public string Gender { get; set; }

        [Display(Name = "شماره شناسنامه")]
        public string ShenasnameNumber { get; set; }

        [Display(Name = "شماره سریال شناسنامه")]
        public string ShenasnameSerial { get; set; }

        [Display(Name = "محل صدور ")]
        public string SodurPlace { get; set; }

        [Display(Name = "کد ملی ")]
        [MinLength(10, ErrorMessage = "{0} باید 10 رقمی باشد")]
        [MaxLength(10, ErrorMessage = "{0} باید 10 رقمی باشد")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "فرمت {0} صحیح نیست.")]
        public string Mellicode { get; set; }

        [Display(Name = "محل تولد ")]
        public string BirthPlace { get; set; }

        [Display(Name = "تاریخ تولد ")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "وضعیت تاهل ")]
        public string MaritalStatus { get; set; }

        [Display(Name = "دپارتمان")]
        public string Department { get; set; }
        [Display(Name = "تاربخ شروع به کار ")]
        public DateTime? StartWorkDate { get; set; }
        [Display(Name = "نوع قرارداد")]
        public string ContractType { get; set; }

        [Display(Name = "شرکت")]
        public string Company { get; set; }

        [Display(Name = "محل خدمت")]
        public string MahalKhedmat { get; set; }

        [Display(Name = "وضعیت اشتغال")]
        public string VaziatEshteqal { get; set; }

        [Display(Name = "رده شغلی")]
        public string JobCategory { get; set; }
        [Display(Name = "تاریخ تسویه حساب")]
        public DateTime? TasfieDate { get; set; }

        [Display(Name = "علت ترک کار")]

        public string ElatTarkKar { get; set; }

        [Display(Name = "کاور")]
        public string Cover { get; set; }
     
        [Display(Name = "معرف")]
        public string Moaref { get; set; }

        [Display(Name = "شماره موبایل ")]
        [MinLength(11, ErrorMessage = "{0} باید 11 رقمی باشد")]
        [MaxLength(11, ErrorMessage = "{0} باید 11 رقمی باشد")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "فرمت {0} صحیح نیست.")]
        public string PhoneNumber { get; set; }
        [Display(Name = "سمت")]
        public string Post { get; set; }
        [Display(Name = "محل کار")]
        public string WorkPlace { get; set; }
        [Display(Name = "آدرس")]
        public string Address { get; set; }
        [Display(Name = "نحوه آشنایی با شرکت")]
        public string Introduction { get; set; }
        [Display(Name = "گروه خونی")]
        public string BloodType { get; set; }
        [Display(Name = "دارو های خاص مضرفی")]
        public string SpecialDrug { get; set; }
        [Display(Name = "بیماری های خاص")]
        public string Sickness { get; set; }
        [Display(Name = "سقف کارکرد")]
        public string SaqfKarkard { get; set; }
        [Display(Name = "اضافه کار")]
        public string Overtime { get; set; }
        [Display(Name = "اسکن شناسنامه")]
        public string ShenasnameScanPath { get; set; }
        [Display(Name = "اسکن کارت ملی")]
        public string MelliScanPath { get; set; }

        [Display(Name = "عکس پرسنل")]
        public string PersonalImagePath { get; set; }
        [Display(Name = "امضا پرسنل")]
        public string SignaturePath { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime? CreationDate { get; set; }

        [Display(Name = "تاریخ اصلاح")]
        public DateTime? ModificationDate { get; set; }
        [Display(Name = "ایجاد کننده")]
        public string Creator { get; set; }
        [Display(Name = "اصلاح کننده")]
        public string Modifier { get; set; }
        [Display(Name = "یادداشت")]
        public string Note { get; set; }
    }
}
