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

           

            [Display(Name = "نام اضطراری")]
            public string IntroducedName { get; set; }

            [Display(Name = "شماره تلفن اضطراری")]
            public string IntroducedPhone { get; set; }

            [Display(Name = "آدرس اضطراری ")]
            public string IntroducedAddress { get; set; }
            public DateTime? CreationDate { get; set; }
            public DateTime? ModificationDate { get; set; }
            public string Creator { get; set; }
            public string Modifier { get; set; }

        
    }
}
