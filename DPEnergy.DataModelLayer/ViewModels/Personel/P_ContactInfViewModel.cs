using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.Personel
{
   public  class P_ContactInfViewModel
    {

           public string Id { get; set; }
           [Display(Name = "کد پرسنلی")]
            public string PersonelCode { get; set; }

            [Display(Name = "نام")]
            public string FirstName { get; set; }

            [Display(Name = "نام خانوادگی")]
            public string LastName { get; set; }

            [Display(Name = "تلفن منزل")]
            public string HomePhone { get; set; }

            [Display(Name = "تلفن همراه")]
            public string MobilePhone { get; set; }

            [Display(Name = "آدرس")]
            public string Address { get; set; }

            [Display(Name = "نوع ملک")]
            public string PropertyType { get; set; }

            [Display(Name = "نام معرفی شده")]
            public string IntroducedName { get; set; }

            [Display(Name = "شماره تلفن معرفی شده")]
            public string IntroducedPhone { get; set; }

            [Display(Name = "آدرس معرفی شده ")]
            public string IntroducedAddress { get; set; }
            public DateTime? CreationDate { get; set; }
            public DateTime? ModificationDate { get; set; }
            public string Creator { get; set; }
            public string Modifier { get; set; }

        
    }
}
