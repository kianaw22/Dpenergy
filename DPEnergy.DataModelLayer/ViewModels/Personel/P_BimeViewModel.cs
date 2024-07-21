using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.Personel
{
    public class P_BimeViewModel
    {
        public string Id { get; set; }
        [Display(Name = "کد پرسنلی")]
        public string PersonelCode { get; set; }

        [Display(Name = "نام")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }

        [Display(Name = "وضعیت بیمه")]
        public string VaziatBime { get; set; }

        [Display(Name = "شماره بیمه")]
        public string BimeNumber { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "یک عدد صحیح به عنوان تعداد سال های سابقه کار وارد کنید")]
        [Display(Name = "سابقه بیمه تامین اجتماعی")]
        public int SabegheTaminEjtemaei { get; set; }

        [Display(Name = "تاریخ ثبت سابقه تامین اجتماعی")]
        public DateTime? TarikhSabtSabegheTamin { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "یک عدد صحیح به عنوان تعداد سال های سابقه کار وارد کنید")]
        [Display(Name = "سابقه بیمه بر اساس خود اظهاری")]
        public int SabegheKhodEzhari { get; set; }
        [Display(Name = "تاریخ ثبت بیمه بر اساس خود اظهاری")]
        public DateTime? TarikhSabtKhodEzhari { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public string Creator { get; set; }
        public string Modifier { get; set; }
    }
}
