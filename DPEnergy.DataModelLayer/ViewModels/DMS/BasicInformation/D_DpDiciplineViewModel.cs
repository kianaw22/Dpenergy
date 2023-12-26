using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.DMS.BasicInformation
{
    public class D_DpDiciplineViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Dicipline")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
        public string Dicipline { get; set; }

        [Display(Name = "Title")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
        public string Title { get; set; }

        [Display(Name = "Order")]
        public int? Order { get; set; }

        [Display(Name = "Creator")]
        public string Creator { get; set; }

        [Display(Name = "Creation Date")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Modifier")]
        public string Modifier { get; set; }

        [Display(Name = "Modification Date")]
        public DateTime ModificationDate { get; set; }
    }
}
