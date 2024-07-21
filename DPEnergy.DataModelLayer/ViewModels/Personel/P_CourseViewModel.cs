using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.Personel
{
    public class P_CourseViewModel
    {
        public string Id { get; set; }

        [Display(Name = "کد پرسنلی")]
        public string PersonelCode { get; set; }

        [Display(Name = "نام")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }

        [Display(Name = "عنوان مدرک")]
        public string Madrak { get; set; }

        [Display(Name = "تاریخ صدور")]

        public DateTime? IssueDate { get; set; }

        [Display(Name = "نام موسسه")]
        public string InstitueName { get; set; }
        public string Attachment { get; set; }
        public int Counter { get; set; }

        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public string Creator { get; set; }
        public string Modifier { get; set; }
    }
}
