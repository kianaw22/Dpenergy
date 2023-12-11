using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.Admin
{
    public class A_UserManagerViewModel
    {
        public string Id { get; set; }

        [Display(Name = "پرسنل")]
        [Required(ErrorMessage = "This field is reqiured")]
        public string Personel { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "This field is reqiured")]
        public string UserName { get; set; }

        [Display(Name = "پسورد")]
        public string Password { get; set; }

        [Display(Name = "تایید پسورد")]
        public string ConfirmPass { get; set; }

        [Display(Name = "ایمیل")]
        public string Email { get; set; }

        [Display(Name = "نام کاربری سیستمی")]
        public string SystemUserName { get; set; }

        [Display(Name = "پسورد سیستمی")]
        public string SystemPassword { get; set; }

        [Display(Name = "فعال")]
        public bool IsActive { get; set; }

    }
    public class LoginViewModel
    {
        [Display(Name = "نام کاربری")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "نام کاربری وارد نشده است")]
        [RegularExpression(@"^[^\\/:*;\\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده نکنید.")]
        public string UserName { get; set; }


        [Display(Name = "رمز عبور")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "رمز عبور وارد نشده است")]
        public string Password { get; set; }
    }
    public class NameAndPersonelCodeViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonelCode { get; set; }
        public string UserName { get; set; }

    }
}
