using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.Personel
{
    public class P_MaritalStatusViewModel
    {
        public string Id { get; set; }
        [Display(Name = "وضعیت تاهل")]
        public string MaritalStatus { get; set; }
    }
}
