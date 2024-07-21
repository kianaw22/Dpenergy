using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.Personel
{
    public class P_AccountTypeViewModel
    {
        public string Id { get; set; }
        [Display(Name = "نوع حساب")]
        public string AccountType { get; set; }
    }
}
