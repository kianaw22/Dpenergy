using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.Personel
{
    public class P_TakafolViewModel
    {
        public string Id { get; set; }
        [Display(Name = "کد پرسنلی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} وارد نشده است.")]
        public string PersonelCode { get; set; }
        [Display(Name = "نام")]
        public string FirstName { get; set; }
        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }
        [Display(Name = "نام فرد تحت تکفل")]
        public string Name { get; set; }
        [Display(Name = "نسبت فرد تحت تکفل")]
        public string Relation { get; set; }
        [Display(Name = "تاریخ تولد فرد تحت تکفل")]
        public DateTime? Birthdate { get; set; }
        [Display(Name = "بیمه تکمیلی")]
        public string  Active { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public string Creator { get; set; }
        public string Modifier { get; set; }
    }
}
