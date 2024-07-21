using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.Personel
{
    public class P_InsuranceStatusViewModel
    {
        public string Id { get; set; }
        [Display(Name = "وضعیت بیمه")]
        public string InsuranceStatus { get; set; }
    }
}
