using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.Personel
{
    public class P_MadrakTahsiliViewModel
    {
        public string Id { get; set; }

        [Display(Name = "کد پرسنلی")]
        public string PersonelCode { get; set; }

        [Display(Name = "نام")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }

        [Display(Name = "مدرک تحصیلی")]
        public string MadrakTahsili { get; set; }

        [Display(Name = "نوع مدرک")]
        public string MadrakType { get; set; }

        [Display(Name = "رشته تحصیلی")]
        public string FieldOfStudy { get; set; }

        [Display(Name = "سال فارغ التحصیلی")]
        public DateTime? GraduationYear { get; set; }

        [Display(Name = "تعهد عدم استفاده از مدرک در جای دیگر")]
        public bool Obligation { get; set; }

        [Display(Name = "تاییدیه مدرک تحصیلی")]
        public bool Confirmation { get; set; }
        public string Attachment { get; set; }
        public int Counter { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public string Creator { get; set; }
        public string Modifier { get; set; }
    }
}
