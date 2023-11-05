using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.DMS.BasicInformation
{
    public class D_RevisionCodeViewModel
    {
        public string Id { get; set; }
        [Required]
        [Display(Name = "ProjectCode")]
        public string ProjectCode { get; set; }

        [Required]
        [Display(Name = "Revision Name")]
        public string RevisionName { get; set; }

        [Required]
        [Display(Name = "Order")]
        public int Order { get; set; }
        [Display(Name = "Creator")]
        public string? Creator { get; set; }

        [Display(Name = "CreationDate")]
        public DateTime? CreationDate { get; set; }

        [Display(Name = "Modifier")]
        public string? Modifier { get; set; }

        [Display(Name = "ModificationDate")]
        public DateTime? ModificationDate { get; set; }
    }
}
