using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.Personel
{
    public class P_ContractTypeViewModel
    {
        public string Id { get; set; }
        [Display(Name = "نوع قرارداد")]
        public string ContractType { get; set; }
    }
}
