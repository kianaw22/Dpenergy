using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.Personel
{
    public class P_InstitutionNameViewModel
    {
        public string Id { get; set; }
        [Display(Name = "نام موسسه")]
        public string InstitutionName { get; set; }
    }
}
