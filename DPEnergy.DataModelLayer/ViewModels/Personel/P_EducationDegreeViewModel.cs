using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.Personel
{
    public class P_EducationDegreeViewModel
    {
        public string Id { get; set; }
        [Display(Name = "مدرک تحصیلی")]
        public string EducationDegree { get; set; }
    }
}
