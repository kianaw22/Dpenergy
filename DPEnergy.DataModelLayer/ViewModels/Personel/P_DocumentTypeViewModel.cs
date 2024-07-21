using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.Personel
{
    public class P_DocumentTypeViewModel
    {
        public string Id { get; set; }
        [Display(Name = "نوع مدرک")]
        public string DocumentType { get; set; }
    }
}
