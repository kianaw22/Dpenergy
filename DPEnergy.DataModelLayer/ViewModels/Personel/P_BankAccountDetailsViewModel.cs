using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.Personel
{
    public class P_BankAccountDetailsViewModel
    {
        public string Id { get; set; }
        [Display(Name = "کد پرسنلی")]
        public string PersonelCode { get; set; }

        [Display(Name = "نام")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }

        [Display(Name = "شماره شبا")]
        public string BankAccountNumber { get; set; }

        [Display(Name = "نام بانک")]
        public string BankName { get; set; }

        [Display(Name = "نوع حساب")]
        public string Accounttype { get; set; }

        [Display(Name = "شماره کارت")]
        public string CardNumber { get; set; }

        [Display(Name = "تاریخ انقضا")]
        public DateTime? ExpirationDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public string Creator { get; set; }
        public string Modifier { get; set; }

    }
}
