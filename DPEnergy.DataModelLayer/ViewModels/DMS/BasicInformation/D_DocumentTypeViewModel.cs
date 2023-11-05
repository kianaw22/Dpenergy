using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.DMS.BasicInformation
{
    public class D_DocumentTypeViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Types Of File")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} وارد نشده است.")]
        public string TypesOfFile { get; set; }


        [Display(Name = "Description")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} وارد نشده است.")]
        public string Description { get; set; }

        [Display(Name = "Project Code")]
        [Required(AllowEmptyStrings = true)]
        public string ProjectCode { get; set; }


        [Display(Name = "Creator")]
        public string Creator { get; set; }

        [Display(Name = "Order")]
        public int? Order { get; set; }

        [Display(Name = "CreationDate")]
        public DateTime? CreationDate { get; set; }

        [Display(Name = "Modifier")]
        public string Modifier { get; set; }

        [Display(Name = "ModificationDate")]
        public DateTime? ModificationDate { get; set; }
    }
}
