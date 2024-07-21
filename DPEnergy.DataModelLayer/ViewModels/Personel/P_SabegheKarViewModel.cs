using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.Personel
{
    public class P_SabegheKarViewModel
    {
        public string Id { get; set; }
        [Display(Name = "کد پرسنلی")]
        public string PersonelCode { get; set; }
        [Display(Name = "نام")]
        public string FirstName { get; set; }
        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }
        [Display(Name = "شرکت")]
        public string Company { get; set; }
        [Display(Name = "تاریخ شروع")]
        public DateTime? StartDate { get; set; }
        [Display(Name = "تاریخ پایان")]
        public DateTime? EndDate { get; set; }
        public string Attachment { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public string Creator { get; set; }
        public string Modifier { get; set; }
        public int Counter { get; set; }
    }
}
