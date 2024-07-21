using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.Personel
{
    public class P_PersonelStatusViewModel
    {
        public string Id { get; set; }
        [Display(Name = "وضعیت پرسنل")]
        public string PersonelStatus { get; set; }
    }
}
